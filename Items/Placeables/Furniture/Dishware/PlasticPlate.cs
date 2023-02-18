using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Placeables.Furniture.Dishware
{
    public class PlasticPlate : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Plate.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Items.Tiles.Furniture.Dishware.PlasticPlateTile>());
            Item.value = 150;
            Item.maxStack = 99;
            Item.width = 12;
            Item.height = 30;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
            .AddIngredient<Plastic>(2)
            .AddTile(TileID.WorkBenches)
            .Register();
        }
    }
}