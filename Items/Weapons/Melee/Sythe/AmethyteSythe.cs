using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;
using WorhyMod.Items.Projectiles.MeleeP.SpearP;
using WorhyMod.Items.Projectiles.MeleeP.SytheP;

namespace WorhyMod.Items.Weapons.Melee.Sythe
{
    public class AmethyteSythe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots Some nice Amethyste Sickles.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.scale = 2;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 19;
            Item.useAnimation = 19;
            Item.autoReuse = true;

            Item.shootSpeed = 12f;
            Item.shoot = ModContent.ProjectileType<AmethysteSytheProjectile>();

            Item.DamageType = DamageClass.Melee;
            Item.damage = 15;
            Item.knockBack = 4;
            Item.crit = 6;

            Item.value = Item.buyPrice(gold: 2);
            Item.UseSound = SoundID.Item1;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Amethyst, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}