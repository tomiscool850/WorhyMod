using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Accessories.MageA
{
    public class MagesSecondStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("its the second one mabey theres more.");

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
            player.GetDamage(DamageClass.Magic) += 0.25f;
            player.statLifeMax2 += 15;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.GoldDust, 15)
                .AddIngredient(ItemID.Star, 5)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}