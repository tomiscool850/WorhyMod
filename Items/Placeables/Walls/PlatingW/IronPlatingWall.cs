using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Placeables.Blocks.Plating;

namespace WorhyMod.Items.Placeables.Walls.PlatingW
{
	public class IronPlatingWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Pretty Cool:).");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 420;
		}

		public override void SetDefaults()
		{
			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 7;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.createWall = ModContent.WallType<Items.Tiles.Walls.PlatingW.IronPlatingWallTile>();

		}
		public override void AddRecipes()
		{
			CreateRecipe(4)
				.AddIngredient<IronPlating>()
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}