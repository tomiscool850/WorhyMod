using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Melee.Swords
{
    public class StoneSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Sword of stone.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 30;
            Item.useAnimation = 30;
            Item.autoReuse = false;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 12;
            Item.knockBack = 3;
            Item.crit = 6;

            Item.value = Item.buyPrice(gold: 1);
            Item.UseSound = SoundID.Item1;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.StoneBlock, 30)
                .AddIngredient(ItemID.Wood, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}