using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Placeables.Walls.PlatingW;

namespace WorhyMod.Items.Placeables.Blocks.Plating
{
	public class TinPlating : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Tile with the yellow.");
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
			Item.createTile = ModContent.TileType<Items.Tiles.Blocks.Plating.TinPlatingTile>();
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.TinOre)
				.AddIngredient(ItemID.StoneBlock, 5)
				.AddTile(TileID.Furnaces)
				.Register();

			CreateRecipe()
				.AddIngredient<TinPlatingWall>(4)
				.AddTile(TileID.WorkBenches)
				.Register();
		}

	}
}