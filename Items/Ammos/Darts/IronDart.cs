using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.AmmoP.ArrowP;

namespace WorhyMod.Items.Ammos.Darts
{
	public class IronDart : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Dart of Iron.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults()
		{
			Item.damage = 9;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.value = 50;
			Item.shoot = ModContent.ProjectileType<Items.Projectiles.AmmoP.DartP.IronDartProjectile>();
			Item.shootSpeed = 8f;
			Item.ammo = AmmoID.Dart;
		}
		public override void AddRecipes()
		{
			CreateRecipe(25)
				.AddIngredient(ItemID.IronBar)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}