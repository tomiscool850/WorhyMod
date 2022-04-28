using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace WorhyMod.Items.Materials
{
	public class Toys : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Are you A Child?.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;

			Item.maxStack = 999;
			Item.value = Item.buyPrice(silver: 1);
		}
		public override void AddRecipes()
		{
			CreateRecipe(5)
				.AddIngredient(ItemID.Lens)
				.AddIngredient(ItemID.FlinxFur, 2)
				.AddTile(TileID.WorkBenches)
				.Register();
		}

	}
}