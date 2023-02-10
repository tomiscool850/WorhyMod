using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using WorhyMod.Items.Projectiles.MeleeP.FlailP;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Melee.Flails
{
    internal class BrokenToyFlail : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Broken Toy Flail");
            Tooltip.SetDefault("Flail Made of Broken Toys.");
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
            Item.damage = 8;
            Item.crit = 7;
            Item.scale = 1.1f;
            Item.noUseGraphic = true;
            Item.shoot = ModContent.ProjectileType<BrokenToyProjectile>();
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
                .AddIngredient<BrokenToys>(12)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}