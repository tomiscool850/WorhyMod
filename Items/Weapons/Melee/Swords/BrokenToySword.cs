using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Melee.Swords
{
    public class BrokenToySword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Sword of Broken Toys.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.autoReuse = false;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 7;
            Item.knockBack = 1;
            Item.crit = 6;

            Item.value = Item.buyPrice(silver: 15);
            Item.UseSound = SoundID.Item1;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<BrokenToys>(8)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}