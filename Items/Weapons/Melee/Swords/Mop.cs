using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Melee.Swords
{
    public class Mop : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nice and moppy.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 23;
            Item.useAnimation = 23;
            Item.autoReuse = false;
            Item.scale = 2f;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 8;
            Item.knockBack = 1;
            Item.crit = 6;

            Item.value = Item.buyPrice(gold: 1);
            Item.UseSound = SoundID.Item1;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Wood, 5)
                .AddIngredient(ItemID.Silk, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}