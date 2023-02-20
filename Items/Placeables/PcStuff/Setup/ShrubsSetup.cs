using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace WorhyMod.Items.Placeables.PcStuff.Setup
{
    public class ShrubsSetup : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Items.Tiles.PcStuff.Setup.ShrubsSetupTile>());
            Item.value = Item.buyPrice(silver: 25);
            Item.maxStack = 99;
            Item.width = 12;
            Item.height = 30;
        }
    }
}