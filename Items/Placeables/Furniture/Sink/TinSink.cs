using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Placeables.Furniture.Sink
{
    public class TinSink : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Tin Sink");
            Tooltip.SetDefault("Counts as a water, lava, and honey source\n"
                             + "'A shame there's no Fun liquids (yet)'");

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
            Item.createTile = ModContent.TileType<Tiles.Furniture.Sink.TinSinkTile>();
            Item.width = 24;
            Item.height = 30;
            Item.value = 3000;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.TinBar, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}