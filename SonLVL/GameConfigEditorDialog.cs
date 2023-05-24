using SonicRetro.SonLVL.API;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SonicRetro.SonLVL
{
	public partial class GameConfigEditorDialog : Form
	{
		public GameConfigEditorDialog(List<string> scriptFiles, List<string> sfxFiles)
		{
			InitializeComponent();
			this.scriptFiles = scriptFiles;
			this.sfxFiles = sfxFiles;
		}

		bool loaded = false;
		bool isxml = false;
		bool convert = false;
		RSDKv3_4.GameConfig origConf;
		List<ObjectXML> objects;
		List<ObjectXML> origobjs;
		List<ObjectXML> origgcobjs;
		List<VariableXML> variables;
		List<SoundFXXML> sounds;
		List<string> players;
		readonly List<StageXML>[] stages = new List<StageXML>[4];
		readonly List<string> scriptFiles;
		readonly List<string> sfxFiles;
		readonly List<string> stageFiles = new List<string>();
		private void GameConfigEditorDialog_Load(object sender, EventArgs e)
		{
			switch (LevelData.Game.RSDKVer)
			{
				case EngineVersion.V4:
					origConf = LevelData.ReadFileNoMod<RSDKv4.GameConfig>("Data/Game/GameConfig.bin");
					break;
				case EngineVersion.V3:
					origConf = LevelData.ReadFileNoMod<RSDKv3.GameConfig>("Data/Game/GameConfig.bin");
					break;
			}
			gameName.Text = LevelData.GameConfig.gameTitle;
			StringBuilder sb = new StringBuilder(LevelData.GameConfig.gameDescription);
			for (int i = 0; i < sb.Length; i++)
				switch (sb[i])
				{
					case '\r':
						sb.Insert(++i, '\n');
						break;
					case '\n':
						sb.Insert(i++, '\r');
						break;
				}
			gameDescription.Text = sb.ToString();
			switch (LevelData.Game.RSDKVer)
			{
				case EngineVersion.V3:
					gameDescription.Text = LevelData.GameConfig.gameDescription.Replace("\r", Environment.NewLine);
					break;
				case EngineVersion.V4:
					gameDescription.Text = LevelData.GameConfig.gameDescription.Replace("\n", Environment.NewLine);
					break;
			}
			if (LevelData.GameXML != null)
			{
				isxml = true;
				objects = new List<ObjectXML>(LevelData.GameXML.objects.Select(a => a.Clone()));
				origgcobjs = new List<ObjectXML>(LevelData.GameConfig.objects.Select(a => (ObjectXML)a));
				origobjs = new List<ObjectXML>(origgcobjs.Concat(objects.Where(a => !a.forceLoad)));
				variables = new List<VariableXML>(LevelData.GameXML.variables.Select(a => a.Clone()));
				sounds = new List<SoundFXXML>(LevelData.GameXML.sounds.Select(a => a.Clone()));
				players = new List<string>(LevelData.GameXML.players.Select(a => a.name));
				stages[0] = new List<StageXML>(LevelData.GameXML.presentationStages.Select(a => a.Clone()));
				stages[1] = new List<StageXML>(LevelData.GameXML.regularStages.Select(a => a.Clone()));
				stages[2] = new List<StageXML>(LevelData.GameXML.specialStages.Select(a => a.Clone()));
				stages[3] = new List<StageXML>(LevelData.GameXML.bonusStages.Select(a => a.Clone()));
			}
			else
			{
				objects = new List<ObjectXML>(LevelData.GameConfig.objects.Select(a => (ObjectXML)a));
				origgcobjs = new List<ObjectXML>(objects);
				origobjs = new List<ObjectXML>(objects);
				variables = new List<VariableXML>(LevelData.GameConfig.globalVariables.Select(a => (VariableXML)a));
				sounds = new List<SoundFXXML>(LevelData.GameConfig.soundFX.Select(a => (SoundFXXML)a));
				players = new List<string>(LevelData.GameConfig.players);
				for (int i = 0; i < 4; i++)
					stages[i] = new List<StageXML>(LevelData.GameConfig.stageLists[i].list.Select(a => (StageXML)a));
			}
			if (LevelData.Game.RSDKVer != EngineVersion.V4)
				sounds.ForEach(a => a.name = Path.GetFileNameWithoutExtension(a.path));
			ReloadData();
			loaded = true;
			if (Directory.Exists("Data/Stages"))
				stageFiles.AddRange(GetFilesRelative(Path.Combine(Directory.GetCurrentDirectory(), "Data/Stages"), "Act*.bin"));
			if (LevelData.ModFolder != null && Directory.Exists(Path.Combine(LevelData.ModFolder, "Data/Stages")))
				stageFiles.AddRange(GetFilesRelative(Path.Combine(Directory.GetCurrentDirectory(), LevelData.ModFolder, "Data/Stages"), "Act*.bin").Where(a => !stageFiles.Contains(a)));
			stageFolder.AutoCompleteCustomSource.AddRange(stageFiles.Select(a => a.Remove(a.LastIndexOf('/'))).Distinct().ToArray());
			stageCategory.SelectedIndex = 0;
		}

		private IEnumerable<string> GetFilesRelative(string folder, string pattern) => Directory.EnumerateFiles(folder, pattern, SearchOption.AllDirectories).Select(a => a.Substring(folder.Length + 1).Replace(Path.DirectorySeparatorChar, '/'));

		private void ReloadData()
		{
			if (isxml)
			{
				convertButton.Text = "Convert to BIN";
				gameName.Enabled = false;
				gameDescription.Enabled = false;
				objectForceLoad.Visible = true;
			}
			else
			{
				convertButton.Text = "Convert to XML";
				gameName.Enabled = true;
				gameDescription.Enabled = true;
				objectForceLoad.Visible = false;
			}
			objectListBox.BeginUpdate();
			objectListBox.Items.Clear();
			foreach (var item in objects)
				objectListBox.Items.Add(item.name);
			objectListBox.EndUpdate();
			objectAddButton.Enabled = objects.Count < 255;
			objectScriptBox.AutoCompleteCustomSource.Clear();
			objectScriptBox.AutoCompleteCustomSource.AddRange(scriptFiles.ToArray());
			variableListBox.BeginUpdate();
			variableListBox.Items.Clear();
			foreach (var item in variables)
				variableListBox.Items.Add(item.name);
			variableListBox.EndUpdate();
			variableAddButton.Enabled = variables.Count < 255;
			sfxListBox.BeginUpdate();
			sfxListBox.Items.Clear();
			foreach (var sfx in sounds)
				sfxListBox.Items.Add(sfx.name);
			sfxListBox.EndUpdate();
			sfxAddButton.Enabled = sounds.Count < 255;
			sfxFileBox.AutoCompleteCustomSource.Clear();
			sfxFileBox.AutoCompleteCustomSource.AddRange(sfxFiles.ToArray());
			playerListBox.BeginUpdate();
			playerListBox.Items.Clear();
			foreach (var item in players)
				playerListBox.Items.Add(item);
			playerListBox.EndUpdate();
			playerAddButton.Enabled = players.Count < 255;
		}

		private void objectListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			if (objectListBox.SelectedIndex == -1)
			{
				objectDeleteButton.Enabled = false;
				objectNameBox.Enabled = false;
				objectScriptBox.Enabled = false;
				browseScriptButton.Enabled = false;
				objectForceLoad.Enabled = false;
			}
			else
			{
				objectDeleteButton.Enabled = true;
				objectNameBox.Enabled = true;
				objectScriptBox.Enabled = true;
				browseScriptButton.Enabled = true;
				objectForceLoad.Enabled = true;
				loaded = false;
				objectNameBox.Text = objects[objectListBox.SelectedIndex].name;
				objectScriptBox.Text = objects[objectListBox.SelectedIndex].script;
				objectForceLoad.Checked = objects[objectListBox.SelectedIndex].forceLoad;
				loaded = true;
			}
		}

		private void objectAddButton_Click(object sender, EventArgs e)
		{
			var info = new ObjectXML("Object", "Folder/Script.txt");
			objects.Add(info);
			objectListBox.Items.Add(info.name);
			objectListBox.SelectedIndex = objectListBox.Items.Count - 1;
			objectAddButton.Enabled = objects.Count < 255;
		}

		private void objectDeleteButton_Click(object sender, EventArgs e)
		{
			objects.RemoveAt(objectListBox.SelectedIndex);
			objectListBox.Items.RemoveAt(objectListBox.SelectedIndex);
			objectAddButton.Enabled = objects.Count < 255;
		}

		private void objectNameBox_TextChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			objects[objectListBox.SelectedIndex].name = objectNameBox.Text;
			loaded = false;
			objectListBox.Items[objectListBox.SelectedIndex] = objectNameBox.Text;
			loaded = true;
		}

		private void objectScriptBox_TextChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			objects[objectListBox.SelectedIndex].script = objectScriptBox.Text;
		}

		private void browseScriptButton_Click(object sender, EventArgs e)
		{
			using (FileSelectDialog dlg = new FileSelectDialog("Scripts", scriptFiles))
				if (dlg.ShowDialog(this) == DialogResult.OK)
					objectScriptBox.Text = dlg.SelectedPath;
		}

		private void objectForceLoad_CheckedChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			objects[objectListBox.SelectedIndex].forceLoad = objectForceLoad.Checked;
		}

		private void variableListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			if (variableListBox.SelectedIndex == -1)
			{
				variableDeleteButton.Enabled = false;
				variableName.Enabled = false;
				variableValue.Enabled = false;
			}
			else
			{
				variableDeleteButton.Enabled = true;
				variableName.Enabled = true;
				variableValue.Enabled = true;
				loaded = false;
				variableName.Text = variables[variableListBox.SelectedIndex].name;
				variableValue.Value = variables[variableListBox.SelectedIndex].value;
				loaded = true;
			}
		}

		private void variableAddButton_Click(object sender, EventArgs e)
		{
			var info = new VariableXML("Variable");
			variables.Add(info);
			variableListBox.Items.Add(info.name);
			variableListBox.SelectedIndex = variableListBox.Items.Count - 1;
			variableAddButton.Enabled = variables.Count < 255;
		}

		private void variableDeleteButton_Click(object sender, EventArgs e)
		{
			variables.RemoveAt(variableListBox.SelectedIndex);
			variableListBox.Items.RemoveAt(variableListBox.SelectedIndex);
			variableAddButton.Enabled = variables.Count < 255;
		}

		private void variableName_TextChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			variables[variableListBox.SelectedIndex].name = variableName.Text;
			loaded = false;
			variableListBox.Items[variableListBox.SelectedIndex] = variableName.Text;
			loaded = true;
		}

		private void variableValue_ValueChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			variables[variableListBox.SelectedIndex].value = (int)variableValue.Value;
		}

		private void sfxListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			if (sfxListBox.SelectedIndex == -1)
			{
				sfxDeleteButton.Enabled = false;
				sfxNameBox.Enabled = false;
				sfxFileBox.Enabled = false;
				sfxBrowseButton.Enabled = false;
			}
			else
			{
				sfxDeleteButton.Enabled = true;
				sfxNameBox.Enabled = LevelData.Game.RSDKVer == EngineVersion.V4;
				sfxFileBox.Enabled = true;
				sfxBrowseButton.Enabled = true;
				loaded = false;
				sfxNameBox.Text = sounds[sfxListBox.SelectedIndex].name;
				sfxFileBox.Text = sounds[sfxListBox.SelectedIndex].path;
				loaded = true;
			}
		}

		private void sfxAddButton_Click(object sender, EventArgs e)
		{
			var info = new SoundFXXML("Sound", "Folder/Sound.wav");
			sounds.Add(info);
			sfxListBox.Items.Add(info.name);
			sfxListBox.SelectedIndex = sfxListBox.Items.Count - 1;
			sfxAddButton.Enabled = sounds.Count < 255;
		}

		private void sfxDeleteButton_Click(object sender, EventArgs e)
		{
			sounds.RemoveAt(sfxListBox.SelectedIndex);
			sfxListBox.Items.RemoveAt(sfxListBox.SelectedIndex);
			sfxAddButton.Enabled = sounds.Count < 255;
		}

		private void sfxNameBox_TextChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			sounds[sfxListBox.SelectedIndex].name = sfxNameBox.Text;
			loaded = false;
			sfxListBox.Items[sfxListBox.SelectedIndex] = sfxNameBox.Text;
			loaded = true;
		}

		private void sfxFileBox_TextChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			sounds[sfxListBox.SelectedIndex].path = sfxFileBox.Text;
			if (LevelData.Game.RSDKVer != EngineVersion.V4)
				sfxNameBox.Text = Path.GetFileNameWithoutExtension(sfxFileBox.Text);
		}

		private void sfxBrowseButton_Click(object sender, EventArgs e)
		{
			using (FileSelectDialog dlg = new FileSelectDialog("Sound Effects", sfxFiles))
				if (dlg.ShowDialog(this) == DialogResult.OK)
					sfxFileBox.Text = dlg.SelectedPath;
		}

		private void playerListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			if (playerListBox.SelectedIndex == -1)
			{
				playerDeleteButton.Enabled = false;
				playerName.Enabled = false;
			}
			else
			{
				playerDeleteButton.Enabled = true;
				playerName.Enabled = true;
				loaded = false;
				playerName.Text = players[playerListBox.SelectedIndex];
				loaded = true;
			}
		}

		private void playerAddButton_Click(object sender, EventArgs e)
		{
			var info = "Player";
			players.Add(info);
			playerListBox.Items.Add(info);
			playerListBox.SelectedIndex = playerListBox.Items.Count - 1;
			playerAddButton.Enabled = players.Count < 255;
		}

		private void playerDeleteButton_Click(object sender, EventArgs e)
		{
			players.RemoveAt(playerListBox.SelectedIndex);
			playerListBox.Items.RemoveAt(playerListBox.SelectedIndex);
			playerAddButton.Enabled = players.Count < 255;
		}

		private void playerName_TextChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			players[playerListBox.SelectedIndex] = playerName.Text;
			loaded = false;
			playerListBox.Items[playerListBox.SelectedIndex] = playerName.Text;
			loaded = true;
		}

		private void stageCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			ReloadStageList();
		}

		private void ReloadStageList()
		{
			stageListBox.BeginUpdate();
			stageListBox.Items.Clear();
			foreach (var item in stages[stageCategory.SelectedIndex])
				stageListBox.Items.Add(item.name);
			stageListBox.EndUpdate();
			stageAddButton.Enabled = stages[stageCategory.SelectedIndex].Count < 255;
			stageDeleteButton.Enabled = false;
			stageFolder.Enabled = false;
			stageAct.Enabled = false;
			stageName.Enabled = false;
			stageHighlight.Enabled = false;
			stageBrowseButton.Enabled = false;
		}

		private void stageListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			if (stageListBox.SelectedIndex == -1)
			{
				stageDeleteButton.Enabled = false;
				stageFolder.Enabled = false;
				stageAct.Enabled = false;
				stageName.Enabled = false;
				stageHighlight.Enabled = false;
				stageBrowseButton.Enabled = false;
			}
			else
			{
				stageDeleteButton.Enabled = true;
				stageFolder.Enabled = true;
				stageAct.Enabled = true;
				stageName.Enabled = true;
				stageHighlight.Enabled = true;
				stageBrowseButton.Enabled = true;
				loaded = false;
				stageFolder.Text = stages[stageCategory.SelectedIndex][stageListBox.SelectedIndex].folder;
				stageAct.Text = stages[stageCategory.SelectedIndex][stageListBox.SelectedIndex].id;
				stageName.Text = stages[stageCategory.SelectedIndex][stageListBox.SelectedIndex].name;
				stageHighlight.Checked = stages[stageCategory.SelectedIndex][stageListBox.SelectedIndex].highlight;
				loaded = true;
			}
		}

		private void stageAddButton_Click(object sender, EventArgs e)
		{
			var info = new StageXML("STAGE", "Stage", "1", true);
			stages[stageCategory.SelectedIndex].Add(info);
			stageListBox.Items.Add(info.name);
			stageListBox.SelectedIndex = stageListBox.Items.Count - 1;
			stageAddButton.Enabled = stages[stageCategory.SelectedIndex].Count < 255;
		}

		private void stageDeleteButton_Click(object sender, EventArgs e)
		{
			stages[stageCategory.SelectedIndex].RemoveAt(stageListBox.SelectedIndex);
			stageListBox.Items.RemoveAt(stageListBox.SelectedIndex);
			stageAddButton.Enabled = stages[stageCategory.SelectedIndex].Count < 255;
		}

		private void stageFolder_TextChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			stages[stageCategory.SelectedIndex][stageListBox.SelectedIndex].folder = stageFolder.Text;
		}

		private void stageAct_TextChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			stages[stageCategory.SelectedIndex][stageListBox.SelectedIndex].id = stageAct.Text;
		}

		private void stageName_TextChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			stages[stageCategory.SelectedIndex][stageListBox.SelectedIndex].name = stageName.Text;
			loaded = false;
			stageListBox.Items[stageListBox.SelectedIndex] = stageName.Text;
			loaded = true;
		}

		private void stageHighlight_CheckedChanged(object sender, EventArgs e)
		{
			if (!loaded) return;
			stages[stageCategory.SelectedIndex][stageListBox.SelectedIndex].highlight = stageHighlight.Checked;
		}

		private void stageBrowseButton_Click(object sender, EventArgs e)
		{
			using (FileSelectDialog dlg = new FileSelectDialog("Stages", stageFiles))
				if (dlg.ShowDialog(this) == DialogResult.OK)
				{
					string path = dlg.SelectedPath;
					int i = path.LastIndexOf('/');
					stageFolder.Text = path.Substring(0, i);
					stageAct.Text = path.Substring(i + 4, path.Length - (i + 8));
				}
		}

		private void convertButton_Click(object sender, EventArgs e)
		{
			if (isxml)
			{
				if (objects.Any(a => a.forceLoad))
					switch (MessageBox.Show(this, "XML contains forceLoad objects that the BIN format cannot properly represent.\n\nDo you want to change them to normal global objects (Yes) or remove them from the list (No)?", "forceLoad Objects Found", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3))
					{
						case DialogResult.Yes:
							break;
						case DialogResult.No:
							objects.RemoveAll(a => a.forceLoad);
							break;
						default:
							return;
					}
				objects.InsertRange(0, origgcobjs.Except(objects));
				variables.InsertRange(0, LevelData.GameConfig.globalVariables.Select(a => (VariableXML)a));
				sounds.InsertRange(0, LevelData.GameConfig.soundFX.Select(a => (SoundFXXML)a));
				players.InsertRange(0, LevelData.GameConfig.players);
				for (int i = 0; i < 4; i++)
					stages[i].InsertRange(0, LevelData.GameConfig.stageLists[i].list.Select(a => (StageXML)a));
				isxml = false;
			}
			else
			{
				objects = objects.Except(origConf.objects.Select(a => (ObjectXML)a)).ToList();
				variables = variables.Except(origConf.globalVariables.Select(a => (VariableXML)a)).ToList();
				sounds = sounds.Except(origConf.soundFX.Select(a => (SoundFXXML)a)).ToList();
				players = players.Except(origConf.players).ToList();
				for (int i = 0; i < 4; i++)
					stages[i] = stages[i].Except(LevelData.GameConfig.stageLists[i].list.Select(a => (StageXML)a)).ToList();
				isxml = true;
			}
			convert = true;
			ReloadData();
			objectDeleteButton.Enabled = false;
			objectNameBox.Enabled = false;
			objectScriptBox.Enabled = false;
			browseScriptButton.Enabled = false;
			objectForceLoad.Enabled = false;
			variableDeleteButton.Enabled = false;
			variableName.Enabled = false;
			variableValue.Enabled = false;
			sfxDeleteButton.Enabled = false;
			sfxNameBox.Enabled = false;
			sfxFileBox.Enabled = false;
			sfxBrowseButton.Enabled = false;
			playerDeleteButton.Enabled = false;
			playerName.Enabled = false;
			ReloadStageList();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(this, "Editing GameConfig cannot be undone, and will reload the currently open level (if any). Proceed?", "SonLVL-RSDK", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
				return;
			List<ObjectXML> tmpobjects = new List<ObjectXML>(objects);
			if (isxml)
			{
				tmpobjects.RemoveAll(a => a.forceLoad);
				tmpobjects.InsertRange(0, origConf.objects.Select(a => (ObjectXML)a));
			}
			if (!origobjs.SequenceEqual(tmpobjects))
				switch (MessageBox.Show(this, "Object list has been edited!\n\nDo you want to adjust the entities in all stages that use global objects to match?", "Object List Edited", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3))
				{
					case DialogResult.Yes:
						int offset = tmpobjects.Count - origobjs.Count;
						int[] objmap = new int[origobjs.Count + 1];
						for (int i = 0; i < origobjs.Count; i++)
							objmap[i + 1] = tmpobjects.IndexOf(origobjs[i]) + 1;
						IEnumerable<StageXML> allstg = stages.SelectMany(a => a);
						if (isxml)
							allstg = allstg.Concat(origConf.stageLists.SelectMany(a => a.list).Select(a => (StageXML)a));
						foreach (var stginf in allstg)
						{
							RSDKv3_4.StageConfig stgconf = null;
							switch (LevelData.Game.RSDKVer)
							{
								case EngineVersion.V3:
									stgconf = LevelData.ReadFile<RSDKv3.StageConfig>($"Data/Stages/{stginf.folder}/StageConfig.bin");
									break;
								case EngineVersion.V4:
									stgconf = LevelData.ReadFile<RSDKv4.StageConfig>($"Data/Stages/{stginf.folder}/StageConfig.bin");
									break;
							}
							if (!stgconf.loadGlobalObjects) continue;
							RSDKv3_4.Scene scene = null;
							switch (LevelData.Game.RSDKVer)
							{
								case EngineVersion.V3:
									scene = LevelData.ReadFile<RSDKv3.Scene>($"Data/Stages/{stginf.folder}/Act{stginf.id}.bin");
									break;
								case EngineVersion.V4:
									scene = LevelData.ReadFile<RSDKv4.Scene>($"Data/Stages/{stginf.folder}/Act{stginf.id}.bin");
									break;
							}
							bool edit = false;
							List<RSDKv3_4.Scene.Entity> del = new List<RSDKv3_4.Scene.Entity>();
							foreach (var ent in scene.entities)
							{
								if (ent.type >= objmap.Length)
								{
									if (offset != 0)
									{
										ent.type = (byte)(ent.type + offset);
										edit = true;
									}
								}
								else if (ent.type > 0)
								{
									int t2 = objmap[ent.type];
									if (t2 == 0)
										del.Add(ent);
									else if (t2 != ent.type)
									{
										ent.type = (byte)t2;
										edit = true;
									}
								}
							}
							if (del.Count > 0)
							{
								del.ForEach(a => scene.entities.Remove(a));
								edit = true;
							}
							if (edit)
							{
								Directory.CreateDirectory(Path.Combine(LevelData.ModFolder, $"Data/Stages/{stginf.folder}"));
								scene.Write(Path.Combine(LevelData.ModFolder, $"Data/Stages/{stginf.folder}/Act{stginf.id}.bin"));
							}
						}
						break;
					case DialogResult.No:
						break;
					default:
						return;
				}
			Directory.CreateDirectory(Path.Combine(LevelData.ModFolder, "Data/Game"));
			if (isxml)
			{
				if (convert)
				{
					LevelData.GameXML = new GameXML();
					string path = Path.Combine(LevelData.ModFolder, "Data/Game/GameConfig.bin");
					if (File.Exists(path))
						File.Delete(path);
					switch (LevelData.Game.RSDKVer)
					{
						case EngineVersion.V3:
							path = Path.Combine(LevelData.ModFolder, "Data/Palettes/MasterPalette.act");
							if (File.Exists(path))
							{
								byte[] modpal = File.ReadAllBytes(path);
								byte[] origpal = LevelData.ReadFileRawNoMod("Data/Palettes/MasterPalette.act");
								int pallen = Math.Min(Math.Min(modpal.Length, origpal.Length) / 3, 256);
								int v = 0;
								for (int i = 0; i < pallen; i++)
								{
									if (origpal[v] != modpal[v] || origpal[v + 1] != modpal[v + 1] || origpal[v + 2] != modpal[v + 2])
										LevelData.GameXML.palette.Add(new ColorXML(0, (byte)i, modpal[v], modpal[v + 1], modpal[v + 2]));
									v += 3;
								}
								File.Delete(path);
							}
							break;
						case EngineVersion.V4:
							{
								var modpal = ((RSDKv4.GameConfig)LevelData.GameConfig).masterPalette;
								var origpal = ((RSDKv4.GameConfig)origConf).masterPalette;
								int i = 0;
								for (int l = 0; l < modpal.colors.Length; l++)
									for (int c = 0; c < modpal.colors[l].Length; c++)
									{
										if (i == 256) break;
										if (origpal.colors[l][c].r != modpal.colors[l][c].r || origpal.colors[l][c].g != modpal.colors[l][c].g || origpal.colors[l][c].b != modpal.colors[l][c].b)
											LevelData.GameXML.palette.Add(new ColorXML(0, (byte)i, modpal.colors[l][c]));
										++i;
									}
							}
							break;
					}
				}
				LevelData.GameXML.objects = objects;
				LevelData.GameXML.variables = variables;
				LevelData.GameXML.sounds = sounds;
				if (LevelData.Game.RSDKVer != EngineVersion.V4)
					sounds.ForEach(a => a.name = null);
				LevelData.GameXML.players = players.Select(a => new PlayerXML(a)).ToList();
				LevelData.GameXML.presentationStages = stages[0];
				LevelData.GameXML.regularStages = stages[1];
				LevelData.GameXML.specialStages = stages[2];
				LevelData.GameXML.bonusStages = stages[3];
				LevelData.GameXML.Save(Path.Combine(LevelData.ModFolder, "Data/Game/game.xml"));
			}
			else
			{
				if (convert)
				{
					string path = Path.Combine(LevelData.ModFolder, "Data/Game/game.xml");
					if (File.Exists(path))
						File.Delete(path);
					if (LevelData.GameXML.palette.Any(a => a.bank == 0))
						switch (LevelData.Game.RSDKVer)
						{
							case EngineVersion.V3:
								{
									byte[] pal = LevelData.ReadFileRaw("Data/Palettes/MasterPalette.act");
									foreach (var item in LevelData.GameXML.palette.Where(a => a.bank == 0))
									{
										pal[item.index * 3] = item.r;
										pal[item.index * 3 + 1] = item.g;
										pal[item.index * 3 + 2] = item.b;
									}
									File.WriteAllBytes(Path.Combine(LevelData.ModFolder, "Data/Palettes/MasterPalette.act"), pal);
								}
								break;
							case EngineVersion.V4:
								{
									var pal = ((RSDKv4.GameConfig)LevelData.GameConfig).masterPalette;
									foreach (var item in LevelData.GameXML.palette.Where(a => a.bank == 0))
									{
										int l = Math.DivRem(item.index, pal.colors[0].Length, out int c);
										pal.colors[l][c] = new RSDKv3_4.Palette.Color(item.r, item.g, item.b);
									}
								}
								break;
						}
				}
				LevelData.GameConfig.gameTitle = gameName.Text;
				LevelData.GameConfig.gameDescription = gameDescription.Text.Replace(Environment.NewLine, "\n");
				LevelData.GameConfig.objects = objects.Select(a => (RSDKv3_4.GameConfig.ObjectInfo)a).ToList();
				switch (LevelData.Game.RSDKVer)
				{
					case EngineVersion.V3:
						LevelData.GameConfig.globalVariables = new List<RSDKv3_4.GameConfig.GlobalVariable>(variables.Select(a => (RSDKv3.GameConfig.GlobalVariable)a));
						break;
					case EngineVersion.V4:
						LevelData.GameConfig.globalVariables = new List<RSDKv3_4.GameConfig.GlobalVariable>(variables.Select(a => (RSDKv4.GameConfig.GlobalVariable)a));
						break;
				}
				LevelData.GameConfig.soundFX = sounds.Select(a => (RSDKv3_4.GameConfig.SoundInfo)a).ToList();
				LevelData.GameConfig.players = players;
				for (int i = 0; i < 4; i++)
					LevelData.GameConfig.stageLists[i].list = stages[i].Select(a => (RSDKv3_4.GameConfig.StageList.StageInfo)a).ToList();
				LevelData.GameConfig.Write(Path.Combine(LevelData.ModFolder, "Data/Game/GameConfig.bin"));
			}
			Close();
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
