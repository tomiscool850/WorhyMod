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
    public class EmeraldSythe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots Some nice Emerald Sickles.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.scale = 2;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.autoReuse = true;

            Item.shootSpeed = 12f;
            Item.shoot = ModContent.ProjectileType<EmeraldSytheProjectile>();

            Item.DamageType = DamageClass.Melee;
            Item.damage = 21;
            Item.knockBack = 6.5f;
            Item.crit = 6;

            Item.value = Item.buyPrice(gold: 3);
            Item.UseSound = SoundID.Item1;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Emerald, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}