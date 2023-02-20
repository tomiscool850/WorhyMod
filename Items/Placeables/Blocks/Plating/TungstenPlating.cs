using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Placeables.Walls.PlatingW;

namespace WorhyMod.Items.Placeables.Blocks.Plating
{
    public class TungstenPlating : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Tile with the Tint.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
            ItemID.Sets.ExtractinatorMode[Item.type] = Item.type;
        }

        public override void SetDefaults()
        {
            Item.width = 12;
            Item.height = 12;
            Item.maxStack = 999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<Items.Tiles.Blocks.Plating.TungstenPlatingTile>();
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.TungstenOre)
                .AddIngredient(ItemID.StoneBlock, 5)
                .AddTile(TileID.Furnaces)
                .Register();

            CreateRecipe()
                .AddIngredient<TungstenPlatingWall>(4)
                .AddTile(TileID.WorkBenches)
                .Register();
        }

    }
}