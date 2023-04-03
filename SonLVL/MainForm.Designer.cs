namespace SonicRetro.SonLVL.GUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
			System.Windows.Forms.Label label4;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label2;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
			System.Windows.Forms.ToolStrip chunkListToolStrip;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.ToolStrip tileListToolStrip;
			System.Windows.Forms.TabControl tabControl2;
			System.Windows.Forms.ToolStrip layoutSectionListToolStrip;
			System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
			System.Windows.Forms.Label label1;
			System.Windows.Forms.Panel panel11;
			System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
			System.Windows.Forms.Panel panel1;
			System.Windows.Forms.Panel panel9;
			System.Windows.Forms.Label label26;
			System.Windows.Forms.Label label7;
			System.Windows.Forms.Label label6;
			System.Windows.Forms.Label label5;
			System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
			System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
			System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
			System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
			System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
			System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
			System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
			System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
			System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
			this.importChunksToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.drawChunkToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.deleteUnusedChunksToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.removeDuplicateChunksToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.replaceChunkBlocksToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.remapChunksButton = new System.Windows.Forms.ToolStripButton();
			this.enableDraggingChunksButton = new System.Windows.Forms.ToolStripButton();
			this.importTilesToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.drawTileToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.deleteUnusedTilesToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.removeDuplicateTilesToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.remapTilesButton = new System.Windows.Forms.ToolStripButton();
			this.enableDraggingTilesButton = new System.Windows.Forms.ToolStripButton();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.ChunkSelector = new SonicRetro.SonLVL.API.TileList();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.layoutSectionSplitContainer = new System.Windows.Forms.SplitContainer();
			this.layoutSectionListBox = new System.Windows.Forms.ListBox();
			this.importToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.layoutSectionPreview = new System.Windows.Forms.PictureBox();
			this.flipTileHButton = new System.Windows.Forms.Button();
			this.flipTileVButton = new System.Windows.Forms.Button();
			this.TileID = new System.Windows.Forms.NumericUpDown();
			this.rotateTileRightButton = new System.Windows.Forms.Button();
			this.TileCount = new System.Windows.Forms.Label();
			this.flipChunkVButton = new System.Windows.Forms.Button();
			this.chunkBlockEditor = new SonicRetro.SonLVL.ChunkBlockEditor();
			this.flipChunkHButton = new System.Windows.Forms.Button();
			this.ChunkCount = new System.Windows.Forms.Label();
			this.chunkCtrlLabel = new System.Windows.Forms.Label();
			this.ChunkID = new System.Windows.Forms.NumericUpDown();
			this.ChunkPicture = new SonicRetro.SonLVL.API.KeyboardPanel();
			this.colFlags = new System.Windows.Forms.NumericUpDown();
			this.ceilingAngle = new System.Windows.Forms.NumericUpDown();
			this.rightAngle = new System.Windows.Forms.NumericUpDown();
			this.leftAngle = new System.Windows.Forms.NumericUpDown();
			this.collisionCeiling = new System.Windows.Forms.CheckBox();
			this.collisionLayerSelector = new System.Windows.Forms.ComboBox();
			this.calculateAngleButton = new System.Windows.Forms.Button();
			this.showBlockBehindCollisionCheckBox = new System.Windows.Forms.CheckBox();
			this.floorAngle = new System.Windows.Forms.NumericUpDown();
			this.ColPicture = new System.Windows.Forms.Panel();
			this.TilePicture = new System.Windows.Forms.Panel();
			this.panel10 = new System.Windows.Forms.Panel();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editGameConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.presentationStagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.regularStagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.specialStagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bonusStagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buildAndRunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recentProjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noneToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.recentModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.resizeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
			this.includeObjectsWithForegroundSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.switchMouseButtonsInChunkAndBlockEditorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.includeobjectsWithFGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.objectsAboveHighPlaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.invertColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.layersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.collisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.noneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.path1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.path2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.anglesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enableGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.xToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.xToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.xToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.xToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.usageCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.yYCHRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jASCPALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chunksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.solidityMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.foregroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.transparentBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.useHexadecimalIndexesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportArtcollisionpriorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewReadmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.backgroundLevelLoader = new System.ComponentModel.BackgroundWorker();
			this.objectContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addGroupOfObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.selectAllObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ObjectProperties = new System.Windows.Forms.PropertyGrid();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.objectTypeList = new System.Windows.Forms.ListView();
			this.objectTypeImages = new System.Windows.Forms.ImageList(this.components);
			this.objectPanel = new SonicRetro.SonLVL.ScrollingPanel();
			this.objToolStrip = new System.Windows.Forms.ToolStrip();
			this.objGridSizeDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
			this.alignLeftWallToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.alignGroundToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.alignRightWallToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.alignCeilingToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.alignLeftsToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.alignCentersToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.alignRightsToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.alignTopsToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.alignMiddlesToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.alignBottomsToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.tabControl5 = new System.Windows.Forms.TabControl();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.objectOrder = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.foregroundPanel = new SonicRetro.SonLVL.ScrollingPanel();
			this.fgToolStrip = new System.Windows.Forms.ToolStrip();
			this.replaceForegroundToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.clearForegroundToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.backgroundPanel = new SonicRetro.SonLVL.ScrollingPanel();
			this.bgToolStrip = new System.Windows.Forms.ToolStrip();
			this.bgLayerDropDown = new System.Windows.Forms.ToolStripDropDownButton();
			this.replaceBackgroundToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.clearBackgroundToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.tabControl3 = new System.Windows.Forms.TabControl();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.tabPage11 = new System.Windows.Forms.TabPage();
			this.tabPage13 = new System.Windows.Forms.TabPage();
			this.showScrollAreas = new System.Windows.Forms.CheckBox();
			this.scrollFrame = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.scrollCamY = new System.Windows.Forms.NumericUpDown();
			this.scrollCamX = new System.Windows.Forms.NumericUpDown();
			this.label15 = new System.Windows.Forms.Label();
			this.scrollTargetFPS = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.scrollPreviewButton = new System.Windows.Forms.CheckBox();
			this.scrollEditPanel = new System.Windows.Forms.Panel();
			this.scrollOffset = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.scrollScrollSpeed = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.scrollParallaxFactor = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.deleteScrollButton = new System.Windows.Forms.Button();
			this.addScrollButton = new System.Windows.Forms.Button();
			this.scrollEnableDeformation = new System.Windows.Forms.CheckBox();
			this.scrollList = new System.Windows.Forms.ListBox();
			this.layerScrollSpeed = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			this.layerParallaxFactor = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.layerScrollType = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tabControl4 = new System.Windows.Forms.TabControl();
			this.tabPage12 = new System.Windows.Forms.TabPage();
			this.tabPage14 = new System.Windows.Forms.TabPage();
			this.TileSelector = new SonicRetro.SonLVL.API.TileList();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.PalettePanel = new System.Windows.Forms.Panel();
			this.colorEditingPanel = new System.Windows.Forms.Panel();
			this.colorBlue = new System.Windows.Forms.NumericUpDown();
			this.colorGreen = new System.Windows.Forms.NumericUpDown();
			this.colorRed = new System.Windows.Forms.NumericUpDown();
			this.paletteToolStrip = new System.Windows.Forms.ToolStrip();
			this.importPaletteToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.enableDraggingPaletteButton = new System.Windows.Forms.ToolStripButton();
			this.tabPage15 = new System.Windows.Forms.TabPage();
			this.soundEffectsGroup = new System.Windows.Forms.GroupBox();
			this.sfxBrowseButton = new System.Windows.Forms.Button();
			this.sfxFileBox = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.sfxNameBox = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.sfxDeleteButton = new System.Windows.Forms.Button();
			this.sfxAddButton = new System.Windows.Forms.Button();
			this.sfxListBox = new System.Windows.Forms.ListBox();
			this.objectListGroup = new System.Windows.Forms.GroupBox();
			this.browseScriptButton = new System.Windows.Forms.Button();
			this.objectScriptBox = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.objectNameBox = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.objectDeleteButton = new System.Windows.Forms.Button();
			this.objectAddButton = new System.Windows.Forms.Button();
			this.objectListBox = new System.Windows.Forms.ListBox();
			this.loadGlobalObjects = new System.Windows.Forms.CheckBox();
			this.layerSettingsGroup = new System.Windows.Forms.GroupBox();
			this.layer3Box = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.layer2Box = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.layer1Box = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.layer0Box = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.midpointBox = new System.Windows.Forms.ComboBox();
			this.label17 = new System.Windows.Forms.Label();
			this.titleCardGroup = new System.Windows.Forms.GroupBox();
			this.levelNameBox = new System.Windows.Forms.TextBox();
			this.levelNameBox2 = new System.Windows.Forms.TextBox();
			this.tileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cutTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deepCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteOverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importOverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportTileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.duplicateTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.layoutContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteOnceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteRepeatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.exportLayoutSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.fillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			this.saveSectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteSectionOnceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteSectionRepeatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.insertLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteLayoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chunkBlockContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.flipChunkBlocksHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flipChunkBlocksVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyChunkBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteChunkBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearChunkBlocksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importProgressControl1 = new SonicRetro.SonLVL.ImportProgressControl();
			toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			label4 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			chunkListToolStrip = new System.Windows.Forms.ToolStrip();
			tileListToolStrip = new System.Windows.Forms.ToolStrip();
			tabControl2 = new System.Windows.Forms.TabControl();
			layoutSectionListToolStrip = new System.Windows.Forms.ToolStrip();
			toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			label1 = new System.Windows.Forms.Label();
			panel11 = new System.Windows.Forms.Panel();
			tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			panel1 = new System.Windows.Forms.Panel();
			panel9 = new System.Windows.Forms.Panel();
			label26 = new System.Windows.Forms.Label();
			label7 = new System.Windows.Forms.Label();
			label6 = new System.Windows.Forms.Label();
			label5 = new System.Windows.Forms.Label();
			tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
			toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
			chunkListToolStrip.SuspendLayout();
			tileListToolStrip.SuspendLayout();
			tabControl2.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabPage9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutSectionSplitContainer)).BeginInit();
			this.layoutSectionSplitContainer.Panel1.SuspendLayout();
			this.layoutSectionSplitContainer.Panel2.SuspendLayout();
			this.layoutSectionSplitContainer.SuspendLayout();
			layoutSectionListToolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutSectionPreview)).BeginInit();
			panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TileID)).BeginInit();
			tableLayoutPanel5.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ChunkID)).BeginInit();
			panel9.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.colFlags)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ceilingAngle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightAngle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leftAngle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.floorAngle)).BeginInit();
			tableLayoutPanel6.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.objectContextMenuStrip.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			this.objToolStrip.SuspendLayout();
			this.tabControl5.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.fgToolStrip.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.bgToolStrip.SuspendLayout();
			this.tabControl3.SuspendLayout();
			this.tabPage13.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scrollFrame)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scrollCamY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scrollCamX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scrollTargetFPS)).BeginInit();
			this.scrollEditPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scrollOffset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scrollScrollSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.scrollParallaxFactor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layerScrollSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layerParallaxFactor)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tabControl4.SuspendLayout();
			this.tabPage12.SuspendLayout();
			this.tabPage14.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tableLayoutPanel8.SuspendLayout();
			this.panel8.SuspendLayout();
			this.colorEditingPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.colorBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colorGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.colorRed)).BeginInit();
			this.paletteToolStrip.SuspendLayout();
			this.tabPage15.SuspendLayout();
			this.soundEffectsGroup.SuspendLayout();
			this.objectListGroup.SuspendLayout();
			this.layerSettingsGroup.SuspendLayout();
			this.titleCardGroup.SuspendLayout();
			this.tileContextMenuStrip.SuspendLayout();
			this.layoutContextMenuStrip.SuspendLayout();
			this.chunkBlockContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripSeparator8
			// 
			toolStripSeparator8.Name = "toolStripSeparator8";
			toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator9
			// 
			toolStripSeparator9.Name = "toolStripSeparator9";
			toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(5, 57);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(31, 13);
			label4.TabIndex = 4;
			label4.Text = "Blue:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(5, 31);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(39, 13);
			label3.TabIndex = 2;
			label3.Text = "Green:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(5, 5);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(30, 13);
			label2.TabIndex = 0;
			label2.Text = "Red:";
			// 
			// toolStripSeparator10
			// 
			toolStripSeparator10.Name = "toolStripSeparator10";
			toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
			// 
			// chunkListToolStrip
			// 
			chunkListToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			chunkListToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importChunksToolStripButton,
            this.drawChunkToolStripButton,
            this.deleteUnusedChunksToolStripButton,
            this.removeDuplicateChunksToolStripButton,
            this.replaceChunkBlocksToolStripButton,
            this.remapChunksButton,
            this.enableDraggingChunksButton});
			chunkListToolStrip.Location = new System.Drawing.Point(3, 3);
			chunkListToolStrip.Name = "chunkListToolStrip";
			chunkListToolStrip.Size = new System.Drawing.Size(729, 25);
			chunkListToolStrip.TabIndex = 0;
			chunkListToolStrip.Text = "toolStrip1";
			// 
			// importChunksToolStripButton
			// 
			this.importChunksToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.importChunksToolStripButton.Enabled = false;
			this.importChunksToolStripButton.Name = "importChunksToolStripButton";
			this.importChunksToolStripButton.Size = new System.Drawing.Size(56, 22);
			this.importChunksToolStripButton.Text = "Import...";
			this.importChunksToolStripButton.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
			// 
			// drawChunkToolStripButton
			// 
			this.drawChunkToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.drawChunkToolStripButton.Enabled = false;
			this.drawChunkToolStripButton.Name = "drawChunkToolStripButton";
			this.drawChunkToolStripButton.Size = new System.Drawing.Size(47, 22);
			this.drawChunkToolStripButton.Text = "Draw...";
			this.drawChunkToolStripButton.Click += new System.EventHandler(this.drawToolStripButton_Click);
			// 
			// deleteUnusedChunksToolStripButton
			// 
			this.deleteUnusedChunksToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.deleteUnusedChunksToolStripButton.Enabled = false;
			this.deleteUnusedChunksToolStripButton.Name = "deleteUnusedChunksToolStripButton";
			this.deleteUnusedChunksToolStripButton.Size = new System.Drawing.Size(87, 22);
			this.deleteUnusedChunksToolStripButton.Text = "Delete Unused";
			this.deleteUnusedChunksToolStripButton.Click += new System.EventHandler(this.deleteUnusedChunksToolStripButton_Click);
			// 
			// removeDuplicateChunksToolStripButton
			// 
			this.removeDuplicateChunksToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.removeDuplicateChunksToolStripButton.Enabled = false;
			this.removeDuplicateChunksToolStripButton.Name = "removeDuplicateChunksToolStripButton";
			this.removeDuplicateChunksToolStripButton.Size = new System.Drawing.Size(112, 22);
			this.removeDuplicateChunksToolStripButton.Text = "Remove Duplicates";
			this.removeDuplicateChunksToolStripButton.Click += new System.EventHandler(this.removeDuplicateChunksToolStripButton_Click);
			// 
			// replaceChunkBlocksToolStripButton
			// 
			this.replaceChunkBlocksToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.replaceChunkBlocksToolStripButton.Enabled = false;
			this.replaceChunkBlocksToolStripButton.Name = "replaceChunkBlocksToolStripButton";
			this.replaceChunkBlocksToolStripButton.Size = new System.Drawing.Size(52, 22);
			this.replaceChunkBlocksToolStripButton.Text = "Replace";
			this.replaceChunkBlocksToolStripButton.Click += new System.EventHandler(this.replaceChunkBlocksToolStripButton_Click);
			// 
			// remapChunksButton
			// 
			this.remapChunksButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.remapChunksButton.Enabled = false;
			this.remapChunksButton.Image = ((System.Drawing.Image)(resources.GetObject("remapChunksButton.Image")));
			this.remapChunksButton.Name = "remapChunksButton";
			this.remapChunksButton.Size = new System.Drawing.Size(137, 22);
			this.remapChunksButton.Text = "Advanced Remapping...";
			this.remapChunksButton.Click += new System.EventHandler(this.remapChunksButton_Click);
			// 
			// enableDraggingChunksButton
			// 
			this.enableDraggingChunksButton.Checked = true;
			this.enableDraggingChunksButton.CheckOnClick = true;
			this.enableDraggingChunksButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enableDraggingChunksButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.enableDraggingChunksButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.enableDraggingChunksButton.Name = "enableDraggingChunksButton";
			this.enableDraggingChunksButton.Size = new System.Drawing.Size(98, 22);
			this.enableDraggingChunksButton.Text = "Enable Dragging";
			// 
			// tileListToolStrip
			// 
			tileListToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			tileListToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importTilesToolStripButton,
            this.drawTileToolStripButton,
            this.deleteUnusedTilesToolStripButton,
            this.removeDuplicateTilesToolStripButton,
            this.remapTilesButton,
            this.enableDraggingTilesButton});
			tileListToolStrip.Location = new System.Drawing.Point(3, 3);
			tileListToolStrip.Name = "tileListToolStrip";
			tileListToolStrip.Size = new System.Drawing.Size(729, 25);
			tileListToolStrip.TabIndex = 2;
			tileListToolStrip.Text = "toolStrip3";
			// 
			// importTilesToolStripButton
			// 
			this.importTilesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.importTilesToolStripButton.Enabled = false;
			this.importTilesToolStripButton.Name = "importTilesToolStripButton";
			this.importTilesToolStripButton.Size = new System.Drawing.Size(56, 22);
			this.importTilesToolStripButton.Text = "Import...";
			this.importTilesToolStripButton.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
			// 
			// drawTileToolStripButton
			// 
			this.drawTileToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.drawTileToolStripButton.Enabled = false;
			this.drawTileToolStripButton.Name = "drawTileToolStripButton";
			this.drawTileToolStripButton.Size = new System.Drawing.Size(47, 22);
			this.drawTileToolStripButton.Text = "Draw...";
			this.drawTileToolStripButton.Click += new System.EventHandler(this.drawToolStripButton_Click);
			// 
			// deleteUnusedTilesToolStripButton
			// 
			this.deleteUnusedTilesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.deleteUnusedTilesToolStripButton.Enabled = false;
			this.deleteUnusedTilesToolStripButton.Name = "deleteUnusedTilesToolStripButton";
			this.deleteUnusedTilesToolStripButton.Size = new System.Drawing.Size(87, 22);
			this.deleteUnusedTilesToolStripButton.Text = "Delete Unused";
			this.deleteUnusedTilesToolStripButton.Click += new System.EventHandler(this.deleteUnusedTilesToolStripButton_Click);
			// 
			// removeDuplicateTilesToolStripButton
			// 
			this.removeDuplicateTilesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.removeDuplicateTilesToolStripButton.Enabled = false;
			this.removeDuplicateTilesToolStripButton.Name = "removeDuplicateTilesToolStripButton";
			this.removeDuplicateTilesToolStripButton.Size = new System.Drawing.Size(112, 22);
			this.removeDuplicateTilesToolStripButton.Text = "Remove Duplicates";
			this.removeDuplicateTilesToolStripButton.Click += new System.EventHandler(this.removeDuplicateTilesToolStripButton_Click);
			// 
			// remapTilesButton
			// 
			this.remapTilesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.remapTilesButton.Enabled = false;
			this.remapTilesButton.Image = ((System.Drawing.Image)(resources.GetObject("remapTilesButton.Image")));
			this.remapTilesButton.Name = "remapTilesButton";
			this.remapTilesButton.Size = new System.Drawing.Size(137, 22);
			this.remapTilesButton.Text = "Advanced Remapping...";
			this.remapTilesButton.Click += new System.EventHandler(this.remapTilesButton_Click);
			// 
			// enableDraggingTilesButton
			// 
			this.enableDraggingTilesButton.Checked = true;
			this.enableDraggingTilesButton.CheckOnClick = true;
			this.enableDraggingTilesButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enableDraggingTilesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.enableDraggingTilesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.enableDraggingTilesButton.Name = "enableDraggingTilesButton";
			this.enableDraggingTilesButton.Size = new System.Drawing.Size(98, 22);
			this.enableDraggingTilesButton.Text = "Enable Dragging";
			// 
			// tabControl2
			// 
			tabControl2.Controls.Add(this.tabPage8);
			tabControl2.Controls.Add(this.tabPage9);
			tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			tabControl2.Location = new System.Drawing.Point(0, 0);
			tabControl2.Name = "tabControl2";
			tabControl2.SelectedIndex = 0;
			tabControl2.Size = new System.Drawing.Size(286, 477);
			tabControl2.TabIndex = 2;
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.ChunkSelector);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Size = new System.Drawing.Size(278, 451);
			this.tabPage8.TabIndex = 0;
			this.tabPage8.Text = "Chunks";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// ChunkSelector
			// 
			this.ChunkSelector.BackColor = System.Drawing.SystemColors.Window;
			this.ChunkSelector.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChunkSelector.ImageHeight = 128;
			this.ChunkSelector.ImageSize = 128;
			this.ChunkSelector.ImageWidth = 128;
			this.ChunkSelector.Location = new System.Drawing.Point(0, 0);
			this.ChunkSelector.Margin = new System.Windows.Forms.Padding(0);
			this.ChunkSelector.Name = "ChunkSelector";
			this.ChunkSelector.ScrollValue = 0;
			this.ChunkSelector.SelectedIndex = -1;
			this.ChunkSelector.Size = new System.Drawing.Size(278, 451);
			this.ChunkSelector.TabIndex = 1;
			this.ChunkSelector.SelectedIndexChanged += new System.EventHandler(this.ChunkSelector_SelectedIndexChanged);
			this.ChunkSelector.ItemDrag += new System.EventHandler(this.ChunkSelector_ItemDrag);
			this.ChunkSelector.DragDrop += new System.Windows.Forms.DragEventHandler(this.ChunkSelector_DragDrop);
			this.ChunkSelector.DragEnter += new System.Windows.Forms.DragEventHandler(this.ChunkSelector_DragEnter);
			this.ChunkSelector.DragOver += new System.Windows.Forms.DragEventHandler(this.ChunkSelector_DragOver);
			this.ChunkSelector.DragLeave += new System.EventHandler(this.ChunkSelector_DragLeave);
			this.ChunkSelector.Paint += new System.Windows.Forms.PaintEventHandler(this.ChunkSelector_Paint);
			this.ChunkSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TileList_KeyDown);
			this.ChunkSelector.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChunkSelector_MouseDown);
			// 
			// tabPage9
			// 
			this.tabPage9.Controls.Add(this.layoutSectionSplitContainer);
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Size = new System.Drawing.Size(278, 451);
			this.tabPage9.TabIndex = 1;
			this.tabPage9.Text = "Layout Sections";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// layoutSectionSplitContainer
			// 
			this.layoutSectionSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutSectionSplitContainer.Location = new System.Drawing.Point(0, 0);
			this.layoutSectionSplitContainer.Margin = new System.Windows.Forms.Padding(0);
			this.layoutSectionSplitContainer.Name = "layoutSectionSplitContainer";
			this.layoutSectionSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// layoutSectionSplitContainer.Panel1
			// 
			this.layoutSectionSplitContainer.Panel1.Controls.Add(this.layoutSectionListBox);
			this.layoutSectionSplitContainer.Panel1.Controls.Add(layoutSectionListToolStrip);
			// 
			// layoutSectionSplitContainer.Panel2
			// 
			this.layoutSectionSplitContainer.Panel2.Controls.Add(this.layoutSectionPreview);
			this.layoutSectionSplitContainer.Size = new System.Drawing.Size(278, 451);
			this.layoutSectionSplitContainer.SplitterDistance = 203;
			this.layoutSectionSplitContainer.TabIndex = 0;
			// 
			// layoutSectionListBox
			// 
			this.layoutSectionListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutSectionListBox.FormattingEnabled = true;
			this.layoutSectionListBox.IntegralHeight = false;
			this.layoutSectionListBox.Location = new System.Drawing.Point(0, 25);
			this.layoutSectionListBox.Name = "layoutSectionListBox";
			this.layoutSectionListBox.Size = new System.Drawing.Size(278, 178);
			this.layoutSectionListBox.TabIndex = 0;
			this.layoutSectionListBox.SelectedIndexChanged += new System.EventHandler(this.layoutSectionListBox_SelectedIndexChanged);
			this.layoutSectionListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.layoutSectionListBox_KeyDown);
			// 
			// layoutSectionListToolStrip
			// 
			layoutSectionListToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			layoutSectionListToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripButton});
			layoutSectionListToolStrip.Location = new System.Drawing.Point(0, 0);
			layoutSectionListToolStrip.Name = "layoutSectionListToolStrip";
			layoutSectionListToolStrip.Size = new System.Drawing.Size(278, 25);
			layoutSectionListToolStrip.TabIndex = 1;
			layoutSectionListToolStrip.Text = "toolStrip1";
			// 
			// importToolStripButton
			// 
			this.importToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.importToolStripButton.Name = "importToolStripButton";
			this.importToolStripButton.Size = new System.Drawing.Size(56, 22);
			this.importToolStripButton.Text = "I&mport...";
			this.importToolStripButton.Click += new System.EventHandler(this.importToolStripButton_Click);
			// 
			// layoutSectionPreview
			// 
			this.layoutSectionPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutSectionPreview.Location = new System.Drawing.Point(0, 0);
			this.layoutSectionPreview.Margin = new System.Windows.Forms.Padding(0);
			this.layoutSectionPreview.Name = "layoutSectionPreview";
			this.layoutSectionPreview.Size = new System.Drawing.Size(278, 244);
			this.layoutSectionPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.layoutSectionPreview.TabIndex = 0;
			this.layoutSectionPreview.TabStop = false;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new System.Drawing.Size(220, 6);
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(3, 197);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(33, 13);
			label1.TabIndex = 6;
			label1.Text = "Floor:";
			// 
			// panel11
			// 
			panel11.AutoSize = true;
			panel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			panel11.Controls.Add(this.flipTileHButton);
			panel11.Controls.Add(this.flipTileVButton);
			panel11.Controls.Add(this.TileID);
			panel11.Controls.Add(this.rotateTileRightButton);
			panel11.Controls.Add(this.TileCount);
			panel11.Location = new System.Drawing.Point(0, 134);
			panel11.Margin = new System.Windows.Forms.Padding(0);
			panel11.Name = "panel11";
			panel11.Size = new System.Drawing.Size(180, 84);
			panel11.TabIndex = 11;
			// 
			// flipTileHButton
			// 
			this.flipTileHButton.AutoSize = true;
			this.flipTileHButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flipTileHButton.Enabled = false;
			this.flipTileHButton.Location = new System.Drawing.Point(3, 3);
			this.flipTileHButton.Name = "flipTileHButton";
			this.flipTileHButton.Size = new System.Drawing.Size(90, 23);
			this.flipTileHButton.TabIndex = 9;
			this.flipTileHButton.Text = "Flip Horizontally";
			this.flipTileHButton.UseVisualStyleBackColor = true;
			this.flipTileHButton.Click += new System.EventHandler(this.flipTileHButton_Click);
			// 
			// flipTileVButton
			// 
			this.flipTileVButton.AutoSize = true;
			this.flipTileVButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flipTileVButton.Enabled = false;
			this.flipTileVButton.Location = new System.Drawing.Point(99, 3);
			this.flipTileVButton.Name = "flipTileVButton";
			this.flipTileVButton.Size = new System.Drawing.Size(78, 23);
			this.flipTileVButton.TabIndex = 10;
			this.flipTileVButton.Text = "Flip Vertically";
			this.flipTileVButton.UseVisualStyleBackColor = true;
			this.flipTileVButton.Click += new System.EventHandler(this.flipTileVButton_Click);
			// 
			// TileID
			// 
			this.TileID.Hexadecimal = false;
			this.TileID.Location = new System.Drawing.Point(3, 61);
			this.TileID.Maximum = new decimal(new int[] {
            1023,
            0,
            0,
            0});
			this.TileID.Name = "TileID";
			this.TileID.Size = new System.Drawing.Size(100, 20);
			this.TileID.TabIndex = 3;
			this.TileID.ValueChanged += new System.EventHandler(this.TileID_ValueChanged);
			// 
			// rotateTileRightButton
			// 
			this.rotateTileRightButton.AutoSize = true;
			this.rotateTileRightButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.rotateTileRightButton.Enabled = false;
			this.rotateTileRightButton.Location = new System.Drawing.Point(3, 32);
			this.rotateTileRightButton.Name = "rotateTileRightButton";
			this.rotateTileRightButton.Size = new System.Drawing.Size(77, 23);
			this.rotateTileRightButton.TabIndex = 5;
			this.rotateTileRightButton.Text = "Rotate Right";
			this.rotateTileRightButton.UseVisualStyleBackColor = true;
			this.rotateTileRightButton.Click += new System.EventHandler(this.rotateTileRightButton_Click);
			// 
			// TileCount
			// 
			this.TileCount.AutoSize = true;
			this.TileCount.Location = new System.Drawing.Point(109, 64);
			this.TileCount.Name = "TileCount";
			this.TileCount.Size = new System.Drawing.Size(42, 13);
			this.TileCount.TabIndex = 4;
			this.TileCount.Text = "1023";
			// 
			// tableLayoutPanel5
			// 
			tableLayoutPanel5.AutoSize = true;
			tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			tableLayoutPanel5.ColumnCount = 1;
			tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			tableLayoutPanel5.Controls.Add(panel1, 0, 1);
			tableLayoutPanel5.Controls.Add(this.ChunkPicture, 0, 0);
			tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
			tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
			tableLayoutPanel5.Name = "tableLayoutPanel5";
			tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel4.SetRowSpan(tableLayoutPanel5, 2);
			tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayoutPanel5.Size = new System.Drawing.Size(180, 382);
			tableLayoutPanel5.TabIndex = 9;
			// 
			// panel1
			// 
			panel1.AutoSize = true;
			panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			panel1.Controls.Add(this.flipChunkVButton);
			panel1.Controls.Add(this.chunkBlockEditor);
			panel1.Controls.Add(this.flipChunkHButton);
			panel1.Controls.Add(this.ChunkCount);
			panel1.Controls.Add(this.chunkCtrlLabel);
			panel1.Controls.Add(this.ChunkID);
			panel1.Location = new System.Drawing.Point(0, 134);
			panel1.Margin = new System.Windows.Forms.Padding(0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(180, 248);
			panel1.TabIndex = 2;
			// 
			// flipChunkVButton
			// 
			this.flipChunkVButton.AutoSize = true;
			this.flipChunkVButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flipChunkVButton.Enabled = false;
			this.flipChunkVButton.Location = new System.Drawing.Point(99, 3);
			this.flipChunkVButton.Name = "flipChunkVButton";
			this.flipChunkVButton.Size = new System.Drawing.Size(78, 23);
			this.flipChunkVButton.TabIndex = 6;
			this.flipChunkVButton.Text = "Flip Vertically";
			this.flipChunkVButton.UseVisualStyleBackColor = true;
			this.flipChunkVButton.Click += new System.EventHandler(this.flipChunkVButton_Click);
			// 
			// chunkBlockEditor
			// 
			this.chunkBlockEditor.AutoSize = true;
			this.chunkBlockEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.chunkBlockEditor.Location = new System.Drawing.Point(3, 84);
			this.chunkBlockEditor.Name = "chunkBlockEditor";
			this.chunkBlockEditor.SelectedObjects = null;
			this.chunkBlockEditor.Size = new System.Drawing.Size(139, 161);
			this.chunkBlockEditor.TabIndex = 3;
			this.chunkBlockEditor.PropertyValueChanged += new System.EventHandler(this.chunkBlockEditor_PropertyValueChanged);
			// 
			// flipChunkHButton
			// 
			this.flipChunkHButton.AutoSize = true;
			this.flipChunkHButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flipChunkHButton.Enabled = false;
			this.flipChunkHButton.Location = new System.Drawing.Point(3, 3);
			this.flipChunkHButton.Name = "flipChunkHButton";
			this.flipChunkHButton.Size = new System.Drawing.Size(90, 23);
			this.flipChunkHButton.TabIndex = 5;
			this.flipChunkHButton.Text = "Flip Horizontally";
			this.flipChunkHButton.UseVisualStyleBackColor = true;
			this.flipChunkHButton.Click += new System.EventHandler(this.flipChunkHButton_Click);
			// 
			// ChunkCount
			// 
			this.ChunkCount.AutoSize = true;
			this.ChunkCount.Location = new System.Drawing.Point(109, 35);
			this.ChunkCount.Name = "ChunkCount";
			this.ChunkCount.Size = new System.Drawing.Size(42, 13);
			this.ChunkCount.TabIndex = 3;
			this.ChunkCount.Text = "0 / 511";
			// 
			// chunkCtrlLabel
			// 
			this.chunkCtrlLabel.AutoSize = true;
			this.chunkCtrlLabel.Location = new System.Drawing.Point(3, 55);
			this.chunkCtrlLabel.Name = "chunkCtrlLabel";
			this.chunkCtrlLabel.Size = new System.Drawing.Size(147, 26);
			this.chunkCtrlLabel.TabIndex = 4;
			this.chunkCtrlLabel.Text = "LMB: Paint w/ selected block\r\nRMB: Select block";
			this.chunkCtrlLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// ChunkID
			// 
			this.ChunkID.Hexadecimal = false;
			this.ChunkID.Location = new System.Drawing.Point(8, 32);
			this.ChunkID.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.ChunkID.Name = "ChunkID";
			this.ChunkID.Size = new System.Drawing.Size(94, 20);
			this.ChunkID.TabIndex = 2;
			this.ChunkID.ValueChanged += new System.EventHandler(this.ChunkID_ValueChanged);
			// 
			// ChunkPicture
			// 
			this.ChunkPicture.Location = new System.Drawing.Point(3, 3);
			this.ChunkPicture.Name = "ChunkPicture";
			this.ChunkPicture.Size = new System.Drawing.Size(128, 128);
			this.ChunkPicture.TabIndex = 1;
			this.ChunkPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.ChunkPicture_Paint);
			this.ChunkPicture.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChunkPicture_KeyDown);
			this.ChunkPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChunkPicture_MouseDown);
			this.ChunkPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChunkPicture_MouseMove);
			this.ChunkPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChunkPicture_MouseUp);
			// 
			// panel9
			// 
			panel9.AutoSize = true;
			panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			panel9.Controls.Add(label26);
			panel9.Controls.Add(this.colFlags);
			panel9.Controls.Add(label7);
			panel9.Controls.Add(this.ceilingAngle);
			panel9.Controls.Add(label6);
			panel9.Controls.Add(this.rightAngle);
			panel9.Controls.Add(label5);
			panel9.Controls.Add(this.leftAngle);
			panel9.Controls.Add(this.collisionCeiling);
			panel9.Controls.Add(this.collisionLayerSelector);
			panel9.Controls.Add(this.calculateAngleButton);
			panel9.Controls.Add(label1);
			panel9.Controls.Add(this.showBlockBehindCollisionCheckBox);
			panel9.Controls.Add(this.floorAngle);
			panel9.Controls.Add(this.ColPicture);
			panel9.Location = new System.Drawing.Point(180, 218);
			panel9.Margin = new System.Windows.Forms.Padding(0);
			panel9.Name = "panel9";
			panel9.Size = new System.Drawing.Size(128, 374);
			panel9.TabIndex = 1;
			// 
			// label26
			// 
			label26.AutoSize = true;
			label26.Location = new System.Drawing.Point(3, 330);
			label26.Name = "label26";
			label26.Size = new System.Drawing.Size(35, 13);
			label26.TabIndex = 17;
			label26.Text = "Flags:";
			// 
			// colFlags
			// 
			this.colFlags.Hexadecimal = true;
			this.colFlags.Location = new System.Drawing.Point(50, 328);
			this.colFlags.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.colFlags.Name = "colFlags";
			this.colFlags.Size = new System.Drawing.Size(41, 20);
			this.colFlags.TabIndex = 16;
			this.colFlags.ValueChanged += new System.EventHandler(this.colFlags_ValueChanged);
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(3, 275);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(41, 13);
			label7.TabIndex = 15;
			label7.Text = "Ceiling:";
			// 
			// ceilingAngle
			// 
			this.ceilingAngle.Hexadecimal = true;
			this.ceilingAngle.Location = new System.Drawing.Point(50, 273);
			this.ceilingAngle.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.ceilingAngle.Name = "ceilingAngle";
			this.ceilingAngle.Size = new System.Drawing.Size(41, 20);
			this.ceilingAngle.TabIndex = 14;
			this.ceilingAngle.ValueChanged += new System.EventHandler(this.ceilingAngle_ValueChanged);
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(3, 249);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(35, 13);
			label6.TabIndex = 13;
			label6.Text = "Right:";
			// 
			// rightAngle
			// 
			this.rightAngle.Hexadecimal = true;
			this.rightAngle.Location = new System.Drawing.Point(50, 247);
			this.rightAngle.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.rightAngle.Name = "rightAngle";
			this.rightAngle.Size = new System.Drawing.Size(41, 20);
			this.rightAngle.TabIndex = 12;
			this.rightAngle.ValueChanged += new System.EventHandler(this.rightAngle_ValueChanged);
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(3, 223);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(28, 13);
			label5.TabIndex = 11;
			label5.Text = "Left:";
			// 
			// leftAngle
			// 
			this.leftAngle.Hexadecimal = true;
			this.leftAngle.Location = new System.Drawing.Point(50, 221);
			this.leftAngle.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.leftAngle.Name = "leftAngle";
			this.leftAngle.Size = new System.Drawing.Size(41, 20);
			this.leftAngle.TabIndex = 10;
			this.leftAngle.ValueChanged += new System.EventHandler(this.leftAngle_ValueChanged);
			// 
			// collisionCeiling
			// 
			this.collisionCeiling.AutoSize = true;
			this.collisionCeiling.Location = new System.Drawing.Point(3, 172);
			this.collisionCeiling.Name = "collisionCeiling";
			this.collisionCeiling.Size = new System.Drawing.Size(57, 17);
			this.collisionCeiling.TabIndex = 9;
			this.collisionCeiling.Text = "Ceiling";
			this.collisionCeiling.UseVisualStyleBackColor = true;
			this.collisionCeiling.CheckedChanged += new System.EventHandler(this.collisionCeiling_CheckedChanged);
			// 
			// collisionLayerSelector
			// 
			this.collisionLayerSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.collisionLayerSelector.FormattingEnabled = true;
			this.collisionLayerSelector.Items.AddRange(new object[] {
            "Layer 1",
            "Layer 2"});
			this.collisionLayerSelector.Location = new System.Drawing.Point(3, 3);
			this.collisionLayerSelector.Name = "collisionLayerSelector";
			this.collisionLayerSelector.Size = new System.Drawing.Size(122, 21);
			this.collisionLayerSelector.TabIndex = 8;
			this.collisionLayerSelector.SelectedIndexChanged += new System.EventHandler(this.collisionLayerSelector_SelectedIndexChanged);
			// 
			// calculateAngleButton
			// 
			this.calculateAngleButton.AutoSize = true;
			this.calculateAngleButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.calculateAngleButton.Location = new System.Drawing.Point(3, 299);
			this.calculateAngleButton.Name = "calculateAngleButton";
			this.calculateAngleButton.Size = new System.Drawing.Size(96, 23);
			this.calculateAngleButton.TabIndex = 7;
			this.calculateAngleButton.Text = "Calculate Angles";
			this.calculateAngleButton.UseVisualStyleBackColor = true;
			this.calculateAngleButton.Click += new System.EventHandler(this.calculateAngleButton_Click);
			// 
			// showBlockBehindCollisionCheckBox
			// 
			this.showBlockBehindCollisionCheckBox.AutoSize = true;
			this.showBlockBehindCollisionCheckBox.Location = new System.Drawing.Point(3, 354);
			this.showBlockBehindCollisionCheckBox.Name = "showBlockBehindCollisionCheckBox";
			this.showBlockBehindCollisionCheckBox.Size = new System.Drawing.Size(73, 17);
			this.showBlockBehindCollisionCheckBox.TabIndex = 5;
			this.showBlockBehindCollisionCheckBox.Text = "Show Tile";
			this.showBlockBehindCollisionCheckBox.UseVisualStyleBackColor = true;
			this.showBlockBehindCollisionCheckBox.CheckedChanged += new System.EventHandler(this.showBlockBehindCollisionCheckBox_CheckedChanged);
			// 
			// floorAngle
			// 
			this.floorAngle.Hexadecimal = true;
			this.floorAngle.Location = new System.Drawing.Point(50, 195);
			this.floorAngle.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.floorAngle.Name = "floorAngle";
			this.floorAngle.Size = new System.Drawing.Size(41, 20);
			this.floorAngle.TabIndex = 3;
			this.floorAngle.ValueChanged += new System.EventHandler(this.floorAngle_ValueChanged);
			// 
			// ColPicture
			// 
			this.ColPicture.BackColor = System.Drawing.Color.Black;
			this.ColPicture.Location = new System.Drawing.Point(0, 30);
			this.ColPicture.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
			this.ColPicture.Name = "ColPicture";
			this.ColPicture.Size = new System.Drawing.Size(128, 136);
			this.ColPicture.TabIndex = 2;
			this.ColPicture.Paint += new System.Windows.Forms.PaintEventHandler(this.ColPicture_Paint);
			this.ColPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ColPicture_MouseDown);
			this.ColPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColPicture_MouseMove);
			this.ColPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ColPicture_MouseUp);
			// 
			// tableLayoutPanel6
			// 
			tableLayoutPanel6.AutoSize = true;
			tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			tableLayoutPanel6.ColumnCount = 1;
			tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			tableLayoutPanel6.Controls.Add(this.TilePicture, 0, 0);
			tableLayoutPanel6.Controls.Add(panel11, 0, 1);
			tableLayoutPanel6.Location = new System.Drawing.Point(180, 0);
			tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
			tableLayoutPanel6.Name = "tableLayoutPanel6";
			tableLayoutPanel6.RowCount = 2;
			tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
			tableLayoutPanel6.Size = new System.Drawing.Size(180, 218);
			tableLayoutPanel6.TabIndex = 9;
			// 
			// TilePicture
			// 
			this.TilePicture.Location = new System.Drawing.Point(3, 3);
			this.TilePicture.Name = "TilePicture";
			this.TilePicture.Size = new System.Drawing.Size(128, 128);
			this.TilePicture.TabIndex = 1;
			this.TilePicture.Paint += new System.Windows.Forms.PaintEventHandler(this.TilePicture_Paint);
			this.TilePicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TilePicture_MouseDown);
			this.TilePicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TilePicture_MouseMove);
			this.TilePicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TilePicture_MouseUp);
			// 
			// toolStripMenuItem13
			// 
			toolStripMenuItem13.Checked = true;
			toolStripMenuItem13.CheckState = System.Windows.Forms.CheckState.Checked;
			toolStripMenuItem13.Name = "toolStripMenuItem13";
			toolStripMenuItem13.Size = new System.Drawing.Size(80, 22);
			toolStripMenuItem13.Text = "1";
			// 
			// toolStripMenuItem14
			// 
			toolStripMenuItem14.Name = "toolStripMenuItem14";
			toolStripMenuItem14.Size = new System.Drawing.Size(80, 22);
			toolStripMenuItem14.Text = "2";
			// 
			// toolStripMenuItem15
			// 
			toolStripMenuItem15.Name = "toolStripMenuItem15";
			toolStripMenuItem15.Size = new System.Drawing.Size(80, 22);
			toolStripMenuItem15.Text = "3";
			// 
			// toolStripMenuItem16
			// 
			toolStripMenuItem16.Name = "toolStripMenuItem16";
			toolStripMenuItem16.Size = new System.Drawing.Size(80, 22);
			toolStripMenuItem16.Text = "4";
			// 
			// toolStripMenuItem17
			// 
			toolStripMenuItem17.Name = "toolStripMenuItem17";
			toolStripMenuItem17.Size = new System.Drawing.Size(80, 22);
			toolStripMenuItem17.Text = "5";
			// 
			// toolStripMenuItem18
			// 
			toolStripMenuItem18.Name = "toolStripMenuItem18";
			toolStripMenuItem18.Size = new System.Drawing.Size(80, 22);
			toolStripMenuItem18.Text = "6";
			// 
			// toolStripMenuItem19
			// 
			toolStripMenuItem19.Name = "toolStripMenuItem19";
			toolStripMenuItem19.Size = new System.Drawing.Size(80, 22);
			toolStripMenuItem19.Text = "7";
			// 
			// toolStripMenuItem20
			// 
			toolStripMenuItem20.Name = "toolStripMenuItem20";
			toolStripMenuItem20.Size = new System.Drawing.Size(80, 22);
			toolStripMenuItem20.Text = "8";
			// 
			// panel10
			// 
			this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel10.Location = new System.Drawing.Point(3, 28);
			this.panel10.Margin = new System.Windows.Forms.Padding(0);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(729, 537);
			this.panel10.TabIndex = 4;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.selectModToolStripMenuItem,
            this.editGameConfigToolStripMenuItem,
            this.changeLevelToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.buildAndRunToolStripMenuItem,
            this.recentProjectsToolStripMenuItem,
            this.recentModsToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.openToolStripMenuItem.Text = "&Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// selectModToolStripMenuItem
			// 
			this.selectModToolStripMenuItem.Name = "selectModToolStripMenuItem";
			this.selectModToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.selectModToolStripMenuItem.Text = "Select &Mod";
			// 
			// editGameConfigToolStripMenuItem
			// 
			this.editGameConfigToolStripMenuItem.Enabled = false;
			this.editGameConfigToolStripMenuItem.Name = "editGameConfigToolStripMenuItem";
			this.editGameConfigToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.editGameConfigToolStripMenuItem.Text = "Edit &GameConfig...";
			this.editGameConfigToolStripMenuItem.Click += new System.EventHandler(this.editGameConfigToolStripMenuItem_Click);
			// 
			// changeLevelToolStripMenuItem
			// 
			this.changeLevelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.presentationStagesToolStripMenuItem,
            this.regularStagesToolStripMenuItem,
            this.specialStagesToolStripMenuItem,
            this.bonusStagesToolStripMenuItem});
			this.changeLevelToolStripMenuItem.Name = "changeLevelToolStripMenuItem";
			this.changeLevelToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.changeLevelToolStripMenuItem.Text = "&Change Level...";
			// 
			// presentationStagesToolStripMenuItem
			// 
			this.presentationStagesToolStripMenuItem.Name = "presentationStagesToolStripMenuItem";
			this.presentationStagesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.presentationStagesToolStripMenuItem.Text = "Presentation Stages";
			// 
			// regularStagesToolStripMenuItem
			// 
			this.regularStagesToolStripMenuItem.Name = "regularStagesToolStripMenuItem";
			this.regularStagesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.regularStagesToolStripMenuItem.Text = "Regular Stages";
			// 
			// specialStagesToolStripMenuItem
			// 
			this.specialStagesToolStripMenuItem.Name = "specialStagesToolStripMenuItem";
			this.specialStagesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.specialStagesToolStripMenuItem.Text = "Special Stages";
			// 
			// bonusStagesToolStripMenuItem
			// 
			this.bonusStagesToolStripMenuItem.Name = "bonusStagesToolStripMenuItem";
			this.bonusStagesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.bonusStagesToolStripMenuItem.Text = "Bonus Stages";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Enabled = false;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// buildAndRunToolStripMenuItem
			// 
			this.buildAndRunToolStripMenuItem.Enabled = false;
			this.buildAndRunToolStripMenuItem.Name = "buildAndRunToolStripMenuItem";
			this.buildAndRunToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.buildAndRunToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.buildAndRunToolStripMenuItem.Text = "&Play...";
			this.buildAndRunToolStripMenuItem.Click += new System.EventHandler(this.buildAndRunToolStripMenuItem_Click);
			// 
			// recentProjectsToolStripMenuItem
			// 
			this.recentProjectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem2});
			this.recentProjectsToolStripMenuItem.Name = "recentProjectsToolStripMenuItem";
			this.recentProjectsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.recentProjectsToolStripMenuItem.Text = "&Recent Games";
			this.recentProjectsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.recentProjectsToolStripMenuItem_DropDownItemClicked);
			// 
			// noneToolStripMenuItem2
			// 
			this.noneToolStripMenuItem2.Enabled = false;
			this.noneToolStripMenuItem2.Name = "noneToolStripMenuItem2";
			this.noneToolStripMenuItem2.Size = new System.Drawing.Size(109, 22);
			this.noneToolStripMenuItem2.Text = "(none)";
			// 
			// recentModsToolStripMenuItem
			// 
			this.recentModsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem});
			this.recentModsToolStripMenuItem.Name = "recentModsToolStripMenuItem";
			this.recentModsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.recentModsToolStripMenuItem.Text = "Recent Mo&ds";
			this.recentModsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.recentModsToolStripMenuItem_DropDownItemClicked);
			// 
			// noneToolStripMenuItem
			// 
			this.noneToolStripMenuItem.Enabled = false;
			this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
			this.noneToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
			this.noneToolStripMenuItem.Text = "(none)";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(658, 24);
			this.mainMenuStrip.TabIndex = 0;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.findPreviousToolStripMenuItem,
            this.toolStripSeparator3,
            this.resizeLevelToolStripMenuItem,
            this.clearLevelToolStripMenuItem,
            this.toolStripSeparator14,
            this.includeObjectsWithForegroundSelectionToolStripMenuItem,
            this.switchMouseButtonsInChunkAndBlockEditorsToolStripMenuItem});
			this.editToolStripMenuItem.Enabled = false;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.findToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
			this.findToolStripMenuItem.Text = "&Find...";
			this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
			// 
			// findNextToolStripMenuItem
			// 
			this.findNextToolStripMenuItem.Enabled = false;
			this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
			this.findNextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
			this.findNextToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
			this.findNextToolStripMenuItem.Text = "Find &Next";
			this.findNextToolStripMenuItem.Click += new System.EventHandler(this.findNextToolStripMenuItem_Click);
			// 
			// findPreviousToolStripMenuItem
			// 
			this.findPreviousToolStripMenuItem.Enabled = false;
			this.findPreviousToolStripMenuItem.Name = "findPreviousToolStripMenuItem";
			this.findPreviousToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
			this.findPreviousToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
			this.findPreviousToolStripMenuItem.Text = "Find &Previous";
			this.findPreviousToolStripMenuItem.Click += new System.EventHandler(this.findPreviousToolStripMenuItem_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(290, 6);
			// 
			// resizeLevelToolStripMenuItem
			// 
			this.resizeLevelToolStripMenuItem.Name = "resizeLevelToolStripMenuItem";
			this.resizeLevelToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
			this.resizeLevelToolStripMenuItem.Text = "Re&size Level...";
			this.resizeLevelToolStripMenuItem.Click += new System.EventHandler(this.resizeLevelToolStripMenuItem_Click);
			// 
			// clearLevelToolStripMenuItem
			// 
			this.clearLevelToolStripMenuItem.Name = "clearLevelToolStripMenuItem";
			this.clearLevelToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
			this.clearLevelToolStripMenuItem.Text = "&Clear Level";
			this.clearLevelToolStripMenuItem.Click += new System.EventHandler(this.clearLevelToolStripMenuItem_Click);
			// 
			// toolStripSeparator14
			// 
			this.toolStripSeparator14.Name = "toolStripSeparator14";
			this.toolStripSeparator14.Size = new System.Drawing.Size(290, 6);
			// 
			// includeObjectsWithForegroundSelectionToolStripMenuItem
			// 
			this.includeObjectsWithForegroundSelectionToolStripMenuItem.CheckOnClick = true;
			this.includeObjectsWithForegroundSelectionToolStripMenuItem.Name = "includeObjectsWithForegroundSelectionToolStripMenuItem";
			this.includeObjectsWithForegroundSelectionToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
			this.includeObjectsWithForegroundSelectionToolStripMenuItem.Text = "&Include objects with foreground selection";
			// 
			// switchMouseButtonsInChunkAndBlockEditorsToolStripMenuItem
			// 
			this.switchMouseButtonsInChunkAndBlockEditorsToolStripMenuItem.CheckOnClick = true;
			this.switchMouseButtonsInChunkAndBlockEditorsToolStripMenuItem.Name = "switchMouseButtonsInChunkAndBlockEditorsToolStripMenuItem";
			this.switchMouseButtonsInChunkAndBlockEditorsToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
			this.switchMouseButtonsInChunkAndBlockEditorsToolStripMenuItem.Text = "Switch mouse buttons in chunk editor";
			this.switchMouseButtonsInChunkAndBlockEditorsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.switchMouseButtonsInChunkAndBlockEditorsToolStripMenuItem_CheckedChanged);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.includeobjectsWithFGToolStripMenuItem,
            this.objectsAboveHighPlaneToolStripMenuItem,
            this.hUDToolStripMenuItem,
            this.invertColorsToolStripMenuItem,
            this.layersToolStripMenuItem,
            this.collisionToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.zoomToolStripMenuItem,
            this.toolStripSeparator4,
            this.usageCountsToolStripMenuItem,
            this.logToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// includeobjectsWithFGToolStripMenuItem
			// 
			this.includeobjectsWithFGToolStripMenuItem.Checked = true;
			this.includeobjectsWithFGToolStripMenuItem.CheckOnClick = true;
			this.includeobjectsWithFGToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.includeobjectsWithFGToolStripMenuItem.Name = "includeobjectsWithFGToolStripMenuItem";
			this.includeobjectsWithFGToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.includeobjectsWithFGToolStripMenuItem.Text = "Include &objects with FG";
			this.includeobjectsWithFGToolStripMenuItem.CheckedChanged += new System.EventHandler(this.includeObjectsWithFGToolStripMenuItem_CheckedChanged);
			// 
			// objectsAboveHighPlaneToolStripMenuItem
			// 
			this.objectsAboveHighPlaneToolStripMenuItem.Name = "objectsAboveHighPlaneToolStripMenuItem";
			this.objectsAboveHighPlaneToolStripMenuItem.ShortcutKeyDisplayString = "T";
			this.objectsAboveHighPlaneToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.objectsAboveHighPlaneToolStripMenuItem.Text = "&Objects above high plane";
			this.objectsAboveHighPlaneToolStripMenuItem.CheckedChanged += new System.EventHandler(this.objectsAboveHighPlaneToolStripMenuItem_CheckedChanged);
			this.objectsAboveHighPlaneToolStripMenuItem.Click += new System.EventHandler(this.objectsAboveHighPlaneToolStripMenuItem_Click);
			// 
			// hUDToolStripMenuItem
			// 
			this.hUDToolStripMenuItem.Checked = true;
			this.hUDToolStripMenuItem.CheckOnClick = true;
			this.hUDToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.hUDToolStripMenuItem.Name = "hUDToolStripMenuItem";
			this.hUDToolStripMenuItem.ShortcutKeyDisplayString = "O";
			this.hUDToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.hUDToolStripMenuItem.Text = "&HUD";
			// 
			// invertColorsToolStripMenuItem
			// 
			this.invertColorsToolStripMenuItem.CheckOnClick = true;
			this.invertColorsToolStripMenuItem.Name = "invertColorsToolStripMenuItem";
			this.invertColorsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.invertColorsToolStripMenuItem.Text = "I&nvert Colors";
			this.invertColorsToolStripMenuItem.Click += new System.EventHandler(this.invertColorsToolStripMenuItem_Click);
			// 
			// layersToolStripMenuItem
			// 
			this.layersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowToolStripMenuItem,
            this.highToolStripMenuItem});
			this.layersToolStripMenuItem.Name = "layersToolStripMenuItem";
			this.layersToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.layersToolStripMenuItem.Text = "&Layers";
			// 
			// lowToolStripMenuItem
			// 
			this.lowToolStripMenuItem.Checked = true;
			this.lowToolStripMenuItem.CheckOnClick = true;
			this.lowToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.lowToolStripMenuItem.Name = "lowToolStripMenuItem";
			this.lowToolStripMenuItem.ShortcutKeyDisplayString = "Y";
			this.lowToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.lowToolStripMenuItem.Text = "&Low";
			this.lowToolStripMenuItem.CheckedChanged += new System.EventHandler(this.lowToolStripMenuItem_CheckedChanged);
			this.lowToolStripMenuItem.Click += new System.EventHandler(this.lowToolStripMenuItem_Click);
			// 
			// highToolStripMenuItem
			// 
			this.highToolStripMenuItem.Checked = true;
			this.highToolStripMenuItem.CheckOnClick = true;
			this.highToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.highToolStripMenuItem.Name = "highToolStripMenuItem";
			this.highToolStripMenuItem.ShortcutKeyDisplayString = "U";
			this.highToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
			this.highToolStripMenuItem.Text = "&High";
			this.highToolStripMenuItem.CheckedChanged += new System.EventHandler(this.highToolStripMenuItem_CheckedChanged);
			this.highToolStripMenuItem.Click += new System.EventHandler(this.highToolStripMenuItem_Click);
			// 
			// collisionToolStripMenuItem
			// 
			this.collisionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem1,
            this.path1ToolStripMenuItem,
            this.path2ToolStripMenuItem,
            this.toolStripSeparator6,
            this.anglesToolStripMenuItem});
			this.collisionToolStripMenuItem.Name = "collisionToolStripMenuItem";
			this.collisionToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.collisionToolStripMenuItem.Text = "&Collision";
			this.collisionToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.collisionToolStripMenuItem_DropDownItemClicked);
			// 
			// noneToolStripMenuItem1
			// 
			this.noneToolStripMenuItem1.Checked = true;
			this.noneToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.noneToolStripMenuItem1.Name = "noneToolStripMenuItem1";
			this.noneToolStripMenuItem1.ShortcutKeyDisplayString = "Q";
			this.noneToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
			this.noneToolStripMenuItem1.Text = "&None";
			// 
			// path1ToolStripMenuItem
			// 
			this.path1ToolStripMenuItem.Name = "path1ToolStripMenuItem";
			this.path1ToolStripMenuItem.ShortcutKeyDisplayString = "W";
			this.path1ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.path1ToolStripMenuItem.Text = "Path &1";
			// 
			// path2ToolStripMenuItem
			// 
			this.path2ToolStripMenuItem.Name = "path2ToolStripMenuItem";
			this.path2ToolStripMenuItem.ShortcutKeyDisplayString = "E";
			this.path2ToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.path2ToolStripMenuItem.Text = "Path &2";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(122, 6);
			// 
			// anglesToolStripMenuItem
			// 
			this.anglesToolStripMenuItem.CheckOnClick = true;
			this.anglesToolStripMenuItem.Name = "anglesToolStripMenuItem";
			this.anglesToolStripMenuItem.ShortcutKeyDisplayString = "R";
			this.anglesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.anglesToolStripMenuItem.Text = "Angles";
			// 
			// gridToolStripMenuItem
			// 
			this.gridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableGridToolStripMenuItem,
            this.gridColorToolStripMenuItem});
			this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
			this.gridToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.gridToolStripMenuItem.Text = "&Grid";
			// 
			// enableGridToolStripMenuItem
			// 
			this.enableGridToolStripMenuItem.CheckOnClick = true;
			this.enableGridToolStripMenuItem.Name = "enableGridToolStripMenuItem";
			this.enableGridToolStripMenuItem.ShortcutKeyDisplayString = "I";
			this.enableGridToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.enableGridToolStripMenuItem.Text = "&Enable";
			// 
			// gridColorToolStripMenuItem
			// 
			this.gridColorToolStripMenuItem.Name = "gridColorToolStripMenuItem";
			this.gridColorToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
			this.gridColorToolStripMenuItem.Text = "&Color...";
			this.gridColorToolStripMenuItem.Click += new System.EventHandler(this.gridColorToolStripMenuItem_Click);
			// 
			// zoomToolStripMenuItem
			// 
			this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem7,
            this.xToolStripMenuItem6,
            this.xToolStripMenuItem,
            this.xToolStripMenuItem1,
            this.xToolStripMenuItem2,
            this.xToolStripMenuItem3,
            this.xToolStripMenuItem4,
            this.xToolStripMenuItem5});
			this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
			this.zoomToolStripMenuItem.ShortcutKeyDisplayString = "+ -";
			this.zoomToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.zoomToolStripMenuItem.Text = "&Zoom";
			this.zoomToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.zoomToolStripMenuItem_DropDownItemClicked);
			// 
			// xToolStripMenuItem7
			// 
			this.xToolStripMenuItem7.Name = "xToolStripMenuItem7";
			this.xToolStripMenuItem7.Size = new System.Drawing.Size(97, 22);
			this.xToolStripMenuItem7.Text = "1/8x";
			// 
			// xToolStripMenuItem6
			// 
			this.xToolStripMenuItem6.Name = "xToolStripMenuItem6";
			this.xToolStripMenuItem6.Size = new System.Drawing.Size(97, 22);
			this.xToolStripMenuItem6.Text = "1/4x";
			// 
			// xToolStripMenuItem
			// 
			this.xToolStripMenuItem.Name = "xToolStripMenuItem";
			this.xToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
			this.xToolStripMenuItem.Text = "1/2x";
			// 
			// xToolStripMenuItem1
			// 
			this.xToolStripMenuItem1.Checked = true;
			this.xToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
			this.xToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
			this.xToolStripMenuItem1.Text = "1x";
			// 
			// xToolStripMenuItem2
			// 
			this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
			this.xToolStripMenuItem2.Size = new System.Drawing.Size(97, 22);
			this.xToolStripMenuItem2.Text = "2x";
			// 
			// xToolStripMenuItem3
			// 
			this.xToolStripMenuItem3.Name = "xToolStripMenuItem3";
			this.xToolStripMenuItem3.Size = new System.Drawing.Size(97, 22);
			this.xToolStripMenuItem3.Text = "3x";
			// 
			// xToolStripMenuItem4
			// 
			this.xToolStripMenuItem4.Name = "xToolStripMenuItem4";
			this.xToolStripMenuItem4.Size = new System.Drawing.Size(97, 22);
			this.xToolStripMenuItem4.Text = "4x";
			// 
			// xToolStripMenuItem5
			// 
			this.xToolStripMenuItem5.Name = "xToolStripMenuItem5";
			this.xToolStripMenuItem5.Size = new System.Drawing.Size(97, 22);
			this.xToolStripMenuItem5.Text = "5x";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(218, 6);
			// 
			// usageCountsToolStripMenuItem
			// 
			this.usageCountsToolStripMenuItem.Enabled = false;
			this.usageCountsToolStripMenuItem.Name = "usageCountsToolStripMenuItem";
			this.usageCountsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.usageCountsToolStripMenuItem.Text = "&Usage Counts";
			this.usageCountsToolStripMenuItem.Click += new System.EventHandler(this.usageCountsToolStripMenuItem_Click);
			// 
			// logToolStripMenuItem
			// 
			this.logToolStripMenuItem.Name = "logToolStripMenuItem";
			this.logToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
			this.logToolStripMenuItem.Text = "&Log";
			this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paletteToolStripMenuItem,
            this.tilesToolStripMenuItem,
            this.chunksToolStripMenuItem,
            this.solidityMapsToolStripMenuItem,
            this.foregroundToolStripMenuItem,
            this.backgroundToolStripMenuItem,
            toolStripSeparator1,
            this.transparentBackgroundToolStripMenuItem,
            this.useHexadecimalIndexesToolStripMenuItem,
            this.exportArtcollisionpriorityToolStripMenuItem});
			this.exportToolStripMenuItem.Enabled = false;
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.exportToolStripMenuItem.Text = "E&xport";
			// 
			// paletteToolStripMenuItem
			// 
			this.paletteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pNGToolStripMenuItem,
            this.yYCHRToolStripMenuItem,
            this.jASCPALToolStripMenuItem});
			this.paletteToolStripMenuItem.Name = "paletteToolStripMenuItem";
			this.paletteToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
			this.paletteToolStripMenuItem.Text = "&Palette";
			// 
			// pNGToolStripMenuItem
			// 
			this.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
			this.pNGToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.pNGToolStripMenuItem.Text = "&PNG";
			this.pNGToolStripMenuItem.Click += new System.EventHandler(this.pNGToolStripMenuItem_Click);
			// 
			// yYCHRToolStripMenuItem
			// 
			this.yYCHRToolStripMenuItem.Name = "yYCHRToolStripMenuItem";
			this.yYCHRToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.yYCHRToolStripMenuItem.Text = "ACT";
			this.yYCHRToolStripMenuItem.Click += new System.EventHandler(this.yYCHRToolStripMenuItem_Click);
			// 
			// jASCPALToolStripMenuItem
			// 
			this.jASCPALToolStripMenuItem.Name = "jASCPALToolStripMenuItem";
			this.jASCPALToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.jASCPALToolStripMenuItem.Text = "JASC-PAL";
			this.jASCPALToolStripMenuItem.Click += new System.EventHandler(this.jASCPALToolStripMenuItem_Click);
			// 
			// tilesToolStripMenuItem
			// 
			this.tilesToolStripMenuItem.Name = "tilesToolStripMenuItem";
			this.tilesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
			this.tilesToolStripMenuItem.Text = "&Tiles";
			this.tilesToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tilesToolStripMenuItem_DropDownItemClicked);
			// 
			// chunksToolStripMenuItem
			// 
			this.chunksToolStripMenuItem.Name = "chunksToolStripMenuItem";
			this.chunksToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
			this.chunksToolStripMenuItem.Text = "&Chunks";
			this.chunksToolStripMenuItem.Click += new System.EventHandler(this.chunksToolStripMenuItem_Click);
			// 
			// solidityMapsToolStripMenuItem
			// 
			this.solidityMapsToolStripMenuItem.Name = "solidityMapsToolStripMenuItem";
			this.solidityMapsToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
			this.solidityMapsToolStripMenuItem.Text = "&Solidity Maps";
			this.solidityMapsToolStripMenuItem.Click += new System.EventHandler(this.solidityMapsToolStripMenuItem_Click);
			// 
			// foregroundToolStripMenuItem
			// 
			this.foregroundToolStripMenuItem.Name = "foregroundToolStripMenuItem";
			this.foregroundToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
			this.foregroundToolStripMenuItem.Text = "&Foreground";
			this.foregroundToolStripMenuItem.Click += new System.EventHandler(this.foregroundToolStripMenuItem_Click);
			// 
			// backgroundToolStripMenuItem
			// 
			this.backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
			this.backgroundToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
			this.backgroundToolStripMenuItem.Text = "B&ackground";
			this.backgroundToolStripMenuItem.Click += new System.EventHandler(this.backgroundToolStripMenuItem_Click);
			// 
			// transparentBackgroundToolStripMenuItem
			// 
			this.transparentBackgroundToolStripMenuItem.Checked = true;
			this.transparentBackgroundToolStripMenuItem.CheckOnClick = true;
			this.transparentBackgroundToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.transparentBackgroundToolStripMenuItem.Name = "transparentBackgroundToolStripMenuItem";
			this.transparentBackgroundToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
			this.transparentBackgroundToolStripMenuItem.Text = "T&ransparent background";
			this.transparentBackgroundToolStripMenuItem.CheckedChanged += new System.EventHandler(this.transparentBackgroundToolStripMenuItem_CheckedChanged);
			// 
			// useHexadecimalIndexesToolStripMenuItem
			// 
			this.useHexadecimalIndexesToolStripMenuItem.CheckOnClick = true;
			this.useHexadecimalIndexesToolStripMenuItem.Name = "useHexadecimalIndexesToolStripMenuItem";
			this.useHexadecimalIndexesToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
			this.useHexadecimalIndexesToolStripMenuItem.Text = "Use he&xadecimal indexes";
			this.useHexadecimalIndexesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.useHexadecimalIndexesToolStripMenuItem_CheckedChanged);
			// 
			// exportArtcollisionpriorityToolStripMenuItem
			// 
			this.exportArtcollisionpriorityToolStripMenuItem.CheckOnClick = true;
			this.exportArtcollisionpriorityToolStripMenuItem.Name = "exportArtcollisionpriorityToolStripMenuItem";
			this.exportArtcollisionpriorityToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
			this.exportArtcollisionpriorityToolStripMenuItem.Text = "Export art+collision+priority";
			this.exportArtcollisionpriorityToolStripMenuItem.CheckedChanged += new System.EventHandler(this.exportArtcollisionpriorityToolStripMenuItem_CheckedChanged);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewReadmeToolStripMenuItem,
            this.reportBugToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// viewReadmeToolStripMenuItem
			// 
			this.viewReadmeToolStripMenuItem.Name = "viewReadmeToolStripMenuItem";
			this.viewReadmeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.viewReadmeToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.viewReadmeToolStripMenuItem.Text = "View &Readme";
			this.viewReadmeToolStripMenuItem.Click += new System.EventHandler(this.viewReadmeToolStripMenuItem_Click);
			// 
			// reportBugToolStripMenuItem
			// 
			this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
			this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.reportBugToolStripMenuItem.Text = "Report &Bug...";
			this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.reportBugToolStripMenuItem_Click);
			// 
			// backgroundLevelLoader
			// 
			this.backgroundLevelLoader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundLevelLoader_DoWork);
			this.backgroundLevelLoader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundLevelLoader_RunWorkerCompleted);
			// 
			// objectContextMenuStrip
			// 
			this.objectContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addObjectToolStripMenuItem,
            this.addGroupOfObjectsToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator5,
            this.selectAllObjectsToolStripMenuItem});
			this.objectContextMenuStrip.Name = "contextMenuStrip1";
			this.objectContextMenuStrip.Size = new System.Drawing.Size(199, 164);
			// 
			// addObjectToolStripMenuItem
			// 
			this.addObjectToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.mon;
			this.addObjectToolStripMenuItem.Name = "addObjectToolStripMenuItem";
			this.addObjectToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.addObjectToolStripMenuItem.Text = "Add &Object...";
			this.addObjectToolStripMenuItem.Click += new System.EventHandler(this.addObjectToolStripMenuItem_Click);
			// 
			// addGroupOfObjectsToolStripMenuItem
			// 
			this.addGroupOfObjectsToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.mon;
			this.addGroupOfObjectsToolStripMenuItem.Name = "addGroupOfObjectsToolStripMenuItem";
			this.addGroupOfObjectsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.addGroupOfObjectsToolStripMenuItem.Text = "Add Group of O&bjects...";
			this.addGroupOfObjectsToolStripMenuItem.Click += new System.EventHandler(this.addGroupOfObjectsToolStripMenuItem_Click);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.cut;
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.cutToolStripMenuItem.Text = "Cu&t";
			this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.copy;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.paste;
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.pasteToolStripMenuItem.Text = "&Paste";
			this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
			// 
			// deleteToolStripMenuItem
			// 
			this.deleteToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.delete;
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.deleteToolStripMenuItem.Text = "&Delete";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(195, 6);
			// 
			// selectAllObjectsToolStripMenuItem
			// 
			this.selectAllObjectsToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.mon;
			this.selectAllObjectsToolStripMenuItem.Name = "selectAllObjectsToolStripMenuItem";
			this.selectAllObjectsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.selectAllObjectsToolStripMenuItem.Text = "&Select All Objects";
			this.selectAllObjectsToolStripMenuItem.Click += new System.EventHandler(this.selectAllObjectsToolStripMenuItem_Click);
			// 
			// ObjectProperties
			// 
			this.ObjectProperties.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.ObjectProperties.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ObjectProperties.LineColor = System.Drawing.SystemColors.ControlDark;
			this.ObjectProperties.Location = new System.Drawing.Point(3, 3);
			this.ObjectProperties.Margin = new System.Windows.Forms.Padding(0);
			this.ObjectProperties.Name = "ObjectProperties";
			this.ObjectProperties.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.ObjectProperties.Size = new System.Drawing.Size(182, 445);
			this.ObjectProperties.TabIndex = 12;
			this.ObjectProperties.ToolbarVisible = false;
			this.ObjectProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.ObjectProperties_PropertyValueChanged);
			this.ObjectProperties.SelectedGridItemChanged += new System.Windows.Forms.SelectedGridItemChangedEventHandler(this.ObjectProperties_SelectedGridItemChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage15);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(658, 503);
			this.tabControl1.TabIndex = 3;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(650, 477);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Objects";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer4);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl5);
			this.splitContainer1.Size = new System.Drawing.Size(650, 477);
			this.splitContainer1.SplitterDistance = 450;
			this.splitContainer1.TabIndex = 3;
			// 
			// splitContainer4
			// 
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.objectTypeList);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.objectPanel);
			this.splitContainer4.Panel2.Controls.Add(this.objToolStrip);
			this.splitContainer4.Size = new System.Drawing.Size(450, 477);
			this.splitContainer4.SplitterDistance = 98;
			this.splitContainer4.TabIndex = 3;
			// 
			// objectTypeList
			// 
			this.objectTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.objectTypeList.HideSelection = false;
			this.objectTypeList.LargeImageList = this.objectTypeImages;
			this.objectTypeList.Location = new System.Drawing.Point(0, 0);
			this.objectTypeList.MultiSelect = false;
			this.objectTypeList.Name = "objectTypeList";
			this.objectTypeList.Size = new System.Drawing.Size(98, 477);
			this.objectTypeList.TabIndex = 0;
			this.objectTypeList.UseCompatibleStateImageBehavior = false;
			this.objectTypeList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.objectTypeList_ItemDrag);
			// 
			// objectTypeImages
			// 
			this.objectTypeImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.objectTypeImages.ImageSize = new System.Drawing.Size(32, 32);
			this.objectTypeImages.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// objectPanel
			// 
			this.objectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.objectPanel.HScrollEnabled = false;
			this.objectPanel.HScrollLargeChange = 128;
			this.objectPanel.HScrollMaximum = 128;
			this.objectPanel.HScrollMinimum = 0;
			this.objectPanel.HScrollSmallChange = 16;
			this.objectPanel.HScrollValue = 0;
			this.objectPanel.Location = new System.Drawing.Point(0, 25);
			this.objectPanel.Name = "objectPanel";
			this.objectPanel.PanelAllowDrop = true;
			this.objectPanel.PanelCursor = System.Windows.Forms.Cursors.Default;
			this.objectPanel.Size = new System.Drawing.Size(348, 452);
			this.objectPanel.TabIndex = 5;
			this.objectPanel.VScrollEnabled = false;
			this.objectPanel.VScrollLargeChange = 128;
			this.objectPanel.VScrollMaximum = 128;
			this.objectPanel.VScrollMinimum = 0;
			this.objectPanel.VScrollSmallChange = 16;
			this.objectPanel.VScrollValue = 0;
			this.objectPanel.PanelPaint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
			this.objectPanel.PanelKeyDown += new System.Windows.Forms.KeyEventHandler(this.objectPanel_KeyDown);
			this.objectPanel.PanelMouseDown += new System.Windows.Forms.MouseEventHandler(this.objectPanel_MouseDown);
			this.objectPanel.PanelMouseUp += new System.Windows.Forms.MouseEventHandler(this.objectPanel_MouseUp);
			this.objectPanel.PanelMouseMove += new System.Windows.Forms.MouseEventHandler(this.objectPanel_MouseMove);
			this.objectPanel.PanelDragEnter += new System.Windows.Forms.DragEventHandler(this.objectPanel_DragEnter);
			this.objectPanel.PanelDragOver += new System.Windows.Forms.DragEventHandler(this.objectPanel_DragOver);
			this.objectPanel.PanelDragLeave += new System.EventHandler(this.objectPanel_DragLeave);
			this.objectPanel.PanelDragDrop += new System.Windows.Forms.DragEventHandler(this.objectPanel_DragDrop);
			this.objectPanel.ScrollBarValueChanged += new System.EventHandler(this.ScrollBar_ValueChanged);
			this.objectPanel.Resize += new System.EventHandler(this.panel_Resize);
			// 
			// objToolStrip
			// 
			this.objToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.objToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objGridSizeDropDownButton,
            toolStripSeparator10,
            this.alignLeftWallToolStripButton,
            this.alignGroundToolStripButton,
            this.alignRightWallToolStripButton,
            this.alignCeilingToolStripButton,
            toolStripSeparator8,
            this.alignLeftsToolStripButton,
            this.alignCentersToolStripButton,
            this.alignRightsToolStripButton,
            toolStripSeparator9,
            this.alignTopsToolStripButton,
            this.alignMiddlesToolStripButton,
            this.alignBottomsToolStripButton});
			this.objToolStrip.Location = new System.Drawing.Point(0, 0);
			this.objToolStrip.Name = "objToolStrip";
			this.objToolStrip.Size = new System.Drawing.Size(348, 25);
			this.objToolStrip.TabIndex = 4;
			this.objToolStrip.Text = "toolStrip1";
			// 
			// objGridSizeDropDownButton
			// 
			this.objGridSizeDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.objGridSizeDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem3,
            this.toolStripMenuItem12});
			this.objGridSizeDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("objGridSizeDropDownButton.Image")));
			this.objGridSizeDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.objGridSizeDropDownButton.Name = "objGridSizeDropDownButton";
			this.objGridSizeDropDownButton.Size = new System.Drawing.Size(77, 22);
			this.objGridSizeDropDownButton.Text = "Grid Size: 1";
			this.objGridSizeDropDownButton.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.objGridSizeDropDownButton_DropDownItemClicked);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItem2.Text = "1";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItem4.Text = "2";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItem5.Text = "4";
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItem6.Text = "8";
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItem7.Text = "16";
			// 
			// toolStripMenuItem8
			// 
			this.toolStripMenuItem8.Name = "toolStripMenuItem8";
			this.toolStripMenuItem8.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItem8.Text = "32";
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItem9.Text = "64";
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItem10.Text = "128";
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItem11.Text = "256";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItem3.Text = "512";
			// 
			// toolStripMenuItem12
			// 
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.Size = new System.Drawing.Size(98, 22);
			this.toolStripMenuItem12.Text = "1024";
			// 
			// alignLeftWallToolStripButton
			// 
			this.alignLeftWallToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.alignLeftWallToolStripButton.Enabled = false;
			this.alignLeftWallToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignLeftWallToolStripButton.Image")));
			this.alignLeftWallToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.alignLeftWallToolStripButton.Name = "alignLeftWallToolStripButton";
			this.alignLeftWallToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.alignLeftWallToolStripButton.Text = "Align with Left Wall";
			this.alignLeftWallToolStripButton.Click += new System.EventHandler(this.alignLeftWallToolStripButton_Click);
			// 
			// alignGroundToolStripButton
			// 
			this.alignGroundToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.alignGroundToolStripButton.Enabled = false;
			this.alignGroundToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignGroundToolStripButton.Image")));
			this.alignGroundToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.alignGroundToolStripButton.Name = "alignGroundToolStripButton";
			this.alignGroundToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.alignGroundToolStripButton.Text = "Align with ground";
			this.alignGroundToolStripButton.Click += new System.EventHandler(this.alignGroundToolStripButton_Click);
			// 
			// alignRightWallToolStripButton
			// 
			this.alignRightWallToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.alignRightWallToolStripButton.Enabled = false;
			this.alignRightWallToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignRightWallToolStripButton.Image")));
			this.alignRightWallToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.alignRightWallToolStripButton.Name = "alignRightWallToolStripButton";
			this.alignRightWallToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.alignRightWallToolStripButton.Text = "Align with Right Wall";
			this.alignRightWallToolStripButton.Click += new System.EventHandler(this.alignRightWallToolStripButton_Click);
			// 
			// alignCeilingToolStripButton
			// 
			this.alignCeilingToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.alignCeilingToolStripButton.Enabled = false;
			this.alignCeilingToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignCeilingToolStripButton.Image")));
			this.alignCeilingToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.alignCeilingToolStripButton.Name = "alignCeilingToolStripButton";
			this.alignCeilingToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.alignCeilingToolStripButton.Text = "Align with Ceiling";
			this.alignCeilingToolStripButton.Click += new System.EventHandler(this.alignCeilingToolStripButton_Click);
			// 
			// alignLeftsToolStripButton
			// 
			this.alignLeftsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.alignLeftsToolStripButton.Enabled = false;
			this.alignLeftsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignLeftsToolStripButton.Image")));
			this.alignLeftsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.alignLeftsToolStripButton.Name = "alignLeftsToolStripButton";
			this.alignLeftsToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.alignLeftsToolStripButton.Text = "Align Lefts";
			this.alignLeftsToolStripButton.Click += new System.EventHandler(this.alignLeftsToolStripButton_Click);
			// 
			// alignCentersToolStripButton
			// 
			this.alignCentersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.alignCentersToolStripButton.Enabled = false;
			this.alignCentersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignCentersToolStripButton.Image")));
			this.alignCentersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.alignCentersToolStripButton.Name = "alignCentersToolStripButton";
			this.alignCentersToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.alignCentersToolStripButton.Text = "Align Centers";
			this.alignCentersToolStripButton.Click += new System.EventHandler(this.alignCentersToolStripButton_Click);
			// 
			// alignRightsToolStripButton
			// 
			this.alignRightsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.alignRightsToolStripButton.Enabled = false;
			this.alignRightsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignRightsToolStripButton.Image")));
			this.alignRightsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.alignRightsToolStripButton.Name = "alignRightsToolStripButton";
			this.alignRightsToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.alignRightsToolStripButton.Text = "Align Rights";
			this.alignRightsToolStripButton.Click += new System.EventHandler(this.alignRightsToolStripButton_Click);
			// 
			// alignTopsToolStripButton
			// 
			this.alignTopsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.alignTopsToolStripButton.Enabled = false;
			this.alignTopsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignTopsToolStripButton.Image")));
			this.alignTopsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.alignTopsToolStripButton.Name = "alignTopsToolStripButton";
			this.alignTopsToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.alignTopsToolStripButton.Text = "Align Tops";
			this.alignTopsToolStripButton.Click += new System.EventHandler(this.alignTopsToolStripButton_Click);
			// 
			// alignMiddlesToolStripButton
			// 
			this.alignMiddlesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.alignMiddlesToolStripButton.Enabled = false;
			this.alignMiddlesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignMiddlesToolStripButton.Image")));
			this.alignMiddlesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.alignMiddlesToolStripButton.Name = "alignMiddlesToolStripButton";
			this.alignMiddlesToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.alignMiddlesToolStripButton.Text = "Align Middles";
			this.alignMiddlesToolStripButton.Click += new System.EventHandler(this.alignMiddlesToolStripButton_Click);
			// 
			// alignBottomsToolStripButton
			// 
			this.alignBottomsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.alignBottomsToolStripButton.Enabled = false;
			this.alignBottomsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alignBottomsToolStripButton.Image")));
			this.alignBottomsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.alignBottomsToolStripButton.Name = "alignBottomsToolStripButton";
			this.alignBottomsToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.alignBottomsToolStripButton.Text = "Align Bottoms";
			this.alignBottomsToolStripButton.Click += new System.EventHandler(this.alignBottomsToolStripButton_Click);
			// 
			// tabControl5
			// 
			this.tabControl5.Controls.Add(this.tabPage5);
			this.tabControl5.Controls.Add(this.tabPage7);
			this.tabControl5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl5.Location = new System.Drawing.Point(0, 0);
			this.tabControl5.Name = "tabControl5";
			this.tabControl5.SelectedIndex = 0;
			this.tabControl5.Size = new System.Drawing.Size(196, 477);
			this.tabControl5.TabIndex = 13;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.ObjectProperties);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(188, 451);
			this.tabPage5.TabIndex = 0;
			this.tabPage5.Text = "Properties";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.objectOrder);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(188, 451);
			this.tabPage7.TabIndex = 1;
			this.tabPage7.Text = "Order";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// objectOrder
			// 
			this.objectOrder.AllowDrop = true;
			this.objectOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.objectOrder.Dock = System.Windows.Forms.DockStyle.Fill;
			this.objectOrder.FullRowSelect = true;
			this.objectOrder.HideSelection = false;
			this.objectOrder.LargeImageList = this.objectTypeImages;
			this.objectOrder.Location = new System.Drawing.Point(3, 3);
			this.objectOrder.MultiSelect = false;
			this.objectOrder.Name = "objectOrder";
			this.objectOrder.Size = new System.Drawing.Size(182, 445);
			this.objectOrder.TabIndex = 0;
			this.objectOrder.UseCompatibleStateImageBehavior = false;
			this.objectOrder.View = System.Windows.Forms.View.Tile;
			this.objectOrder.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.objectOrder_ItemDrag);
			this.objectOrder.SelectedIndexChanged += new System.EventHandler(this.objectOrder_SelectedIndexChanged);
			this.objectOrder.DragDrop += new System.Windows.Forms.DragEventHandler(this.objectOrder_DragDrop);
			this.objectOrder.DragEnter += new System.Windows.Forms.DragEventHandler(this.objectOrder_DragEnter);
			this.objectOrder.DragOver += new System.Windows.Forms.DragEventHandler(this.objectOrder_DragOver);
			this.objectOrder.DragLeave += new System.EventHandler(this.objectOrder_DragLeave);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.splitContainer2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(650, 477);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Foreground";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.foregroundPanel);
			this.splitContainer2.Panel1.Controls.Add(this.fgToolStrip);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(tabControl2);
			this.splitContainer2.Size = new System.Drawing.Size(650, 477);
			this.splitContainer2.SplitterDistance = 360;
			this.splitContainer2.TabIndex = 4;
			// 
			// foregroundPanel
			// 
			this.foregroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.foregroundPanel.HScrollEnabled = false;
			this.foregroundPanel.HScrollLargeChange = 128;
			this.foregroundPanel.HScrollMaximum = 128;
			this.foregroundPanel.HScrollMinimum = 0;
			this.foregroundPanel.HScrollSmallChange = 16;
			this.foregroundPanel.HScrollValue = 0;
			this.foregroundPanel.Location = new System.Drawing.Point(0, 25);
			this.foregroundPanel.Name = "foregroundPanel";
			this.foregroundPanel.PanelAllowDrop = false;
			this.foregroundPanel.PanelCursor = System.Windows.Forms.Cursors.Default;
			this.foregroundPanel.Size = new System.Drawing.Size(360, 452);
			this.foregroundPanel.TabIndex = 5;
			this.foregroundPanel.VScrollEnabled = false;
			this.foregroundPanel.VScrollLargeChange = 128;
			this.foregroundPanel.VScrollMaximum = 128;
			this.foregroundPanel.VScrollMinimum = 0;
			this.foregroundPanel.VScrollSmallChange = 16;
			this.foregroundPanel.VScrollValue = 0;
			this.foregroundPanel.PanelPaint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
			this.foregroundPanel.PanelKeyDown += new System.Windows.Forms.KeyEventHandler(this.foregroundPanel_KeyDown);
			this.foregroundPanel.PanelMouseDown += new System.Windows.Forms.MouseEventHandler(this.foregroundPanel_MouseDown);
			this.foregroundPanel.PanelMouseUp += new System.Windows.Forms.MouseEventHandler(this.foregroundPanel_MouseUp);
			this.foregroundPanel.PanelMouseMove += new System.Windows.Forms.MouseEventHandler(this.foregroundPanel_MouseMove);
			this.foregroundPanel.ScrollBarValueChanged += new System.EventHandler(this.ScrollBar_ValueChanged);
			this.foregroundPanel.Resize += new System.EventHandler(this.panel_Resize);
			// 
			// fgToolStrip
			// 
			this.fgToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.fgToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceForegroundToolStripButton,
            this.clearForegroundToolStripButton});
			this.fgToolStrip.Location = new System.Drawing.Point(0, 0);
			this.fgToolStrip.Name = "fgToolStrip";
			this.fgToolStrip.Size = new System.Drawing.Size(360, 25);
			this.fgToolStrip.TabIndex = 4;
			this.fgToolStrip.Text = "toolStrip1";
			// 
			// replaceForegroundToolStripButton
			// 
			this.replaceForegroundToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.replaceForegroundToolStripButton.Enabled = false;
			this.replaceForegroundToolStripButton.Name = "replaceForegroundToolStripButton";
			this.replaceForegroundToolStripButton.Size = new System.Drawing.Size(52, 22);
			this.replaceForegroundToolStripButton.Text = "Replace";
			this.replaceForegroundToolStripButton.Click += new System.EventHandler(this.replaceForegroundToolStripButton_Click);
			// 
			// clearForegroundToolStripButton
			// 
			this.clearForegroundToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.clearForegroundToolStripButton.Enabled = false;
			this.clearForegroundToolStripButton.Name = "clearForegroundToolStripButton";
			this.clearForegroundToolStripButton.Size = new System.Drawing.Size(38, 22);
			this.clearForegroundToolStripButton.Text = "Clear";
			this.clearForegroundToolStripButton.Click += new System.EventHandler(this.clearForegroundToolStripButton_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.splitContainer3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(650, 477);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Background";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Margin = new System.Windows.Forms.Padding(0);
			this.splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.backgroundPanel);
			this.splitContainer3.Panel1.Controls.Add(this.bgToolStrip);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.tabControl3);
			this.splitContainer3.Size = new System.Drawing.Size(650, 477);
			this.splitContainer3.SplitterDistance = 360;
			this.splitContainer3.TabIndex = 4;
			// 
			// backgroundPanel
			// 
			this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.backgroundPanel.HScrollEnabled = false;
			this.backgroundPanel.HScrollLargeChange = 128;
			this.backgroundPanel.HScrollMaximum = 128;
			this.backgroundPanel.HScrollMinimum = 0;
			this.backgroundPanel.HScrollSmallChange = 16;
			this.backgroundPanel.HScrollValue = 0;
			this.backgroundPanel.Location = new System.Drawing.Point(0, 25);
			this.backgroundPanel.Name = "backgroundPanel";
			this.backgroundPanel.PanelAllowDrop = false;
			this.backgroundPanel.PanelCursor = System.Windows.Forms.Cursors.Default;
			this.backgroundPanel.Size = new System.Drawing.Size(360, 452);
			this.backgroundPanel.TabIndex = 6;
			this.backgroundPanel.VScrollEnabled = false;
			this.backgroundPanel.VScrollLargeChange = 128;
			this.backgroundPanel.VScrollMaximum = 128;
			this.backgroundPanel.VScrollMinimum = 0;
			this.backgroundPanel.VScrollSmallChange = 16;
			this.backgroundPanel.VScrollValue = 0;
			this.backgroundPanel.PanelPaint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
			this.backgroundPanel.PanelKeyDown += new System.Windows.Forms.KeyEventHandler(this.backgroundPanel_KeyDown);
			this.backgroundPanel.PanelMouseDown += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseDown);
			this.backgroundPanel.PanelMouseUp += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseUp);
			this.backgroundPanel.PanelMouseMove += new System.Windows.Forms.MouseEventHandler(this.backgroundPanel_MouseMove);
			this.backgroundPanel.ScrollBarValueChanged += new System.EventHandler(this.ScrollBar_ValueChanged);
			this.backgroundPanel.Resize += new System.EventHandler(this.panel_Resize);
			// 
			// bgToolStrip
			// 
			this.bgToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bgToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bgLayerDropDown,
            this.replaceBackgroundToolStripButton,
            this.clearBackgroundToolStripButton});
			this.bgToolStrip.Location = new System.Drawing.Point(0, 0);
			this.bgToolStrip.Name = "bgToolStrip";
			this.bgToolStrip.Size = new System.Drawing.Size(360, 25);
			this.bgToolStrip.TabIndex = 5;
			this.bgToolStrip.Text = "toolStrip1";
			// 
			// bgLayerDropDown
			// 
			this.bgLayerDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.bgLayerDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripMenuItem13,
            toolStripMenuItem14,
            toolStripMenuItem15,
            toolStripMenuItem16,
            toolStripMenuItem17,
            toolStripMenuItem18,
            toolStripMenuItem19,
            toolStripMenuItem20});
			this.bgLayerDropDown.Enabled = false;
			this.bgLayerDropDown.Name = "bgLayerDropDown";
			this.bgLayerDropDown.Size = new System.Drawing.Size(60, 22);
			this.bgLayerDropDown.Text = "Layer: 1";
			this.bgLayerDropDown.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.bgLayerDropDown_DropDownItemClicked);
			// 
			// replaceBackgroundToolStripButton
			// 
			this.replaceBackgroundToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.replaceBackgroundToolStripButton.Enabled = false;
			this.replaceBackgroundToolStripButton.Name = "replaceBackgroundToolStripButton";
			this.replaceBackgroundToolStripButton.Size = new System.Drawing.Size(52, 22);
			this.replaceBackgroundToolStripButton.Text = "Replace";
			this.replaceBackgroundToolStripButton.Click += new System.EventHandler(this.replaceBackgroundToolStripButton_Click);
			// 
			// clearBackgroundToolStripButton
			// 
			this.clearBackgroundToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.clearBackgroundToolStripButton.Enabled = false;
			this.clearBackgroundToolStripButton.Name = "clearBackgroundToolStripButton";
			this.clearBackgroundToolStripButton.Size = new System.Drawing.Size(38, 22);
			this.clearBackgroundToolStripButton.Text = "Clear";
			this.clearBackgroundToolStripButton.Click += new System.EventHandler(this.clearBackgroundToolStripButton_Click);
			// 
			// tabControl3
			// 
			this.tabControl3.Controls.Add(this.tabPage10);
			this.tabControl3.Controls.Add(this.tabPage11);
			this.tabControl3.Controls.Add(this.tabPage13);
			this.tabControl3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl3.Location = new System.Drawing.Point(0, 0);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new System.Drawing.Size(286, 477);
			this.tabControl3.TabIndex = 0;
			this.tabControl3.SelectedIndexChanged += new System.EventHandler(this.tabControl3_SelectedIndexChanged);
			// 
			// tabPage10
			// 
			this.tabPage10.Location = new System.Drawing.Point(4, 22);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Size = new System.Drawing.Size(278, 451);
			this.tabPage10.TabIndex = 0;
			this.tabPage10.Text = "Chunks";
			this.tabPage10.UseVisualStyleBackColor = true;
			// 
			// tabPage11
			// 
			this.tabPage11.Location = new System.Drawing.Point(4, 22);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Size = new System.Drawing.Size(278, 451);
			this.tabPage11.TabIndex = 1;
			this.tabPage11.Text = "Layout Sections";
			this.tabPage11.UseVisualStyleBackColor = true;
			// 
			// tabPage13
			// 
			this.tabPage13.Controls.Add(this.showScrollAreas);
			this.tabPage13.Controls.Add(this.scrollFrame);
			this.tabPage13.Controls.Add(this.label16);
			this.tabPage13.Controls.Add(this.scrollCamY);
			this.tabPage13.Controls.Add(this.scrollCamX);
			this.tabPage13.Controls.Add(this.label15);
			this.tabPage13.Controls.Add(this.scrollTargetFPS);
			this.tabPage13.Controls.Add(this.label14);
			this.tabPage13.Controls.Add(this.scrollPreviewButton);
			this.tabPage13.Controls.Add(this.scrollEditPanel);
			this.tabPage13.Controls.Add(this.layerScrollType);
			this.tabPage13.Controls.Add(this.label8);
			this.tabPage13.Location = new System.Drawing.Point(4, 22);
			this.tabPage13.Name = "tabPage13";
			this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage13.Size = new System.Drawing.Size(278, 451);
			this.tabPage13.TabIndex = 2;
			this.tabPage13.Text = "Scrolling";
			this.tabPage13.UseVisualStyleBackColor = true;
			// 
			// showScrollAreas
			// 
			this.showScrollAreas.AutoSize = true;
			this.showScrollAreas.Location = new System.Drawing.Point(111, 62);
			this.showScrollAreas.Name = "showScrollAreas";
			this.showScrollAreas.Size = new System.Drawing.Size(112, 17);
			this.showScrollAreas.TabIndex = 11;
			this.showScrollAreas.Text = "Show Scroll Areas";
			this.showScrollAreas.UseVisualStyleBackColor = true;
			this.showScrollAreas.CheckedChanged += new System.EventHandler(this.showScrollAreas_CheckedChanged);
			// 
			// scrollFrame
			// 
			this.scrollFrame.AutoSize = true;
			this.scrollFrame.Location = new System.Drawing.Point(58, 61);
			this.scrollFrame.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
			this.scrollFrame.Name = "scrollFrame";
			this.scrollFrame.Size = new System.Drawing.Size(47, 20);
			this.scrollFrame.TabIndex = 10;
			this.scrollFrame.ValueChanged += new System.EventHandler(this.scrollFrame_ValueChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(6, 63);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(39, 13);
			this.label16.TabIndex = 9;
			this.label16.Text = "Frame:";
			// 
			// scrollCamY
			// 
			this.scrollCamY.AutoSize = true;
			this.scrollCamY.Hexadecimal = true;
			this.scrollCamY.Location = new System.Drawing.Point(119, 35);
			this.scrollCamY.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			this.scrollCamY.Name = "scrollCamY";
			this.scrollCamY.Size = new System.Drawing.Size(55, 20);
			this.scrollCamY.TabIndex = 8;
			this.scrollCamY.ValueChanged += new System.EventHandler(this.scrollCamY_ValueChanged);
			// 
			// scrollCamX
			// 
			this.scrollCamX.AutoSize = true;
			this.scrollCamX.Hexadecimal = true;
			this.scrollCamX.Location = new System.Drawing.Point(58, 35);
			this.scrollCamX.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
			this.scrollCamX.Name = "scrollCamX";
			this.scrollCamX.Size = new System.Drawing.Size(55, 20);
			this.scrollCamX.TabIndex = 7;
			this.scrollCamX.ValueChanged += new System.EventHandler(this.scrollCamX_ValueChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 37);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(46, 13);
			this.label15.TabIndex = 6;
			this.label15.Text = "Camera:";
			// 
			// scrollTargetFPS
			// 
			this.scrollTargetFPS.AutoSize = true;
			this.scrollTargetFPS.Location = new System.Drawing.Point(192, 90);
			this.scrollTargetFPS.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.scrollTargetFPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.scrollTargetFPS.Name = "scrollTargetFPS";
			this.scrollTargetFPS.Size = new System.Drawing.Size(47, 20);
			this.scrollTargetFPS.TabIndex = 5;
			this.scrollTargetFPS.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(87, 92);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(99, 13);
			this.label14.TabIndex = 4;
			this.label14.Text = "Target Frame Rate:";
			// 
			// scrollPreviewButton
			// 
			this.scrollPreviewButton.Appearance = System.Windows.Forms.Appearance.Button;
			this.scrollPreviewButton.Enabled = false;
			this.scrollPreviewButton.Location = new System.Drawing.Point(6, 87);
			this.scrollPreviewButton.Name = "scrollPreviewButton";
			this.scrollPreviewButton.Size = new System.Drawing.Size(75, 23);
			this.scrollPreviewButton.TabIndex = 3;
			this.scrollPreviewButton.Text = "Animate!";
			this.scrollPreviewButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.scrollPreviewButton.UseVisualStyleBackColor = true;
			this.scrollPreviewButton.CheckedChanged += new System.EventHandler(this.scrollPreviewButton_CheckedChanged);
			// 
			// scrollEditPanel
			// 
			this.scrollEditPanel.AutoSize = true;
			this.scrollEditPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.scrollEditPanel.Controls.Add(this.scrollOffset);
			this.scrollEditPanel.Controls.Add(this.label13);
			this.scrollEditPanel.Controls.Add(this.scrollScrollSpeed);
			this.scrollEditPanel.Controls.Add(this.label11);
			this.scrollEditPanel.Controls.Add(this.scrollParallaxFactor);
			this.scrollEditPanel.Controls.Add(this.label12);
			this.scrollEditPanel.Controls.Add(this.deleteScrollButton);
			this.scrollEditPanel.Controls.Add(this.addScrollButton);
			this.scrollEditPanel.Controls.Add(this.scrollEnableDeformation);
			this.scrollEditPanel.Controls.Add(this.scrollList);
			this.scrollEditPanel.Controls.Add(this.layerScrollSpeed);
			this.scrollEditPanel.Controls.Add(this.label10);
			this.scrollEditPanel.Controls.Add(this.layerParallaxFactor);
			this.scrollEditPanel.Controls.Add(this.label9);
			this.scrollEditPanel.Enabled = false;
			this.scrollEditPanel.Location = new System.Drawing.Point(3, 113);
			this.scrollEditPanel.Margin = new System.Windows.Forms.Padding(0);
			this.scrollEditPanel.Name = "scrollEditPanel";
			this.scrollEditPanel.Size = new System.Drawing.Size(202, 339);
			this.scrollEditPanel.TabIndex = 2;
			// 
			// scrollOffset
			// 
			this.scrollOffset.Hexadecimal = true;
			this.scrollOffset.Location = new System.Drawing.Point(118, 241);
			this.scrollOffset.Name = "scrollOffset";
			this.scrollOffset.Size = new System.Drawing.Size(81, 20);
			this.scrollOffset.TabIndex = 13;
			this.scrollOffset.ValueChanged += new System.EventHandler(this.scrollOffset_ValueChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 243);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(38, 13);
			this.label13.TabIndex = 12;
			this.label13.Text = "Offset:";
			// 
			// scrollScrollSpeed
			// 
			this.scrollScrollSpeed.DecimalPlaces = 5;
			this.scrollScrollSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.scrollScrollSpeed.Location = new System.Drawing.Point(118, 316);
			this.scrollScrollSpeed.Maximum = new decimal(new int[] {
            3984375,
            0,
            0,
            393216});
			this.scrollScrollSpeed.Name = "scrollScrollSpeed";
			this.scrollScrollSpeed.Size = new System.Drawing.Size(81, 20);
			this.scrollScrollSpeed.TabIndex = 11;
			this.scrollScrollSpeed.ValueChanged += new System.EventHandler(this.scrollScrollSpeed_ValueChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 318);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(70, 13);
			this.label11.TabIndex = 10;
			this.label11.Text = "Scroll Speed:";
			// 
			// scrollParallaxFactor
			// 
			this.scrollParallaxFactor.DecimalPlaces = 5;
			this.scrollParallaxFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.scrollParallaxFactor.Location = new System.Drawing.Point(118, 290);
			this.scrollParallaxFactor.Maximum = new decimal(new int[] {
            -170194401,
            5,
            0,
            524288});
			this.scrollParallaxFactor.Name = "scrollParallaxFactor";
			this.scrollParallaxFactor.Size = new System.Drawing.Size(81, 20);
			this.scrollParallaxFactor.TabIndex = 9;
			this.scrollParallaxFactor.ValueChanged += new System.EventHandler(this.scrollParallaxFactor_ValueChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 292);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 13);
			this.label12.TabIndex = 8;
			this.label12.Text = "Parallax Factor:";
			// 
			// deleteScrollButton
			// 
			this.deleteScrollButton.Enabled = false;
			this.deleteScrollButton.Location = new System.Drawing.Point(84, 212);
			this.deleteScrollButton.Name = "deleteScrollButton";
			this.deleteScrollButton.Size = new System.Drawing.Size(75, 23);
			this.deleteScrollButton.TabIndex = 7;
			this.deleteScrollButton.Text = "Delete";
			this.deleteScrollButton.UseVisualStyleBackColor = true;
			this.deleteScrollButton.Click += new System.EventHandler(this.deleteScrollButton_Click);
			// 
			// addScrollButton
			// 
			this.addScrollButton.Location = new System.Drawing.Point(3, 212);
			this.addScrollButton.Name = "addScrollButton";
			this.addScrollButton.Size = new System.Drawing.Size(75, 23);
			this.addScrollButton.TabIndex = 6;
			this.addScrollButton.Text = "Add";
			this.addScrollButton.UseVisualStyleBackColor = true;
			this.addScrollButton.Click += new System.EventHandler(this.addScrollButton_Click);
			// 
			// scrollEnableDeformation
			// 
			this.scrollEnableDeformation.AutoSize = true;
			this.scrollEnableDeformation.Location = new System.Drawing.Point(3, 267);
			this.scrollEnableDeformation.Name = "scrollEnableDeformation";
			this.scrollEnableDeformation.Size = new System.Drawing.Size(119, 17);
			this.scrollEnableDeformation.TabIndex = 5;
			this.scrollEnableDeformation.Text = "Enable Deformation";
			this.scrollEnableDeformation.UseVisualStyleBackColor = true;
			this.scrollEnableDeformation.CheckedChanged += new System.EventHandler(this.scrollEnableDeformation_CheckedChanged);
			// 
			// scrollList
			// 
			this.scrollList.FormattingEnabled = true;
			this.scrollList.IntegralHeight = false;
			this.scrollList.Location = new System.Drawing.Point(3, 55);
			this.scrollList.Name = "scrollList";
			this.scrollList.Size = new System.Drawing.Size(196, 151);
			this.scrollList.TabIndex = 4;
			this.scrollList.SelectedIndexChanged += new System.EventHandler(this.scrollList_SelectedIndexChanged);
			// 
			// layerScrollSpeed
			// 
			this.layerScrollSpeed.DecimalPlaces = 5;
			this.layerScrollSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.layerScrollSpeed.Location = new System.Drawing.Point(118, 29);
			this.layerScrollSpeed.Maximum = new decimal(new int[] {
            3984375,
            0,
            0,
            393216});
			this.layerScrollSpeed.Name = "layerScrollSpeed";
			this.layerScrollSpeed.Size = new System.Drawing.Size(81, 20);
			this.layerScrollSpeed.TabIndex = 3;
			this.layerScrollSpeed.ValueChanged += new System.EventHandler(this.layerScrollSpeed_ValueChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 31);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(99, 13);
			this.label10.TabIndex = 2;
			this.label10.Text = "Layer Scroll Speed:";
			// 
			// layerParallaxFactor
			// 
			this.layerParallaxFactor.DecimalPlaces = 5;
			this.layerParallaxFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
			this.layerParallaxFactor.Location = new System.Drawing.Point(118, 3);
			this.layerParallaxFactor.Maximum = new decimal(new int[] {
            -170194401,
            5,
            0,
            524288});
			this.layerParallaxFactor.Name = "layerParallaxFactor";
			this.layerParallaxFactor.Size = new System.Drawing.Size(81, 20);
			this.layerParallaxFactor.TabIndex = 1;
			this.layerParallaxFactor.ValueChanged += new System.EventHandler(this.layerParallaxFactor_ValueChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 5);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(109, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Layer Parallax Factor:";
			// 
			// layerScrollType
			// 
			this.layerScrollType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.layerScrollType.FormattingEnabled = true;
			this.layerScrollType.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "3D Sky",
            "3D Floor"});
			this.layerScrollType.Location = new System.Drawing.Point(46, 8);
			this.layerScrollType.Name = "layerScrollType";
			this.layerScrollType.Size = new System.Drawing.Size(121, 21);
			this.layerScrollType.TabIndex = 1;
			this.layerScrollType.SelectedIndexChanged += new System.EventHandler(this.layerScrollType_SelectedIndexChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 11);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(34, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Type:";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.tableLayoutPanel4);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(650, 477);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Art";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.AutoScroll = true;
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel4.ColumnCount = 3;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Controls.Add(tableLayoutPanel6, 1, 0);
			this.tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.tabControl4, 2, 0);
			this.tableLayoutPanel4.Controls.Add(panel9, 1, 1);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel4.Size = new System.Drawing.Size(650, 477);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// tabControl4
			// 
			this.tabControl4.Controls.Add(this.tabPage12);
			this.tabControl4.Controls.Add(this.tabPage14);
			this.tabControl4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl4.Location = new System.Drawing.Point(360, 0);
			this.tabControl4.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl4.MinimumSize = new System.Drawing.Size(300, 300);
			this.tabControl4.Name = "tabControl4";
			this.tableLayoutPanel4.SetRowSpan(this.tabControl4, 2);
			this.tabControl4.SelectedIndex = 0;
			this.tabControl4.Size = new System.Drawing.Size(743, 594);
			this.tabControl4.TabIndex = 0;
			// 
			// tabPage12
			// 
			this.tabPage12.Controls.Add(this.panel10);
			this.tabPage12.Controls.Add(chunkListToolStrip);
			this.tabPage12.Location = new System.Drawing.Point(4, 22);
			this.tabPage12.Name = "tabPage12";
			this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage12.Size = new System.Drawing.Size(735, 568);
			this.tabPage12.TabIndex = 0;
			this.tabPage12.Text = "Chunks";
			this.tabPage12.UseVisualStyleBackColor = true;
			// 
			// tabPage14
			// 
			this.tabPage14.Controls.Add(this.TileSelector);
			this.tabPage14.Controls.Add(tileListToolStrip);
			this.tabPage14.Location = new System.Drawing.Point(4, 22);
			this.tabPage14.Name = "tabPage14";
			this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage14.Size = new System.Drawing.Size(735, 568);
			this.tabPage14.TabIndex = 2;
			this.tabPage14.Text = "Tiles";
			this.tabPage14.UseVisualStyleBackColor = true;
			// 
			// TileSelector
			// 
			this.TileSelector.AllowDrop = true;
			this.TileSelector.BackColor = System.Drawing.SystemColors.Window;
			this.TileSelector.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TileSelector.ImageHeight = 32;
			this.TileSelector.ImageSize = 32;
			this.TileSelector.ImageWidth = 32;
			this.TileSelector.Location = new System.Drawing.Point(3, 28);
			this.TileSelector.Name = "TileSelector";
			this.TileSelector.ScrollValue = 0;
			this.TileSelector.SelectedIndex = -1;
			this.TileSelector.Size = new System.Drawing.Size(729, 537);
			this.TileSelector.TabIndex = 2;
			this.TileSelector.SelectedIndexChanged += new System.EventHandler(this.TileSelector_SelectedIndexChanged);
			this.TileSelector.ItemDrag += new System.EventHandler(this.TileSelector_ItemDrag);
			this.TileSelector.DragDrop += new System.Windows.Forms.DragEventHandler(this.TileSelector_DragDrop);
			this.TileSelector.DragEnter += new System.Windows.Forms.DragEventHandler(this.TileSelector_DragEnter);
			this.TileSelector.DragOver += new System.Windows.Forms.DragEventHandler(this.TileSelector_DragOver);
			this.TileSelector.DragLeave += new System.EventHandler(this.TileSelector_DragLeave);
			this.TileSelector.Paint += new System.Windows.Forms.PaintEventHandler(this.TileSelector_Paint);
			this.TileSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TileList_KeyDown);
			this.TileSelector.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TileSelector_MouseDoubleClick);
			this.TileSelector.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TileSelector_MouseDown);
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.tableLayoutPanel8);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(650, 477);
			this.tabPage6.TabIndex = 4;
			this.tabPage6.Text = "Palette";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.ColumnCount = 2;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.Controls.Add(this.panel8, 1, 1);
			this.tableLayoutPanel8.Controls.Add(this.colorEditingPanel, 0, 1);
			this.tableLayoutPanel8.Controls.Add(this.paletteToolStrip, 0, 0);
			this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 2;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(644, 471);
			this.tableLayoutPanel8.TabIndex = 4;
			// 
			// panel8
			// 
			this.panel8.AutoScroll = true;
			this.panel8.Controls.Add(this.PalettePanel);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(106, 25);
			this.panel8.Margin = new System.Windows.Forms.Padding(0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(538, 446);
			this.panel8.TabIndex = 3;
			// 
			// PalettePanel
			// 
			this.PalettePanel.Location = new System.Drawing.Point(0, 0);
			this.PalettePanel.Margin = new System.Windows.Forms.Padding(0);
			this.PalettePanel.Name = "PalettePanel";
			this.PalettePanel.Size = new System.Drawing.Size(320, 320);
			this.PalettePanel.TabIndex = 0;
			this.PalettePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PalettePanel_Paint);
			this.PalettePanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PalettePanel_MouseDoubleClick);
			this.PalettePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PalettePanel_MouseDown);
			this.PalettePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PalettePanel_MouseMove);
			this.PalettePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PalettePanel_MouseUp);
			// 
			// colorEditingPanel
			// 
			this.colorEditingPanel.AutoSize = true;
			this.colorEditingPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.colorEditingPanel.Controls.Add(this.colorBlue);
			this.colorEditingPanel.Controls.Add(label4);
			this.colorEditingPanel.Controls.Add(this.colorGreen);
			this.colorEditingPanel.Controls.Add(label3);
			this.colorEditingPanel.Controls.Add(this.colorRed);
			this.colorEditingPanel.Controls.Add(label2);
			this.colorEditingPanel.Enabled = false;
			this.colorEditingPanel.Location = new System.Drawing.Point(0, 25);
			this.colorEditingPanel.Margin = new System.Windows.Forms.Padding(0);
			this.colorEditingPanel.Name = "colorEditingPanel";
			this.colorEditingPanel.Size = new System.Drawing.Size(106, 78);
			this.colorEditingPanel.TabIndex = 5;
			// 
			// colorBlue
			// 
			this.colorBlue.Location = new System.Drawing.Point(50, 55);
			this.colorBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.colorBlue.Name = "colorBlue";
			this.colorBlue.Size = new System.Drawing.Size(53, 20);
			this.colorBlue.TabIndex = 5;
			this.colorBlue.ValueChanged += new System.EventHandler(this.color_ValueChanged);
			// 
			// colorGreen
			// 
			this.colorGreen.Location = new System.Drawing.Point(50, 29);
			this.colorGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.colorGreen.Name = "colorGreen";
			this.colorGreen.Size = new System.Drawing.Size(53, 20);
			this.colorGreen.TabIndex = 3;
			this.colorGreen.ValueChanged += new System.EventHandler(this.color_ValueChanged);
			// 
			// colorRed
			// 
			this.colorRed.Location = new System.Drawing.Point(50, 3);
			this.colorRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.colorRed.Name = "colorRed";
			this.colorRed.Size = new System.Drawing.Size(53, 20);
			this.colorRed.TabIndex = 1;
			this.colorRed.ValueChanged += new System.EventHandler(this.color_ValueChanged);
			// 
			// paletteToolStrip
			// 
			this.tableLayoutPanel8.SetColumnSpan(this.paletteToolStrip, 2);
			this.paletteToolStrip.Enabled = false;
			this.paletteToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.paletteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importPaletteToolStripButton,
            this.enableDraggingPaletteButton});
			this.paletteToolStrip.Location = new System.Drawing.Point(0, 0);
			this.paletteToolStrip.Name = "paletteToolStrip";
			this.paletteToolStrip.Size = new System.Drawing.Size(644, 25);
			this.paletteToolStrip.TabIndex = 6;
			this.paletteToolStrip.Text = "toolStrip1";
			// 
			// importPaletteToolStripButton
			// 
			this.importPaletteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.importPaletteToolStripButton.Name = "importPaletteToolStripButton";
			this.importPaletteToolStripButton.Size = new System.Drawing.Size(56, 22);
			this.importPaletteToolStripButton.Text = "&Import...";
			this.importPaletteToolStripButton.Visible = false;
			this.importPaletteToolStripButton.Click += new System.EventHandler(this.importPaletteToolStripButton_Click);
			// 
			// enableDraggingPaletteButton
			// 
			this.enableDraggingPaletteButton.Checked = true;
			this.enableDraggingPaletteButton.CheckOnClick = true;
			this.enableDraggingPaletteButton.CheckState = System.Windows.Forms.CheckState.Checked;
			this.enableDraggingPaletteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.enableDraggingPaletteButton.Name = "enableDraggingPaletteButton";
			this.enableDraggingPaletteButton.Size = new System.Drawing.Size(98, 22);
			this.enableDraggingPaletteButton.Text = "Enable &Dragging";
			// 
			// tabPage15
			// 
			this.tabPage15.Controls.Add(this.soundEffectsGroup);
			this.tabPage15.Controls.Add(this.objectListGroup);
			this.tabPage15.Controls.Add(this.layerSettingsGroup);
			this.tabPage15.Controls.Add(this.titleCardGroup);
			this.tabPage15.Location = new System.Drawing.Point(4, 22);
			this.tabPage15.Name = "tabPage15";
			this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage15.Size = new System.Drawing.Size(650, 477);
			this.tabPage15.TabIndex = 5;
			this.tabPage15.Text = "Settings";
			this.tabPage15.UseVisualStyleBackColor = true;
			// 
			// soundEffectsGroup
			// 
			this.soundEffectsGroup.AutoSize = true;
			this.soundEffectsGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.soundEffectsGroup.Controls.Add(this.sfxBrowseButton);
			this.soundEffectsGroup.Controls.Add(this.sfxFileBox);
			this.soundEffectsGroup.Controls.Add(this.label24);
			this.soundEffectsGroup.Controls.Add(this.sfxNameBox);
			this.soundEffectsGroup.Controls.Add(this.label25);
			this.soundEffectsGroup.Controls.Add(this.sfxDeleteButton);
			this.soundEffectsGroup.Controls.Add(this.sfxAddButton);
			this.soundEffectsGroup.Controls.Add(this.sfxListBox);
			this.soundEffectsGroup.Enabled = false;
			this.soundEffectsGroup.Location = new System.Drawing.Point(203, 246);
			this.soundEffectsGroup.Name = "soundEffectsGroup";
			this.soundEffectsGroup.Size = new System.Drawing.Size(367, 214);
			this.soundEffectsGroup.TabIndex = 6;
			this.soundEffectsGroup.TabStop = false;
			this.soundEffectsGroup.Text = "Sound Effects";
			// 
			// sfxBrowseButton
			// 
			this.sfxBrowseButton.Enabled = false;
			this.sfxBrowseButton.Location = new System.Drawing.Point(211, 100);
			this.sfxBrowseButton.Name = "sfxBrowseButton";
			this.sfxBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.sfxBrowseButton.TabIndex = 16;
			this.sfxBrowseButton.Text = "Browse...";
			this.sfxBrowseButton.UseVisualStyleBackColor = true;
			this.sfxBrowseButton.Click += new System.EventHandler(this.sfxBrowseButton_Click);
			// 
			// sfxFileBox
			// 
			this.sfxFileBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.sfxFileBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.sfxFileBox.Enabled = false;
			this.sfxFileBox.Location = new System.Drawing.Point(211, 74);
			this.sfxFileBox.MaxLength = 255;
			this.sfxFileBox.Name = "sfxFileBox";
			this.sfxFileBox.Size = new System.Drawing.Size(150, 20);
			this.sfxFileBox.TabIndex = 15;
			this.sfxFileBox.TextChanged += new System.EventHandler(this.sfxFileBox_TextChanged);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(211, 58);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(26, 13);
			this.label24.TabIndex = 14;
			this.label24.Text = "File:";
			// 
			// sfxNameBox
			// 
			this.sfxNameBox.Enabled = false;
			this.sfxNameBox.Location = new System.Drawing.Point(211, 35);
			this.sfxNameBox.MaxLength = 255;
			this.sfxNameBox.Name = "sfxNameBox";
			this.sfxNameBox.Size = new System.Drawing.Size(150, 20);
			this.sfxNameBox.TabIndex = 13;
			this.sfxNameBox.TextChanged += new System.EventHandler(this.sfxNameBox_TextChanged);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(211, 19);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(38, 13);
			this.label25.TabIndex = 12;
			this.label25.Text = "Name:";
			// 
			// sfxDeleteButton
			// 
			this.sfxDeleteButton.Enabled = false;
			this.sfxDeleteButton.Location = new System.Drawing.Point(87, 172);
			this.sfxDeleteButton.Name = "sfxDeleteButton";
			this.sfxDeleteButton.Size = new System.Drawing.Size(75, 23);
			this.sfxDeleteButton.TabIndex = 11;
			this.sfxDeleteButton.Text = "Delete";
			this.sfxDeleteButton.UseVisualStyleBackColor = true;
			this.sfxDeleteButton.Click += new System.EventHandler(this.sfxDeleteButton_Click);
			// 
			// sfxAddButton
			// 
			this.sfxAddButton.Location = new System.Drawing.Point(6, 172);
			this.sfxAddButton.Name = "sfxAddButton";
			this.sfxAddButton.Size = new System.Drawing.Size(75, 23);
			this.sfxAddButton.TabIndex = 10;
			this.sfxAddButton.Text = "Add";
			this.sfxAddButton.UseVisualStyleBackColor = true;
			this.sfxAddButton.Click += new System.EventHandler(this.sfxAddButton_Click);
			// 
			// sfxListBox
			// 
			this.sfxListBox.FormattingEnabled = true;
			this.sfxListBox.Location = new System.Drawing.Point(6, 19);
			this.sfxListBox.Name = "sfxListBox";
			this.sfxListBox.Size = new System.Drawing.Size(199, 147);
			this.sfxListBox.TabIndex = 9;
			this.sfxListBox.SelectedIndexChanged += new System.EventHandler(this.sfxListBox_SelectedIndexChanged);
			// 
			// objectListGroup
			// 
			this.objectListGroup.AutoSize = true;
			this.objectListGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.objectListGroup.Controls.Add(this.browseScriptButton);
			this.objectListGroup.Controls.Add(this.objectScriptBox);
			this.objectListGroup.Controls.Add(this.label23);
			this.objectListGroup.Controls.Add(this.objectNameBox);
			this.objectListGroup.Controls.Add(this.label22);
			this.objectListGroup.Controls.Add(this.objectDeleteButton);
			this.objectListGroup.Controls.Add(this.objectAddButton);
			this.objectListGroup.Controls.Add(this.objectListBox);
			this.objectListGroup.Controls.Add(this.loadGlobalObjects);
			this.objectListGroup.Enabled = false;
			this.objectListGroup.Location = new System.Drawing.Point(203, 6);
			this.objectListGroup.Name = "objectListGroup";
			this.objectListGroup.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.objectListGroup.Size = new System.Drawing.Size(367, 234);
			this.objectListGroup.TabIndex = 5;
			this.objectListGroup.TabStop = false;
			this.objectListGroup.Text = "Object List";
			// 
			// browseScriptButton
			// 
			this.browseScriptButton.Enabled = false;
			this.browseScriptButton.Location = new System.Drawing.Point(211, 123);
			this.browseScriptButton.Name = "browseScriptButton";
			this.browseScriptButton.Size = new System.Drawing.Size(75, 23);
			this.browseScriptButton.TabIndex = 8;
			this.browseScriptButton.Text = "Browse...";
			this.browseScriptButton.UseVisualStyleBackColor = true;
			this.browseScriptButton.Click += new System.EventHandler(this.browseScriptButton_Click);
			// 
			// objectScriptBox
			// 
			this.objectScriptBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.objectScriptBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.objectScriptBox.Enabled = false;
			this.objectScriptBox.Location = new System.Drawing.Point(211, 97);
			this.objectScriptBox.MaxLength = 255;
			this.objectScriptBox.Name = "objectScriptBox";
			this.objectScriptBox.Size = new System.Drawing.Size(150, 20);
			this.objectScriptBox.TabIndex = 7;
			this.objectScriptBox.TextChanged += new System.EventHandler(this.objectScriptBox_TextChanged);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(211, 81);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(37, 13);
			this.label23.TabIndex = 6;
			this.label23.Text = "Script:";
			// 
			// objectNameBox
			// 
			this.objectNameBox.Enabled = false;
			this.objectNameBox.Location = new System.Drawing.Point(211, 58);
			this.objectNameBox.MaxLength = 255;
			this.objectNameBox.Name = "objectNameBox";
			this.objectNameBox.Size = new System.Drawing.Size(150, 20);
			this.objectNameBox.TabIndex = 5;
			this.objectNameBox.TextChanged += new System.EventHandler(this.objectNameBox_TextChanged);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(211, 42);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(38, 13);
			this.label22.TabIndex = 4;
			this.label22.Text = "Name:";
			// 
			// objectDeleteButton
			// 
			this.objectDeleteButton.Enabled = false;
			this.objectDeleteButton.Location = new System.Drawing.Point(87, 195);
			this.objectDeleteButton.Name = "objectDeleteButton";
			this.objectDeleteButton.Size = new System.Drawing.Size(75, 23);
			this.objectDeleteButton.TabIndex = 3;
			this.objectDeleteButton.Text = "Delete";
			this.objectDeleteButton.UseVisualStyleBackColor = true;
			this.objectDeleteButton.Click += new System.EventHandler(this.objectDeleteButton_Click);
			// 
			// objectAddButton
			// 
			this.objectAddButton.Location = new System.Drawing.Point(6, 195);
			this.objectAddButton.Name = "objectAddButton";
			this.objectAddButton.Size = new System.Drawing.Size(75, 23);
			this.objectAddButton.TabIndex = 2;
			this.objectAddButton.Text = "Add";
			this.objectAddButton.UseVisualStyleBackColor = true;
			this.objectAddButton.Click += new System.EventHandler(this.objectAddButton_Click);
			// 
			// objectListBox
			// 
			this.objectListBox.FormattingEnabled = true;
			this.objectListBox.Location = new System.Drawing.Point(6, 42);
			this.objectListBox.Name = "objectListBox";
			this.objectListBox.Size = new System.Drawing.Size(199, 147);
			this.objectListBox.TabIndex = 1;
			this.objectListBox.SelectedIndexChanged += new System.EventHandler(this.objectListBox_SelectedIndexChanged);
			// 
			// loadGlobalObjects
			// 
			this.loadGlobalObjects.AutoSize = true;
			this.loadGlobalObjects.Location = new System.Drawing.Point(6, 19);
			this.loadGlobalObjects.Name = "loadGlobalObjects";
			this.loadGlobalObjects.Size = new System.Drawing.Size(122, 17);
			this.loadGlobalObjects.TabIndex = 0;
			this.loadGlobalObjects.Text = "Load Global Objects";
			this.loadGlobalObjects.UseVisualStyleBackColor = true;
			this.loadGlobalObjects.CheckedChanged += new System.EventHandler(this.loadGlobalObjects_CheckedChanged);
			// 
			// layerSettingsGroup
			// 
			this.layerSettingsGroup.AutoSize = true;
			this.layerSettingsGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.layerSettingsGroup.Controls.Add(this.layer3Box);
			this.layerSettingsGroup.Controls.Add(this.label21);
			this.layerSettingsGroup.Controls.Add(this.layer2Box);
			this.layerSettingsGroup.Controls.Add(this.label20);
			this.layerSettingsGroup.Controls.Add(this.layer1Box);
			this.layerSettingsGroup.Controls.Add(this.label19);
			this.layerSettingsGroup.Controls.Add(this.layer0Box);
			this.layerSettingsGroup.Controls.Add(this.label18);
			this.layerSettingsGroup.Controls.Add(this.midpointBox);
			this.layerSettingsGroup.Controls.Add(this.label17);
			this.layerSettingsGroup.Enabled = false;
			this.layerSettingsGroup.Location = new System.Drawing.Point(8, 93);
			this.layerSettingsGroup.Name = "layerSettingsGroup";
			this.layerSettingsGroup.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.layerSettingsGroup.Size = new System.Drawing.Size(189, 164);
			this.layerSettingsGroup.TabIndex = 4;
			this.layerSettingsGroup.TabStop = false;
			this.layerSettingsGroup.Text = "Layer Settings";
			// 
			// layer3Box
			// 
			this.layer3Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.layer3Box.FormattingEnabled = true;
			this.layer3Box.Items.AddRange(new object[] {
            "Foreground",
            "Background 1",
            "Background 2",
            "Background 3",
            "Background 4",
            "Background 5",
            "Background 6",
            "Background 7",
            "Background 8",
            "None"});
			this.layer3Box.Location = new System.Drawing.Point(62, 127);
			this.layer3Box.Name = "layer3Box";
			this.layer3Box.Size = new System.Drawing.Size(121, 21);
			this.layer3Box.TabIndex = 9;
			this.layer3Box.SelectedIndexChanged += new System.EventHandler(this.layer3Box_SelectedIndexChanged);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(6, 130);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(45, 13);
			this.label21.TabIndex = 8;
			this.label21.Text = "Layer 3:";
			// 
			// layer2Box
			// 
			this.layer2Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.layer2Box.FormattingEnabled = true;
			this.layer2Box.Items.AddRange(new object[] {
            "Foreground",
            "Background 1",
            "Background 2",
            "Background 3",
            "Background 4",
            "Background 5",
            "Background 6",
            "Background 7",
            "Background 8",
            "None"});
			this.layer2Box.Location = new System.Drawing.Point(62, 100);
			this.layer2Box.Name = "layer2Box";
			this.layer2Box.Size = new System.Drawing.Size(121, 21);
			this.layer2Box.TabIndex = 7;
			this.layer2Box.SelectedIndexChanged += new System.EventHandler(this.layer2Box_SelectedIndexChanged);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(6, 103);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(45, 13);
			this.label20.TabIndex = 6;
			this.label20.Text = "Layer 2:";
			// 
			// layer1Box
			// 
			this.layer1Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.layer1Box.FormattingEnabled = true;
			this.layer1Box.Items.AddRange(new object[] {
            "Foreground",
            "Background 1",
            "Background 2",
            "Background 3",
            "Background 4",
            "Background 5",
            "Background 6",
            "Background 7",
            "Background 8",
            "None"});
			this.layer1Box.Location = new System.Drawing.Point(62, 73);
			this.layer1Box.Name = "layer1Box";
			this.layer1Box.Size = new System.Drawing.Size(121, 21);
			this.layer1Box.TabIndex = 5;
			this.layer1Box.SelectedIndexChanged += new System.EventHandler(this.layer1Box_SelectedIndexChanged);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(6, 76);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(45, 13);
			this.label19.TabIndex = 4;
			this.label19.Text = "Layer 1:";
			// 
			// layer0Box
			// 
			this.layer0Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.layer0Box.FormattingEnabled = true;
			this.layer0Box.Items.AddRange(new object[] {
            "Foreground",
            "Background 1",
            "Background 2",
            "Background 3",
            "Background 4",
            "Background 5",
            "Background 6",
            "Background 7",
            "Background 8",
            "None"});
			this.layer0Box.Location = new System.Drawing.Point(62, 46);
			this.layer0Box.Name = "layer0Box";
			this.layer0Box.Size = new System.Drawing.Size(121, 21);
			this.layer0Box.TabIndex = 3;
			this.layer0Box.SelectedIndexChanged += new System.EventHandler(this.layer0Box_SelectedIndexChanged);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(6, 49);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(45, 13);
			this.label18.TabIndex = 2;
			this.label18.Text = "Layer 0:";
			// 
			// midpointBox
			// 
			this.midpointBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.midpointBox.FormattingEnabled = true;
			this.midpointBox.Items.AddRange(new object[] {
            "Before Layer 0",
            "After Layer 0",
            "After Layer 1",
            "After Layer 2",
            "After Layer 3"});
			this.midpointBox.Location = new System.Drawing.Point(62, 19);
			this.midpointBox.Name = "midpointBox";
			this.midpointBox.Size = new System.Drawing.Size(121, 21);
			this.midpointBox.TabIndex = 1;
			this.midpointBox.SelectedIndexChanged += new System.EventHandler(this.midpointBox_SelectedIndexChanged);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(6, 22);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(50, 13);
			this.label17.TabIndex = 0;
			this.label17.Text = "Midpoint:";
			// 
			// titleCardGroup
			// 
			this.titleCardGroup.AutoSize = true;
			this.titleCardGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.titleCardGroup.Controls.Add(this.levelNameBox);
			this.titleCardGroup.Controls.Add(this.levelNameBox2);
			this.titleCardGroup.Enabled = false;
			this.titleCardGroup.Location = new System.Drawing.Point(8, 6);
			this.titleCardGroup.Name = "titleCardGroup";
			this.titleCardGroup.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.titleCardGroup.Size = new System.Drawing.Size(162, 81);
			this.titleCardGroup.TabIndex = 3;
			this.titleCardGroup.TabStop = false;
			this.titleCardGroup.Text = "Title Card";
			// 
			// levelNameBox
			// 
			this.levelNameBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.levelNameBox.Location = new System.Drawing.Point(6, 19);
			this.levelNameBox.MaxLength = 255;
			this.levelNameBox.Name = "levelNameBox";
			this.levelNameBox.Size = new System.Drawing.Size(150, 20);
			this.levelNameBox.TabIndex = 1;
			this.levelNameBox.TextChanged += new System.EventHandler(this.levelNameBox_TextChanged);
			// 
			// levelNameBox2
			// 
			this.levelNameBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.levelNameBox2.Location = new System.Drawing.Point(6, 45);
			this.levelNameBox2.MaxLength = 255;
			this.levelNameBox2.Name = "levelNameBox2";
			this.levelNameBox2.Size = new System.Drawing.Size(150, 20);
			this.levelNameBox2.TabIndex = 2;
			this.levelNameBox2.TextChanged += new System.EventHandler(this.levelNameBox2_TextChanged);
			// 
			// tileContextMenuStrip
			// 
			this.tileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutTilesToolStripMenuItem,
            this.copyTilesToolStripMenuItem,
            this.deepCopyToolStripMenuItem,
            this.pasteOverToolStripMenuItem,
            this.importOverToolStripMenuItem,
            this.exportTileToolStripMenuItem,
            this.duplicateTilesToolStripMenuItem,
            this.deleteTilesToolStripMenuItem});
			this.tileContextMenuStrip.Name = "contextMenuStrip1";
			this.tileContextMenuStrip.Size = new System.Drawing.Size(148, 180);
			// 
			// cutTilesToolStripMenuItem
			// 
			this.cutTilesToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.cut;
			this.cutTilesToolStripMenuItem.Name = "cutTilesToolStripMenuItem";
			this.cutTilesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.cutTilesToolStripMenuItem.Text = "Cu&t";
			this.cutTilesToolStripMenuItem.Click += new System.EventHandler(this.cutTilesToolStripMenuItem_Click);
			// 
			// copyTilesToolStripMenuItem
			// 
			this.copyTilesToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.copy;
			this.copyTilesToolStripMenuItem.Name = "copyTilesToolStripMenuItem";
			this.copyTilesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.copyTilesToolStripMenuItem.Text = "&Copy";
			this.copyTilesToolStripMenuItem.Click += new System.EventHandler(this.copyTilesToolStripMenuItem_Click);
			// 
			// deepCopyToolStripMenuItem
			// 
			this.deepCopyToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.copy;
			this.deepCopyToolStripMenuItem.Name = "deepCopyToolStripMenuItem";
			this.deepCopyToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.deepCopyToolStripMenuItem.Text = "Deep Co&py";
			this.deepCopyToolStripMenuItem.Click += new System.EventHandler(this.deepCopyToolStripMenuItem_Click);
			// 
			// pasteOverToolStripMenuItem
			// 
			this.pasteOverToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.paste;
			this.pasteOverToolStripMenuItem.Name = "pasteOverToolStripMenuItem";
			this.pasteOverToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.pasteOverToolStripMenuItem.Text = "Paste &Over";
			this.pasteOverToolStripMenuItem.Click += new System.EventHandler(this.pasteOverToolStripMenuItem_Click);
			// 
			// importOverToolStripMenuItem
			// 
			this.importOverToolStripMenuItem.Name = "importOverToolStripMenuItem";
			this.importOverToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.importOverToolStripMenuItem.Text = "&Import Over...";
			this.importOverToolStripMenuItem.Click += new System.EventHandler(this.importOverToolStripMenuItem_Click);
			// 
			// exportTileToolStripMenuItem
			// 
			this.exportTileToolStripMenuItem.Name = "exportTileToolStripMenuItem";
			this.exportTileToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.exportTileToolStripMenuItem.Text = "E&xport...";
			this.exportTileToolStripMenuItem.Click += new System.EventHandler(this.ExportTileToolStripMenuItem_Click);
			// 
			// duplicateTilesToolStripMenuItem
			// 
			this.duplicateTilesToolStripMenuItem.Name = "duplicateTilesToolStripMenuItem";
			this.duplicateTilesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.duplicateTilesToolStripMenuItem.Text = "D&uplicate";
			this.duplicateTilesToolStripMenuItem.Click += new System.EventHandler(this.duplicateTilesToolStripMenuItem_Click);
			// 
			// deleteTilesToolStripMenuItem
			// 
			this.deleteTilesToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.delete;
			this.deleteTilesToolStripMenuItem.Name = "deleteTilesToolStripMenuItem";
			this.deleteTilesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.deleteTilesToolStripMenuItem.Text = "C&lear";
			this.deleteTilesToolStripMenuItem.Click += new System.EventHandler(this.deleteTilesToolStripMenuItem_Click);
			// 
			// layoutContextMenuStrip
			// 
			this.layoutContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem1,
            this.copyToolStripMenuItem1,
            this.pasteOnceToolStripMenuItem,
            this.pasteRepeatingToolStripMenuItem,
            this.importToolStripMenuItem2,
            this.exportLayoutSectionToolStripMenuItem,
            this.toolStripSeparator11,
            this.deleteToolStripMenuItem1,
            this.fillToolStripMenuItem,
            this.toolStripSeparator12,
            this.saveSectionToolStripMenuItem,
            this.pasteSectionOnceToolStripMenuItem,
            this.pasteSectionRepeatingToolStripMenuItem,
            this.toolStripSeparator7,
            this.insertLayoutToolStripMenuItem,
            this.deleteLayoutToolStripMenuItem});
			this.layoutContextMenuStrip.Name = "layoutContextMenuStrip";
			this.layoutContextMenuStrip.Size = new System.Drawing.Size(203, 308);
			// 
			// cutToolStripMenuItem1
			// 
			this.cutToolStripMenuItem1.Image = global::SonicRetro.SonLVL.Properties.Resources.cut;
			this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
			this.cutToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
			this.cutToolStripMenuItem1.Text = "Cu&t";
			this.cutToolStripMenuItem1.Click += new System.EventHandler(this.cutToolStripMenuItem1_Click);
			// 
			// copyToolStripMenuItem1
			// 
			this.copyToolStripMenuItem1.Image = global::SonicRetro.SonLVL.Properties.Resources.copy;
			this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
			this.copyToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
			this.copyToolStripMenuItem1.Text = "&Copy";
			this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
			// 
			// pasteOnceToolStripMenuItem
			// 
			this.pasteOnceToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.paste;
			this.pasteOnceToolStripMenuItem.Name = "pasteOnceToolStripMenuItem";
			this.pasteOnceToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.pasteOnceToolStripMenuItem.Text = "&Paste Once";
			this.pasteOnceToolStripMenuItem.Click += new System.EventHandler(this.pasteOnceToolStripMenuItem_Click);
			// 
			// pasteRepeatingToolStripMenuItem
			// 
			this.pasteRepeatingToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.paste;
			this.pasteRepeatingToolStripMenuItem.Name = "pasteRepeatingToolStripMenuItem";
			this.pasteRepeatingToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.pasteRepeatingToolStripMenuItem.Text = "Paste &Repeating";
			this.pasteRepeatingToolStripMenuItem.Click += new System.EventHandler(this.pasteRepeatingToolStripMenuItem_Click);
			// 
			// importToolStripMenuItem2
			// 
			this.importToolStripMenuItem2.Name = "importToolStripMenuItem2";
			this.importToolStripMenuItem2.Size = new System.Drawing.Size(202, 22);
			this.importToolStripMenuItem2.Text = "I&mport...";
			this.importToolStripMenuItem2.Click += new System.EventHandler(this.importToolStripMenuItem2_Click);
			// 
			// exportLayoutSectionToolStripMenuItem
			// 
			this.exportLayoutSectionToolStripMenuItem.Name = "exportLayoutSectionToolStripMenuItem";
			this.exportLayoutSectionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.exportLayoutSectionToolStripMenuItem.Text = "E&xport...";
			this.exportLayoutSectionToolStripMenuItem.Click += new System.EventHandler(this.ExportLayoutSectionToolStripMenuItem_Click);
			// 
			// toolStripSeparator11
			// 
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new System.Drawing.Size(199, 6);
			// 
			// deleteToolStripMenuItem1
			// 
			this.deleteToolStripMenuItem1.Image = global::SonicRetro.SonLVL.Properties.Resources.delete;
			this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
			this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
			this.deleteToolStripMenuItem1.Text = "C&lear";
			this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
			// 
			// fillToolStripMenuItem
			// 
			this.fillToolStripMenuItem.Name = "fillToolStripMenuItem";
			this.fillToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.fillToolStripMenuItem.Text = "&Fill With Selected Chunk";
			this.fillToolStripMenuItem.Click += new System.EventHandler(this.fillToolStripMenuItem_Click);
			// 
			// toolStripSeparator12
			// 
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new System.Drawing.Size(199, 6);
			// 
			// saveSectionToolStripMenuItem
			// 
			this.saveSectionToolStripMenuItem.Name = "saveSectionToolStripMenuItem";
			this.saveSectionToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.saveSectionToolStripMenuItem.Text = "&Save Section...";
			this.saveSectionToolStripMenuItem.Click += new System.EventHandler(this.saveSectionToolStripMenuItem_Click);
			// 
			// pasteSectionOnceToolStripMenuItem
			// 
			this.pasteSectionOnceToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.paste;
			this.pasteSectionOnceToolStripMenuItem.Name = "pasteSectionOnceToolStripMenuItem";
			this.pasteSectionOnceToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.pasteSectionOnceToolStripMenuItem.Text = "P&aste Section Once";
			this.pasteSectionOnceToolStripMenuItem.Click += new System.EventHandler(this.pasteSectionOnceToolStripMenuItem_Click);
			// 
			// pasteSectionRepeatingToolStripMenuItem
			// 
			this.pasteSectionRepeatingToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.paste;
			this.pasteSectionRepeatingToolStripMenuItem.Name = "pasteSectionRepeatingToolStripMenuItem";
			this.pasteSectionRepeatingToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.pasteSectionRepeatingToolStripMenuItem.Text = "Paste Section R&epeating";
			this.pasteSectionRepeatingToolStripMenuItem.Click += new System.EventHandler(this.pasteSectionRepeatingToolStripMenuItem_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(199, 6);
			// 
			// insertLayoutToolStripMenuItem
			// 
			this.insertLayoutToolStripMenuItem.Name = "insertLayoutToolStripMenuItem";
			this.insertLayoutToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.insertLayoutToolStripMenuItem.Text = "&Insert...";
			this.insertLayoutToolStripMenuItem.Click += new System.EventHandler(this.insertLayoutToolStripMenuItem_Click);
			// 
			// deleteLayoutToolStripMenuItem
			// 
			this.deleteLayoutToolStripMenuItem.Name = "deleteLayoutToolStripMenuItem";
			this.deleteLayoutToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.deleteLayoutToolStripMenuItem.Text = "&Delete...";
			this.deleteLayoutToolStripMenuItem.Click += new System.EventHandler(this.deleteLayoutToolStripMenuItem_Click);
			// 
			// chunkBlockContextMenuStrip
			// 
			this.chunkBlockContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipChunkBlocksHorizontallyToolStripMenuItem,
            this.flipChunkBlocksVerticallyToolStripMenuItem,
            this.copyChunkBlocksToolStripMenuItem,
            this.pasteChunkBlocksToolStripMenuItem,
            this.clearChunkBlocksToolStripMenuItem});
			this.chunkBlockContextMenuStrip.Name = "solidsContextMenuStrip";
			this.chunkBlockContextMenuStrip.Size = new System.Drawing.Size(161, 114);
			// 
			// flipChunkBlocksHorizontallyToolStripMenuItem
			// 
			this.flipChunkBlocksHorizontallyToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.fliph;
			this.flipChunkBlocksHorizontallyToolStripMenuItem.Name = "flipChunkBlocksHorizontallyToolStripMenuItem";
			this.flipChunkBlocksHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.flipChunkBlocksHorizontallyToolStripMenuItem.Text = "Flip &Horizontally";
			this.flipChunkBlocksHorizontallyToolStripMenuItem.Click += new System.EventHandler(this.flipChunkBlocksHorizontallyToolStripMenuItem_Click);
			// 
			// flipChunkBlocksVerticallyToolStripMenuItem
			// 
			this.flipChunkBlocksVerticallyToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.flipv;
			this.flipChunkBlocksVerticallyToolStripMenuItem.Name = "flipChunkBlocksVerticallyToolStripMenuItem";
			this.flipChunkBlocksVerticallyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.flipChunkBlocksVerticallyToolStripMenuItem.Text = "Flip &Vertically";
			this.flipChunkBlocksVerticallyToolStripMenuItem.Click += new System.EventHandler(this.flipChunkBlocksVerticallyToolStripMenuItem_Click);
			// 
			// copyChunkBlocksToolStripMenuItem
			// 
			this.copyChunkBlocksToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.copy;
			this.copyChunkBlocksToolStripMenuItem.Name = "copyChunkBlocksToolStripMenuItem";
			this.copyChunkBlocksToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.copyChunkBlocksToolStripMenuItem.Text = "&Copy";
			this.copyChunkBlocksToolStripMenuItem.Click += new System.EventHandler(this.copyChunkBlocksToolStripMenuItem_Click);
			// 
			// pasteChunkBlocksToolStripMenuItem
			// 
			this.pasteChunkBlocksToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.paste;
			this.pasteChunkBlocksToolStripMenuItem.Name = "pasteChunkBlocksToolStripMenuItem";
			this.pasteChunkBlocksToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.pasteChunkBlocksToolStripMenuItem.Text = "&Paste";
			this.pasteChunkBlocksToolStripMenuItem.Click += new System.EventHandler(this.pasteChunkBlocksToolStripMenuItem_Click);
			// 
			// clearChunkBlocksToolStripMenuItem
			// 
			this.clearChunkBlocksToolStripMenuItem.Image = global::SonicRetro.SonLVL.Properties.Resources.delete;
			this.clearChunkBlocksToolStripMenuItem.Name = "clearChunkBlocksToolStripMenuItem";
			this.clearChunkBlocksToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.clearChunkBlocksToolStripMenuItem.Text = "&Clear";
			this.clearChunkBlocksToolStripMenuItem.Click += new System.EventHandler(this.clearChunkBlocksToolStripMenuItem_Click);
			// 
			// importProgressControl1
			// 
			this.importProgressControl1.AutoSize = true;
			this.importProgressControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.importProgressControl1.CurrentProgress = 0;
			this.importProgressControl1.Location = new System.Drawing.Point(0, 0);
			this.importProgressControl1.MaximumProgress = 100;
			this.importProgressControl1.Name = "importProgressControl1";
			this.importProgressControl1.Size = new System.Drawing.Size(137, 42);
			this.importProgressControl1.TabIndex = 5;
			this.importProgressControl1.UseWaitCursor = true;
			this.importProgressControl1.Visible = false;
			this.importProgressControl1.SizeChanged += new System.EventHandler(this.importProgressControl1_SizeChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 527);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.mainMenuStrip);
			this.Controls.Add(this.importProgressControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.mainMenuStrip;
			this.Name = "MainForm";
			this.Text = "SonLVL-RSDK";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			chunkListToolStrip.ResumeLayout(false);
			chunkListToolStrip.PerformLayout();
			tileListToolStrip.ResumeLayout(false);
			tileListToolStrip.PerformLayout();
			tabControl2.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.tabPage9.ResumeLayout(false);
			this.layoutSectionSplitContainer.Panel1.ResumeLayout(false);
			this.layoutSectionSplitContainer.Panel1.PerformLayout();
			this.layoutSectionSplitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layoutSectionSplitContainer)).EndInit();
			this.layoutSectionSplitContainer.ResumeLayout(false);
			layoutSectionListToolStrip.ResumeLayout(false);
			layoutSectionListToolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.layoutSectionPreview)).EndInit();
			panel11.ResumeLayout(false);
			panel11.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TileID)).EndInit();
			tableLayoutPanel5.ResumeLayout(false);
			tableLayoutPanel5.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ChunkID)).EndInit();
			panel9.ResumeLayout(false);
			panel9.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.colFlags)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ceilingAngle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rightAngle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leftAngle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.floorAngle)).EndInit();
			tableLayoutPanel6.ResumeLayout(false);
			tableLayoutPanel6.PerformLayout();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.objectContextMenuStrip.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			this.splitContainer4.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
			this.splitContainer4.ResumeLayout(false);
			this.objToolStrip.ResumeLayout(false);
			this.objToolStrip.PerformLayout();
			this.tabControl5.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.fgToolStrip.ResumeLayout(false);
			this.fgToolStrip.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel1.PerformLayout();
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.bgToolStrip.ResumeLayout(false);
			this.bgToolStrip.PerformLayout();
			this.tabControl3.ResumeLayout(false);
			this.tabPage13.ResumeLayout(false);
			this.tabPage13.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.scrollFrame)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scrollCamY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scrollCamX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scrollTargetFPS)).EndInit();
			this.scrollEditPanel.ResumeLayout(false);
			this.scrollEditPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.scrollOffset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scrollScrollSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.scrollParallaxFactor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layerScrollSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layerParallaxFactor)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tabControl4.ResumeLayout(false);
			this.tabPage12.ResumeLayout(false);
			this.tabPage12.PerformLayout();
			this.tabPage14.ResumeLayout(false);
			this.tabPage14.PerformLayout();
			this.tabPage6.ResumeLayout(false);
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel8.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.colorEditingPanel.ResumeLayout(false);
			this.colorEditingPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.colorBlue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colorGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.colorRed)).EndInit();
			this.paletteToolStrip.ResumeLayout(false);
			this.paletteToolStrip.PerformLayout();
			this.tabPage15.ResumeLayout(false);
			this.tabPage15.PerformLayout();
			this.soundEffectsGroup.ResumeLayout(false);
			this.soundEffectsGroup.PerformLayout();
			this.objectListGroup.ResumeLayout(false);
			this.objectListGroup.PerformLayout();
			this.layerSettingsGroup.ResumeLayout(false);
			this.layerSettingsGroup.PerformLayout();
			this.titleCardGroup.ResumeLayout(false);
			this.titleCardGroup.PerformLayout();
			this.tileContextMenuStrip.ResumeLayout(false);
			this.layoutContextMenuStrip.ResumeLayout(false);
			this.chunkBlockContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeLevelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.ComponentModel.BackgroundWorker backgroundLevelLoader;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chunksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem foregroundToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backgroundToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem transparentBackgroundToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem includeobjectsWithFGToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem objectsAboveHighPlaneToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip objectContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addObjectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem paletteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		internal System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem collisionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem path1ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem path2ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addGroupOfObjectsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem buildAndRunToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hUDToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem layersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.PropertyGrid ObjectProperties;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private SonicRetro.SonLVL.API.TileList ChunkSelector;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.ToolStripMenuItem recentProjectsToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Label ChunkCount;
		private System.Windows.Forms.NumericUpDown ChunkID;
		private ChunkBlockEditor chunkBlockEditor;
		private SonicRetro.SonLVL.API.TileList TileSelector;
		private System.Windows.Forms.Button rotateTileRightButton;
		private System.Windows.Forms.Label TileCount;
		private System.Windows.Forms.NumericUpDown TileID;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel PalettePanel;
		private System.Windows.Forms.NumericUpDown floorAngle;
		private System.Windows.Forms.ContextMenuStrip tileContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem cutTilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyTilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteTilesToolStripMenuItem;
		private System.Windows.Forms.Panel panel10;
		private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem enableGridToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewReadmeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem selectAllObjectsToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip layoutContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem pasteOnceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
		private System.Windows.Forms.ToolStrip bgToolStrip;
		private System.Windows.Forms.ToolStripMenuItem resizeLevelToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem anglesToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.ListView objectTypeList;
		private System.Windows.Forms.ImageList objectTypeImages;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripMenuItem insertLayoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteLayoutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem includeObjectsWithForegroundSelectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteRepeatingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fillToolStripMenuItem;
		private System.Windows.Forms.ToolStrip objToolStrip;
		private System.Windows.Forms.ToolStripButton alignGroundToolStripButton;
		private System.Windows.Forms.ToolStripButton alignLeftWallToolStripButton;
		private System.Windows.Forms.ToolStripButton alignRightWallToolStripButton;
		private System.Windows.Forms.ToolStripButton alignCeilingToolStripButton;
		private System.Windows.Forms.ToolStripButton alignLeftsToolStripButton;
		private System.Windows.Forms.ToolStripButton alignCentersToolStripButton;
		private System.Windows.Forms.ToolStripButton alignRightsToolStripButton;
		private System.Windows.Forms.ToolStripButton alignTopsToolStripButton;
		private System.Windows.Forms.ToolStripButton alignMiddlesToolStripButton;
		private System.Windows.Forms.ToolStripButton alignBottomsToolStripButton;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findPreviousToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem useHexadecimalIndexesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem solidityMapsToolStripMenuItem;
		private System.Windows.Forms.Button flipChunkHButton;
		private System.Windows.Forms.Button flipChunkVButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.Panel colorEditingPanel;
		private System.Windows.Forms.NumericUpDown colorBlue;
		private System.Windows.Forms.NumericUpDown colorGreen;
		private System.Windows.Forms.NumericUpDown colorRed;
		private System.Windows.Forms.ToolStripDropDownButton objGridSizeDropDownButton;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem7;
		private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem6;
		private System.Windows.Forms.ToolStripButton remapChunksButton;
		private System.Windows.Forms.ToolStripButton remapTilesButton;
		private System.Windows.Forms.TabPage tabPage8;
		private System.Windows.Forms.SplitContainer layoutSectionSplitContainer;
		private System.Windows.Forms.PictureBox layoutSectionPreview;
		private System.Windows.Forms.ListBox layoutSectionListBox;
		private System.Windows.Forms.TabControl tabControl3;
		private System.Windows.Forms.TabPage tabPage10;
		private System.Windows.Forms.TabPage tabPage11;
		private System.Windows.Forms.TabPage tabPage9;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
		private System.Windows.Forms.ToolStripMenuItem saveSectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteSectionOnceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteSectionRepeatingToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton enableDraggingChunksButton;
		private System.Windows.Forms.ToolStripButton enableDraggingTilesButton;
		private System.Windows.Forms.ToolStripMenuItem deepCopyToolStripMenuItem;
		private System.Windows.Forms.Button flipTileVButton;
		private System.Windows.Forms.Button flipTileHButton;
		private System.Windows.Forms.CheckBox showBlockBehindCollisionCheckBox;
		private System.Windows.Forms.ToolStripMenuItem pasteOverToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pNGToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem yYCHRToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton importToolStripButton;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem2;
		private System.Windows.Forms.ToolStripButton importChunksToolStripButton;
		private System.Windows.Forms.ToolStripButton importTilesToolStripButton;
		private System.Windows.Forms.ToolStripMenuItem switchMouseButtonsInChunkAndBlockEditorsToolStripMenuItem;
		private System.Windows.Forms.Label chunkCtrlLabel;
		private System.Windows.Forms.ToolStripMenuItem exportArtcollisionpriorityToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem jASCPALToolStripMenuItem;
		private ImportProgressControl importProgressControl1;
		private System.Windows.Forms.ToolStripButton deleteUnusedTilesToolStripButton;
		private System.Windows.Forms.ToolStripButton deleteUnusedChunksToolStripButton;
		private System.Windows.Forms.ToolStripButton clearBackgroundToolStripButton;
		private System.Windows.Forms.Button calculateAngleButton;
		private System.Windows.Forms.ToolStripMenuItem duplicateTilesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem usageCountsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
		private System.Windows.Forms.ToolStripButton replaceBackgroundToolStripButton;
		private System.Windows.Forms.ToolStripButton replaceChunkBlocksToolStripButton;
		private System.Windows.Forms.ToolStripButton removeDuplicateChunksToolStripButton;
		private System.Windows.Forms.ToolStripButton removeDuplicateTilesToolStripButton;
		private System.Windows.Forms.ToolStripButton drawChunkToolStripButton;
		private System.Windows.Forms.ToolStripButton drawTileToolStripButton;
		private System.Windows.Forms.ToolStripMenuItem importOverToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl4;
		private System.Windows.Forms.TabPage tabPage12;
		private System.Windows.Forms.TabPage tabPage14;
		private API.KeyboardPanel ChunkPicture;
		private System.Windows.Forms.Panel TilePicture;
		private System.Windows.Forms.Panel ColPicture;
		private ScrollingPanel objectPanel;
		private ScrollingPanel foregroundPanel;
		private System.Windows.Forms.ToolStrip fgToolStrip;
		private System.Windows.Forms.ToolStripButton replaceForegroundToolStripButton;
		private System.Windows.Forms.ToolStripButton clearForegroundToolStripButton;
		private ScrollingPanel backgroundPanel;
		private System.Windows.Forms.ToolStrip paletteToolStrip;
		private System.Windows.Forms.ToolStripButton importPaletteToolStripButton;
		private System.Windows.Forms.ContextMenuStrip chunkBlockContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem copyChunkBlocksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteChunkBlocksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearChunkBlocksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flipChunkBlocksHorizontallyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flipChunkBlocksVerticallyToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton enableDraggingPaletteButton;
		private System.Windows.Forms.ToolStripMenuItem invertColorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
		private System.Windows.Forms.ToolStripMenuItem exportTileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportLayoutSectionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem presentationStagesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem regularStagesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem specialStagesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bonusStagesToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.ToolStripDropDownButton bgLayerDropDown;
		private System.Windows.Forms.ComboBox collisionLayerSelector;
		private System.Windows.Forms.CheckBox collisionCeiling;
		private System.Windows.Forms.NumericUpDown ceilingAngle;
		private System.Windows.Forms.NumericUpDown rightAngle;
		private System.Windows.Forms.NumericUpDown leftAngle;
		private System.Windows.Forms.TabControl tabControl5;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.ListView objectOrder;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.TabPage tabPage13;
		private System.Windows.Forms.ComboBox layerScrollType;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel scrollEditPanel;
		private System.Windows.Forms.NumericUpDown layerParallaxFactor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown layerScrollSpeed;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ListBox scrollList;
		private System.Windows.Forms.Button addScrollButton;
		private System.Windows.Forms.CheckBox scrollEnableDeformation;
		private System.Windows.Forms.Button deleteScrollButton;
		private System.Windows.Forms.NumericUpDown scrollScrollSpeed;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown scrollParallaxFactor;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown scrollOffset;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.CheckBox scrollPreviewButton;
		private System.Windows.Forms.NumericUpDown scrollTargetFPS;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TabPage tabPage15;
		private System.Windows.Forms.NumericUpDown scrollFrame;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.NumericUpDown scrollCamY;
		private System.Windows.Forms.NumericUpDown scrollCamX;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.CheckBox showScrollAreas;
		private System.Windows.Forms.TextBox levelNameBox;
		private System.Windows.Forms.TextBox levelNameBox2;
		private System.Windows.Forms.GroupBox titleCardGroup;
		private System.Windows.Forms.GroupBox layerSettingsGroup;
		private System.Windows.Forms.ComboBox layer3Box;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.ComboBox layer2Box;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox layer1Box;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox layer0Box;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox midpointBox;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.GroupBox objectListGroup;
		private System.Windows.Forms.CheckBox loadGlobalObjects;
		private System.Windows.Forms.Button browseScriptButton;
		private System.Windows.Forms.TextBox objectScriptBox;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.TextBox objectNameBox;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Button objectDeleteButton;
		private System.Windows.Forms.Button objectAddButton;
		private System.Windows.Forms.ListBox objectListBox;
		private System.Windows.Forms.GroupBox soundEffectsGroup;
		private System.Windows.Forms.Button sfxBrowseButton;
		private System.Windows.Forms.TextBox sfxFileBox;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.TextBox sfxNameBox;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Button sfxDeleteButton;
		private System.Windows.Forms.Button sfxAddButton;
		private System.Windows.Forms.ListBox sfxListBox;
		private System.Windows.Forms.ToolStripMenuItem clearLevelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectModToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editGameConfigToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown colFlags;
		private System.Windows.Forms.ToolStripMenuItem recentModsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
	}
}
