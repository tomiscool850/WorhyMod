using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Melee.Swords
{
    public class ShrubsSharpnessFiveKnockbackThreeFryingPan : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("shrub co. cast iron frying pan with knockback 3 and sharpness 3 with extra fucking cast iron frying pan");
            Tooltip.SetDefault("Shrubs Signiture frying pan.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 21;
            Item.useAnimation = 21;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 81;
            Item.knockBack = 12;
            Item.crit = 6;

            Item.value = Item.buyPrice(gold: 8);
            Item.UseSound = SoundID.Item1;
        }
    }
}