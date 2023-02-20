using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Tiles.Furniture.Door;

namespace WorhyMod.Items.Placeables.Furniture.Door
{
    public class SilverDoor : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Doors hehe.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 14;
            Item.height = 28;
            Item.maxStack = 99;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.value = 150;
            Item.createTile = ModContent.TileType<SilverDoorTileClosed>();
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SilverBar, 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}