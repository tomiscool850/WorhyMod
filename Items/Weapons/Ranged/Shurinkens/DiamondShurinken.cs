using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;
using WorhyMod.Items.Projectiles.RangedP.BallP;
using WorhyMod.Items.Projectiles.RangedP.ShurinkenP;

namespace WorhyMod.Items.Weapons.Ranged.Shurinkens
{
    public class DiamondShurinken : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Sharpo Diamond");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 62;
            Item.height = 32;
            Item.rare = ItemRarityID.Green;
            Item.useTime = 8;
            Item.useAnimation = 8;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.autoReuse = true;
            Item.UseSound = SoundID.Item17;
            Item.DamageType = DamageClass.Ranged;
            Item.damage = 18;
            Item.knockBack = 1f;
            Item.noMelee = true;
            Item.shoot = ModContent.ProjectileType<DiamondShurinkenProjectile>();
            Item.shootSpeed = 3f;
            Item.consumable = true;
            Item.maxStack = 999;
        }
        public override void AddRecipes()
        {
            CreateRecipe(50)
                .AddIngredient(ItemID.Diamond)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}