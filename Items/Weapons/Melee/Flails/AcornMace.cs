using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using WorhyMod.Items.Projectiles.MeleeP.FlailP;

namespace WorhyMod.Items.Weapons.Melee.Flails
{
    internal class AcornMace : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Acorn Mace");
            Tooltip.SetDefault("Mace of Acorn.");
            SacrificeTotal = 1;
        }

        public override void SetDefaults()
        {

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAnimation = 35;
            Item.useTime = 45;
            Item.knockBack = 5f;
            Item.width = 30;
            Item.height = 10;
            Item.damage = 8;
            Item.crit = 7;
            Item.scale = 1.1f;
            Item.noUseGraphic = true;
            Item.shoot = ModContent.ProjectileType<AcornMaceProjectile>();
            Item.shootSpeed = 12f;
            Item.UseSound = SoundID.Item1;
            Item.rare = ItemRarityID.Gray;
            Item.value = Item.sellPrice(silver: 10);
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
                .AddIngredient(ItemID.Wood, 18)
                .AddIngredient(ItemID.Acorn, 8)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}