using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace WorhyMod.Items.Placeables.Furniture.Table
{
	public class LeadTable : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Table of Lead.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Items.Tiles.Furniture.Table.LeadTableTile>());
			Item.value = 150;
			Item.maxStack = 99;
			Item.width = 12;
			Item.height = 30;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
			.AddIngredient(ItemID.LeadBar, 8)
			.AddTile(TileID.Anvils)
			.Register();
		}
	}
}