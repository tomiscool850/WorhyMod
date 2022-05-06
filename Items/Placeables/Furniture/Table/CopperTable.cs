using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace WorhyMod.Items.Placeables.Furniture.Table
{
	public class CopperTable : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Table of copper.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Items.Tiles.Furniture.Table.CopperTableTile>());
			Item.value = 150;
			Item.maxStack = 99;
			Item.width = 12;
			Item.height = 30;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
			.AddIngredient(ItemID.CopperBar, 8)
			.AddTile(TileID.Anvils)
			.Register();
		}
	}
}