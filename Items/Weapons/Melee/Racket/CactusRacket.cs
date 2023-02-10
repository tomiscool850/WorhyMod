using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.RangedP.BallP;

namespace WorhyMod.Items.Weapons.Melee.Racket
{
    public class CactusRacket : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Be the Thorn");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 16;
            Item.useAnimation = 16;
            Item.autoReuse = true;

            Item.DamageType = ModContent.GetInstance<TennisClass>();
            Item.damage = 9;
            Item.knockBack = 2f;
            Item.crit = 3;

            Item.value = Item.buyPrice(gold: 2);
            Item.rare = ItemRarityID.Green;
            Item.UseSound = SoundID.Item1;
            Item.shoot = ModContent.ProjectileType<TenisBallProjectile>();
            Item.shootSpeed = 12;
        }

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Poisoned, 120);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Cactus, 15)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}