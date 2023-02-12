using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Melee.Swords
{
    public class ToySword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Sword of Toys.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 19;
            Item.knockBack = 1;
            Item.crit = 6;

            Item.value = Item.buyPrice(silver: 15);
            Item.UseSound = SoundID.Item1;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Toys>(8)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}