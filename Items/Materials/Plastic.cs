using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;
using WorhyMod.Items.Placeables.Blocks;

namespace WorhyMod.Items.Materials
{
	public class Plastic : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Cyan Cool.");
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults()
		{
			Item.width = 20;
			Item.height = 20;

			Item.maxStack = 999;
			Item.value = Item.buyPrice(copper: 50);
		}
		public override void AddRecipes()
		{
			CreateRecipe(5)
				.AddIngredient(ItemID.TatteredCloth, 8)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
		public override void OnResearched(bool fullyResearched)
		{
			if (fullyResearched)
			{
				CreativeUI.ResearchItem(ModContent.ItemType<PlasticBlock>());
			}
		}
	}
}