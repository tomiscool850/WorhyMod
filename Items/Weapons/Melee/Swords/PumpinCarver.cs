using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Melee.Swords
{
    public class PumpinCarver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nice and carvy for pumpkin.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 8;
            Item.useAnimation = 8;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 21;
            Item.knockBack = 2f;
            Item.crit = 6;

            Item.value = Item.buyPrice(gold: 1);
            Item.UseSound = SoundID.Item1;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Carver>(2)
                .AddIngredient(ItemID.Pumpkin, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}