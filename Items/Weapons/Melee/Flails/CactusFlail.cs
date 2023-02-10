using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using WorhyMod.Items.Projectiles.MeleeP.FlailP;

namespace WorhyMod.Items.Weapons.Melee.Flails
{
    internal class CactusFlail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cactus Flail");
            Tooltip.SetDefault("Flail of Cactus.");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAnimation = 35;
            Item.useTime = 35;
            Item.knockBack = 6.75f;
            Item.width = 30;
            Item.height = 10;
            Item.damage = 9;
            Item.crit = 7;
            Item.scale = 1.1f;
            Item.noUseGraphic = true;
            Item.shoot = ModContent.ProjectileType<CactusFlailProjectile>();
            Item.shootSpeed = 12f;
            Item.UseSound = SoundID.Item1;
            Item.rare = ItemRarityID.Orange;
            Item.value = Item.sellPrice(silver: 25);
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
                .AddIngredient(ItemID.Cactus, 18)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}