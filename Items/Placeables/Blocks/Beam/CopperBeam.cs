using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Placeables.Walls.BeamsW;

namespace WorhyMod.Items.Placeables.Blocks.Beam
{
	public class CopperBeam : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Tile with the Copper Color.");
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
			Item.createTile = ModContent.TileType<Items.Tiles.Blocks.Beam.CopperBeamTile>();
		}
		public override void AddRecipes()
		{
			CreateRecipe(10)
				.AddIngredient(ItemID.CopperBar, 2)
				.AddTile(TileID.Anvils)
				.Register();

			CreateRecipe()
				.AddIngredient<CopperBeamWall>(4)
				.Register();
		}

	}
}