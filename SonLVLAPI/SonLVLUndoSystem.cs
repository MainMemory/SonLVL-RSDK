using System.IO;

namespace SonicRetro.SonLVL.API
{
	public class SonLVLUndoSystem : UndoSystem
	{
		protected override void ApplyState(byte[] state)
		{
			using (var ms = new MemoryStream(state))
			{
				ms.ReadDeflateBlock(ds =>
				{
					for (var i = 0; i < LevelData.NewPalette.Length; i++)
						LevelData.NewPalette[i] = System.Drawing.Color.FromArgb(ds.ReadByte(), ds.ReadByte(), ds.ReadByte());
				});
				ms.ReadDeflateBlock(ds =>
				{
					for (var i = 0; i < LevelData.NewTiles.Length; i++)
						ds.Read(LevelData.NewTiles[i].Bits, 0, LevelData.NewTiles[i].Bits.Length);
				});
				ms.ReadDeflateBlock(ds =>
				{
					using (var reader = new RSDKv3_4.Reader(ds))
						LevelData.NewChunks.Read(reader);
				});
				ms.ReadDeflateBlock(ds =>
				{
					using (var reader = new RSDKv3_4.Reader(ds))
						LevelData.Collision.Read(reader);
				});
				ms.ReadDeflateBlock(ds =>
				{
					using (var reader = new RSDKv3_4.Reader(ds))
						LevelData.StageConfig.Read(reader);
				});
				ms.ReadDeflateBlock(ds =>
				{
					using (var reader = new RSDKv3_4.Reader(ds))
						LevelData.Scene.Read(reader);
				});
				foreach (var scn in LevelData.AdditionalScenes)
					ms.ReadDeflateBlock(ds =>
					{
						using (var reader = new RSDKv3_4.Reader(ds))
							scn.Scene.Read(reader);
					});
			}
		}

		protected override byte[] GetState()
		{

			using (var ms = new MemoryStream())
			{
				ms.WriteDeflateBlock(ds =>
				{
					for (var i = 0; i < LevelData.NewPalette.Length; i++)
					{
						ds.WriteByte(LevelData.NewPalette[i].R);
						ds.WriteByte(LevelData.NewPalette[i].G);
						ds.WriteByte(LevelData.NewPalette[i].B);
					}
				});
				ms.WriteDeflateBlock(ds =>
				{
					for (var i = 0; i < LevelData.NewTiles.Length; i++)
						ds.Write(LevelData.NewTiles[i].Bits, 0, LevelData.NewTiles[i].Bits.Length);
				});
				ms.WriteDeflateBlock(ds => LevelData.NewChunks.Write(ds));
				ms.WriteDeflateBlock(ds => LevelData.Collision.Write(ds));
				ms.WriteDeflateBlock(ds => LevelData.StageConfig.Write(ds));
				ms.WriteDeflateBlock(ds => LevelData.Scene.Write(ds));
				foreach (var scn in LevelData.AdditionalScenes)
					ms.WriteDeflateBlock(ds => scn.Scene.Write(ds));
				return ms.ToArray();
			}
		}
	}
}
