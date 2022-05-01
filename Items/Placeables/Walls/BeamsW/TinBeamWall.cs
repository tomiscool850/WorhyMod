using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Placeables.Blocks.Beam;

namespace WorhyMod.Items.Placeables.Walls.BeamsW
{
	public class TinBeamWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Wall important for backround.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 450;
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
			Item.createWall = ModContent.WallType<Items.Tiles.Walls.BeamsW.TinBeamWallTile>();

		}
		public override void AddRecipes()
		{
			CreateRecipe(4)
				.AddIngredient<TinBeam>()
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}