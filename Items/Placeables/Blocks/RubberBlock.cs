using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Placeables.Walls.BeamsW;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Placeables.Blocks
{
	public class RubberBlock : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Rubber infused:).");
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
			Item.createTile = ModContent.TileType<Items.Tiles.Blocks.RubberBlockTile>();
		}
		public override void AddRecipes()
		{
			CreateRecipe(5)
				.AddIngredient<Rubber>(2)
				.AddTile(TileID.Anvils)
				.Register();
		}

	}
}