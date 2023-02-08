using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace WorhyMod.Items.Materials
{
    public class SnowCloth : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Cloth of Snow.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 999;
            Item.value = Item.buyPrice(silver: 50);
        }
        public override void AddRecipes()
        {
            CreateRecipe(5)
                .AddIngredient(ItemID.Snowball, 2)
                .AddIngredient(ItemID.Silk, 5)
                .Register();
        }
    }
}