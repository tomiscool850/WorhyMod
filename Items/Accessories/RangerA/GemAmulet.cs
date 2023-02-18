using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Accessories.RangerA
{
    public class GemAmulet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Amulet Made of the best gems.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.buyPrice(10);
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;

            Item.defense = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Magic) += 0.35f;
            player.statLifeMax2 += 25;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Amethyst, 5)
                .AddIngredient(ItemID.Amber, 5)
                .AddIngredient(ItemID.Topaz, 5)
                .AddIngredient(ItemID.Sapphire, 5)
                .AddIngredient(ItemID.Ruby, 5)
                .AddIngredient(ItemID.Emerald, 5)
                .AddIngredient(ItemID.Diamond, 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}