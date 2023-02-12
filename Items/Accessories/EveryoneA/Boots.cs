using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Accessories.EveryoneA
{
    [AutoloadEquip(EquipType.Shoes)]
    public class Boots : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Them Old ones passed by grandad.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.buyPrice(10);
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;

        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accRunSpeed += 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Leather, 12)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}