using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Materials
{
    public class NightsBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
            ItemID.Sets.SortingPriorityMaterials[Item.type] = 59;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 99;
            Item.value = 50000; 
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Tiles.Bars.NightsBarTile>();
            Item.placeStyle = 0;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.PlatinumBar)
                .AddIngredient(ItemID.CrimtaneBar)
                .AddIngredient(ItemID.JungleSpores, 5)
                .AddIngredient(ItemID.Bone, 25)
                .AddTile(TileID.Furnaces)
                .Register();

            CreateRecipe()
                .AddIngredient(ItemID.GoldBar)
                .AddIngredient(ItemID.DemoniteBar)
                .AddIngredient(ItemID.JungleSpores, 5)
                .AddIngredient(ItemID.Bone, 25)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
}