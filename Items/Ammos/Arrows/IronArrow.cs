using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.AmmoP.ArrowP;

namespace WorhyMod.Items.Ammos.Arrows
{
	public class IronArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Arrow of Iron.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
		}

		public override void SetDefaults()
		{
			Item.damage = 10;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 8;
			Item.height = 8;
			Item.maxStack = 999;
			Item.consumable = true;
			Item.value = 50;
			Item.rare = ItemRarityID.Green;
			Item.shoot = ModContent.ProjectileType<Items.Projectiles.AmmoP.ArrowP.IronArrowProjectile>();
			Item.shootSpeed = 8f;
			Item.ammo = AmmoID.Arrow;
		}
		public override void AddRecipes()
		{
			CreateRecipe(50)
				.AddIngredient(ItemID.IronBar)
				.AddIngredient(ItemID.WoodenArrow, 50)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}