using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace WorhyMod.Items.Materials
{
	public class BlowpipeCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("used for blowpipes... thats it.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;

			Item.maxStack = 999;
			Item.value = Item.buyPrice(copper: 25);
		}
		public override void AddRecipes()
		{
			CreateRecipe(2)
				.AddIngredient(ItemID.Wood, 8)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
		public override void OnResearched(bool fullyResearched)
		{
			if (fullyResearched)
			{
				CreativeUI.ResearchItem(ItemID.Blowgun);
				CreativeUI.ResearchItem(ItemID.Blowpipe);
			}
		}
	}
}