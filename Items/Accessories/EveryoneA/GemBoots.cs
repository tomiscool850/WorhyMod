using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Accessories.EveryoneA
{
    [AutoloadEquip(EquipType.Shoes)]
    public class GemBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Gem Stuff made of boots.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.buyPrice(10);
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;

            Item.defense = 3;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accRunSpeed += 4;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Amethyst, 5)
                .AddIngredient(ItemID.Amber, 5)
                .AddIngredient(ItemID.Diamond, 5)
                .AddIngredient(ItemID.Sapphire, 5)
                .AddIngredient(ItemID.Emerald, 5)
                .AddIngredient(ItemID.Ruby, 5)
                .AddIngredient(ItemID.Topaz, 5)
                .AddIngredient(ItemID.HermesBoots)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}