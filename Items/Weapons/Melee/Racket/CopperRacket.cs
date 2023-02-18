using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod;
using WorhyMod.Items.Projectiles.RangedP.BallP;

namespace WorhyMod.Items.Weapons.Melee.Racket
{
	public class CopperRacket : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("sometimes i do belive that one day tin or copper will be useful" +
				"but for now its just used for stupid weapons like this.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.autoReuse = true;

            Item.DamageType = ModContent.GetInstance<TennisClass>();
            Item.damage = 14;
			Item.knockBack = 3.5f;
			Item.crit = 3;

			Item.value = Item.buyPrice(silver: 5);
			Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item1;
            Item.shoot = ModContent.ProjectileType<TenisBallProjectile>();
            Item.shootSpeed = 12;
        }
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Bleeding, 120);
        }
        public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.CopperBar, 9)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}