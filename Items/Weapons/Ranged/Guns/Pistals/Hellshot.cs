using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Ranged.Guns.Pistals
{
	public class Hellshot : ModItem
	{
		public override void SetStaticDefaults()
		{

			Tooltip.SetDefault("dont worry this one isnt based off a game;).");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 62;
			Item.height = 32;
			Item.scale = 1.3f;
			Item.rare = ItemRarityID.Orange;

			Item.useTime = 16;
			Item.useAnimation = 16;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.autoReuse = true;
			Item.UseSound = SoundID.Item11;

			Item.DamageType = DamageClass.Ranged;
			Item.damage = 32;
			Item.knockBack = 3.5f;
			Item.noMelee = true;

			Item.shoot = ProjectileID.Bullet;
			Item.shootSpeed = 16f;
			Item.useAmmo = AmmoID.Bullet;
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 60);
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<Comfifteen>()
				.AddIngredient(ItemID.HellstoneBar, 8)
				.AddIngredient(ItemID.Obsidian, 3)
				.AddTile(TileID.Anvils)
				.Register();
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(2f, -2f);
		}
	}
}