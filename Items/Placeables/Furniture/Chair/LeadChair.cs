using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace WorhyMod.Items.Placeables.Furniture.Chair
{
	public class LeadChair : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Chair of Lead.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.DefaultToPlaceableTile(ModContent.TileType<Items.Tiles.Furniture.Chair.LeadChairTile>());
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