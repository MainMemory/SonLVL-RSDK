using SonicRetro.SonLVL.API;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace S2ObjectDefinitions.Enemies
{
	class Shellcracker : ObjectDefinition
	{
		private Sprite img;
		private PropertySpec[] properties;

		public override void Init(ObjectData data)
		{
			if (LevelData.StageInfo.folder[LevelData.StageInfo.folder.Length-1] == '9')
			{
				img = new Sprite(LevelData.GetSpriteSheet("MPZ/Objects.gif").GetSection(199, 30, 56, 31), -24, -19);
			}
			else
			{
				img = new Sprite(LevelData.GetSpriteSheet("MBZ/Objects.gif").GetSection(132, 377, 56, 31), -24, -19); // using fixed frame
			}

			properties = new PropertySpec[1];
			properties[0] = new PropertySpec("Direction", typeof(int), "Extended",
				"Which way the Shellcracker is facing.", null, new Dictionary<string, int>
				{
					{ "Left", 0 },
					{ "Right", 1 }
				},
				(obj) => (obj.PropertyValue & 1),
				(obj, value) => obj.PropertyValue = ((byte)((int)value)));
		}

		public override ReadOnlyCollection<byte> Subtypes
		{
			get { return new ReadOnlyCollection<byte>(new byte[] { 0, 1 }); }
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
			switch (subtype)
			{
				case 0:
					return "Facing Left";
				case 1:
					return "Facing Right";
				default:
					return "Unknown";
			}
		}

		public override Sprite Image
		{
			get { return img; }
		}

		public override Sprite SubtypeImage(byte subtype)
		{
			Sprite sprite = new Sprite(img);
			sprite.Flip((subtype & 1) == 0, false);
			return sprite;
		}

		public override Sprite GetSprite(ObjectEntry obj)
		{
			return SubtypeImage(obj.PropertyValue);
		}
	}
}