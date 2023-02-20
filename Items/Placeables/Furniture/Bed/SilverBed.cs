using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace WorhyMod.Items.Placeables.Furniture.Bed
{
    public class SilverBed : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("night Night.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 28;
            Item.height = 20;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = 2000;
            Item.createTile = ModContent.TileType<Tiles.Furniture.Bed.SilverBedTile>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SilverBar, 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}