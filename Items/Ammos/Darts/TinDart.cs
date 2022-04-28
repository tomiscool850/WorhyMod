using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.AmmoP.ArrowP;

namespace WorhyMod.Items.Ammos.Darts
{
	public class TinDart : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Dart of Tin.");

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
			Item.rare = ItemRarityID.Green;
			Item.shoot = ModContent.ProjectileType<Items.Projectiles.AmmoP.ArrowP.TinArrowProjectile>();
			Item.shootSpeed = 8f;
			Item.ammo = AmmoID.Dart;
		}
		public override void AddRecipes()
		{
			CreateRecipe(25)
				.AddIngredient(ItemID.TinBar)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}