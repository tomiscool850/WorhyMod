using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Ranged.Guns.Pistals
{
	public class Comfifteen : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Com15");

			Tooltip.SetDefault("kinda hard to tell but this may be an weapons based" +
                "on a scp game... Caugh caugh Scp secret Lab Caugh.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 62;
			Item.height = 32;
			Item.scale = 1.2f;
			Item.rare = ItemRarityID.White;

			Item.useTime = 14;
			Item.useAnimation = 14;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.autoReuse = true;
			Item.UseSound = SoundID.Item11;

			Item.DamageType = DamageClass.Ranged;
			Item.damage = 15;
			Item.knockBack = 3f;
			Item.noMelee = true;

			Item.shoot = ProjectileID.Bullet;
			Item.shootSpeed = 15f;
			Item.useAmmo = AmmoID.Bullet;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.IronBar, 12)
				.AddIngredient(ItemID.Chain, 3)
				.AddIngredient(ItemID.Hook)
				.AddTile(TileID.Anvils)
				.Register();

            CreateRecipe()
                .AddIngredient(ItemID.LeadBar, 12)
                .AddIngredient(ItemID.Chain, 3)
                .AddIngredient(ItemID.Hook)
                .AddTile(TileID.Anvils)
                .Register();
        }
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(2f, -2f);
		}
	}
}