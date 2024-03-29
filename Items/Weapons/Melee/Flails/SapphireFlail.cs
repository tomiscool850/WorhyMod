using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using WorhyMod.Items.Projectiles.MeleeP.FlailP;

namespace WorhyMod.Items.Weapons.Melee.Flails
{
    internal class SapphireFlail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sapphire Flail");
            Tooltip.SetDefault("Flail of Sapphire.");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAnimation = 40;
            Item.useTime = 40;
            Item.knockBack = 7f;
            Item.width = 30;
            Item.height = 10;
            Item.damage = 28;
            Item.crit = 7;
            Item.scale = 1.1f;
            Item.noUseGraphic = true;
            Item.shoot = ModContent.ProjectileType<SapphireFlailProjectile>();
            Item.shootSpeed = 12f;
            Item.UseSound = SoundID.Item1;
            Item.rare = ItemRarityID.Orange;
            Item.value = Item.sellPrice(silver: 50);
            Item.DamageType = DamageClass.MeleeNoSpeed;
            Item.channel = true;
            Item.noMelee = true;
        }

        public override Color? GetAlpha(Color lightColor)
        {
            return Color.White;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Sapphire, 18)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}