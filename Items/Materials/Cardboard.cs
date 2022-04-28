using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace WorhyMod.Items.Materials
{
	public class Cardboard : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Weak wood 100%.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;

			Item.maxStack = 999;
			Item.value = Item.buyPrice(copper: 35);
		}
		public override void AddRecipes()
		{
			CreateRecipe(2)
				.AddIngredient(ItemID.Wood, 2)
				.Register();
		}
	}
}