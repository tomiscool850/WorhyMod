using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Accessories.RangerA
{
    public class RangersQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Quiver Stuff.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.buyPrice(10);
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;

            Item.defense = 1;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Ranged) += 0.25f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Leather, 5)
                .AddIngredient(ItemID.WoodenArrow, 50)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}