using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace WorhyMod.Items.Placeables.LightStuff.Lamp
{
	internal class LeadLamp : ModItem
	{
		public override void SetStaticDefaults()
		{
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.maxStack = 99;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Items.Tiles.LightStuff.Lamp.LeadLampTile>();
			Item.width = 10;
			Item.height = 24;
			Item.value = 500;
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
