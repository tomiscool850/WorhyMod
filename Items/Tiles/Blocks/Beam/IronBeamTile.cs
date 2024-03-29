using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace WorhyMod.Items.Tiles.Blocks.Beam
{
	public class IronBeamTile : ModTile
	{
		public override void SetStaticDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;

			ItemDrop = ModContent.ItemType<Items.Placeables.Blocks.Beam.CopperBeam>();

			AddMapEntry(new Color(200, 200, 200));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
	}
}