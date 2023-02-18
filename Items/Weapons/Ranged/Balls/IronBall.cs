using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;
using WorhyMod.Items.Projectiles.RangedP.BallP;

namespace WorhyMod.Items.Weapons.Ranged.Balls
{
    public class IronBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Now this thing smacks");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 62;
            Item.height = 32;
            Item.rare = ItemRarityID.Green;
            Item.useTime = 18;
            Item.useAnimation = 18;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.autoReuse = true;
            Item.UseSound = SoundID.Item17;
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 13;
            Item.knockBack = 1f;
            Item.noMelee = true;
            Item.shoot = ModContent.ProjectileType<IronBallProjectile>();
            Item.shootSpeed = 12f;
            Item.consumable = true;
            Item.maxStack = 999;
        }
        public override void AddRecipes()
        {
            CreateRecipe(50)
                .AddIngredient(ItemID.IronBar, 2)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}