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
    public class TopazSythe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots Some nice Topaz Sickles.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.scale = 2;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 21;
            Item.useAnimation = 21;
            Item.autoReuse = true;

            Item.shootSpeed = 12f;
            Item.shoot = ModContent.ProjectileType<TopazSytheProjectile>();

            Item.DamageType = DamageClass.Melee;
            Item.damage = 18;
            Item.knockBack = 4;
            Item.crit = 6;

            Item.value = Item.buyPrice(gold: 2);
            Item.UseSound = SoundID.Item1;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Topaz, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}