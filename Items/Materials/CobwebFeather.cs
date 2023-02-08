using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Net;
using Terraria.GameContent.NetModules;
using Terraria.GameContent.Creative;

namespace WorhyMod.Items.Materials
{
    public class CobwebFeather : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Feather Made of Cobwebs.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;

            Item.maxStack = 999;
            Item.value = Item.buyPrice(copper: 25);
        }
        public override void AddRecipes()
        {
            CreateRecipe(2)
                .AddIngredient(ItemID.Feather, 2)
                .AddIngredient(ItemID.Cobweb, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}