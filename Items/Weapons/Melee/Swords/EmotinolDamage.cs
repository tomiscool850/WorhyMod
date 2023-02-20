using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;
using Terraria.Audio;

namespace WorhyMod.Items.Weapons.Melee.Swords
{
    public class EmotinolDamage : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("EMOTINAL DAMAGE.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 999;
            Item.useAnimation = 45;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 999999999;
            Item.knockBack = 1.5f;
            Item.crit = 6;

            Item.value = Item.buyPrice(platinum: 1);
            Item.UseSound = new SoundStyle($"{nameof(WorhyMod)}/Sounds/VineBoom")
            {
                Volume = 0.9f,
                PitchVariance = 0.2f,
                MaxInstances = 3,
            };
            Item.mana = 100;
        }
    }
}