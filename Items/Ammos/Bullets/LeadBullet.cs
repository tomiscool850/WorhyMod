using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.AmmoP.ArrowP;

namespace WorhyMod.Items.Ammos.Bullets
{
	public class LeadBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Bullet of Lead.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults()
		{
			Item.damage = 11;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.value = 50;
			Item.rare = ItemRarityID.Green;
			Item.shoot = ModContent.ProjectileType<Items.Projectiles.AmmoP.BulletP.LeadBulletProjectile>();
			Item.shootSpeed = 8f;
			Item.ammo = AmmoID.Bullet;
		}
		public override void AddRecipes()
		{
			CreateRecipe(50)
				.AddIngredient(ItemID.LeadBar)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}