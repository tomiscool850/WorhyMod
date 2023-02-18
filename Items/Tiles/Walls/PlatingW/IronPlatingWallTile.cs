using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace WorhyMod.Items.Tiles.Walls.PlatingW
{

	public class IronPlatingWallTile : ModWall
	{
		public override void SetStaticDefaults()
		{
			Main.wallHouse[Type] = true;
			ItemDrop = ModContent.ItemType<Items.Placeables.Walls.PlatingW.TinPlatingWall>();

			AddMapEntry(new Color(150, 150, 150));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
	}
}
