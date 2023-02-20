using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Placeables.PcStuff.Pc
{
    public class ShrubsGamingLaptop : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shrubs Gaming Laptop");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.maxStack = 999;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.PcStuff.Pc.ShrubsGamingLaptopTile>();
            Item.width = 24;
            Item.height = 30;
            Item.value = Item.buyPrice(silver: 25);
        }
    }
}