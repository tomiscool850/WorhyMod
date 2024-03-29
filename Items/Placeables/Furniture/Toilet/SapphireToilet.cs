using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Placeables.Furniture.Toilet
{
    public class SapphireToilet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sapphire Toilet");
            Tooltip.SetDefault("poo poo.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.Toilet.SapphireToiletTile>());
            Item.value = 150;
            Item.maxStack = 99;
            Item.width = 16;
            Item.height = 24;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Toilet)
                .AddIngredient(ItemID.Sapphire, 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}