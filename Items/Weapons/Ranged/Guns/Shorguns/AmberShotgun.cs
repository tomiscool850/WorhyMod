using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Ranged.Guns.Shorguns
{
    public class AmberShotgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("multi shot.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 44;
            Item.height = 18;
            Item.rare = ItemRarityID.Green;

            Item.useTime = 55;
            Item.useAnimation = 55;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;
            Item.UseSound = SoundID.Item36;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 11;
            Item.knockBack = 6f;
            Item.noMelee = true;

            Item.shoot = ProjectileID.PurificationPowder;
            Item.shootSpeed = 10f;
            Item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            const int NumProjectiles = 4;

            for (int i = 0; i < NumProjectiles; i++)
            {
                Vector2 newVelocity = velocity.RotatedByRandom(MathHelper.ToRadians(15));

                newVelocity *= 1f - Main.rand.NextFloat(0.3f);

                Projectile.NewProjectileDirect(source, position, newVelocity, type, damage, knockback, player.whoAmI);
            }

            return false;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Amber, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }

        public override Vector2? HoldoutOffset()
        {
            return new Vector2(-2f, -2f);
        }
    }
}