using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using System;
using WorhyMod.Items.Projectiles.MeleeP.YoyoP;

namespace WorhyMod.Items.Weapons.Melee.Yoyo
{
    public class EmeraldYoyo : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Yoyo's are intresting.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;

            ItemID.Sets.Yoyo[Item.type] = true;
            ItemID.Sets.GamepadExtraRange[Item.type] = 15;
            ItemID.Sets.GamepadSmartQuickReach[Item.type] = true;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 24;

            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useTime = 18;
            Item.useAnimation = 18;
            Item.noMelee = true;
            Item.noUseGraphic = true;
            Item.UseSound = SoundID.Item1;

            Item.damage = 20;
            Item.DamageType = DamageClass.MeleeNoSpeed;
            Item.knockBack = 2f;
            Item.crit = 8;
            Item.channel = true;

            Item.shoot = ModContent.ProjectileType<EmeraldYoyoProjectile>();
            Item.shootSpeed = 16f;
        }

        private static readonly int[] unwantedPrefixes = new int[] { PrefixID.Terrible, PrefixID.Dull, PrefixID.Shameful, PrefixID.Annoying, PrefixID.Broken, PrefixID.Damaged, PrefixID.Shoddy };

        public override bool AllowPrefix(int pre)
        {

            if (Array.IndexOf(unwantedPrefixes, pre) > -1)
            {
                return false;
            }

            return true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Emerald, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}