using SonicRetro.SonLVL.API;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace S2ObjectDefinitions.CNZ
{
	class Spinner_V : ObjectDefinition
	{
		private PropertySpec[] properties;
		private readonly Sprite[] sprites = new Sprite[2];
		
		public override ReadOnlyCollection<byte> Subtypes
		{
			get { return new ReadOnlyCollection<byte>(new List<byte>()); }
		}

		public override void Init(ObjectData data)
		{
			BitmapBits sheet = LevelData.GetSpriteSheet("Global/Display.gif");
			
			sprites[0] = new Sprite(sheet.GetSection(127, 113, 16, 16), -8, -8);
			sprites[1] = new Sprite(sheet.GetSection(144, 113, 16, 16), -8, -8);
			
			properties = new PropertySpec[2];
			properties[0] = new PropertySpec("Size", typeof(int), "Extended",
				"How tall the Spinner is.", null, new Dictionary<string, int>
				{
					{ "4 Nodes", 0 },
					{ "8 Nodes", 1 },
					{ "16 Nodes", 2 },
					{ "32 Nodes", 3 }
				},
				(obj) => obj.PropertyValue & 3,
				(obj, value) => obj.PropertyValue = (byte)((obj.PropertyValue & 252) | (byte)((int)value)));
			
			properties[1] = new PropertySpec("Enter From", typeof(int), "Extended",
				"Which plane is above.", null, new Dictionary<string, int>
				{
					{ "Left", 0 },
					{ "Right", 4 }
				},
				(obj) => obj.PropertyValue & 4,
				(obj, value) => obj.PropertyValue = (byte)((obj.PropertyValue & 251) | (byte)((int)value)));
		}
		
		public override byte DefaultSubtype
		{
			get { return 0; }
		}
		
		public override PropertySpec[] CustomProperties
		{
			get { return properties; }
		}

		public override string SubtypeName(byte subtype)
		{
			return null;
		}

		public override Sprite Image
		{
			get { return sprites[0]; }
		}

		public override Sprite SubtypeImage(byte subtype)
		{
			return sprites[0];
		}

		public override Sprite GetSprite(ObjectEntry obj)
		{
			int count = Math.Max((1 << ((obj.PropertyValue & 3) + 2)), 1);
			int sy = -(((count) * 16) / 2) + 8;
			List<Sprite> sprs = new List<Sprite>();
			for (int i = 0; i < count; i++)
			{
				Sprite tmp = new Sprite(sprites[(obj.PropertyValue & 4) >> 2]);
				tmp.Offset(0, sy + (i * 16));
				sprs.Add(tmp);
			}
			return new Sprite(sprs.ToArray());
		}
	}
}