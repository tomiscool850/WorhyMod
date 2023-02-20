using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace WorhyMod.Items.Tiles.Blocks.Plating
{
    public class SilverPlatingTile : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;

            ItemDrop = ModContent.ItemType<Items.Placeables.Blocks.Plating.SilverPlating>();

            AddMapEntry(new Color(200, 200, 200));
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }
    }
}