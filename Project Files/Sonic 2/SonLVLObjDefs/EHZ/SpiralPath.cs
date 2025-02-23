using SonicRetro.SonLVL.API;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace S2ObjectDefinitions.EHZ
{
	class SpiralPath : ObjectDefinition
	{
		private Sprite img;

		public override void Init(ObjectData data)
		{
			img = new Sprite(LevelData.GetSpriteSheet("Global/Display.gif").GetSection(127, 113, 16, 16), -8, -8);
		}

		public override ReadOnlyCollection<byte> Subtypes
		{
			get { return new ReadOnlyCollection<byte>(new List<byte>()); }
		}

		public override byte DefaultSubtype
		{
			get { return 0; }
		}

		public override string SubtypeName(byte subtype)
		{
			return null;
		}

		public override Sprite Image
		{
			get { return img; }
		}

		public override Sprite SubtypeImage(byte subtype)
		{
			return img;
		}

		public override Sprite GetSprite(ObjectEntry obj)
		{
			return img;
		}
		
		public override Sprite GetDebugOverlay(ObjectEntry obj)
		{
			// Draw the activator box of the Spiral
			var bitmap = new BitmapBits(385, 57);
			bitmap.DrawRectangle(LevelData.ColorWhite, 0, 0, 384, 56);
			return new Sprite(bitmap, -192, 8);
		}
	}
}