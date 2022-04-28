using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.AmmoP.ArrowP;

namespace WorhyMod.Items.Ammos.Darts
{
	public class CopperDart : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Dart of copper.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults()
		{
			Item.damage = 6;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.value = 50;
			Item.shoot = ModContent.ProjectileType<Items.Projectiles.AmmoP.DartP.CopperDartProjectile>();
			Item.shootSpeed = 8f;
			Item.ammo = AmmoID.Dart;
		}
		public override void AddRecipes()
		{
			CreateRecipe(25)
				.AddIngredient(ItemID.CopperBar)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}