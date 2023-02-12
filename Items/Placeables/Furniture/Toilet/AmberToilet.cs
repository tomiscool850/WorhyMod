using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Placeables.Furniture.Toilet
{
    public class AmberToilet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amber Toilet");
            Tooltip.SetDefault("poo poo.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.Toilet.AmberToiletTile>());
            Item.value = 150;
            Item.maxStack = 99;
            Item.width = 16;
            Item.height = 24;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Toilet)
                .AddIngredient(ItemID.Amber, 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}