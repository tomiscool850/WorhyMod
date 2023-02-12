using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Accessories.SummonA
{
    public class SummonersExtraStar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A New Star of a Summoner.");

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
            player.GetDamage(DamageClass.Summon) += 0.25f;
            player.maxMinions++;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.ManaCrystal, 3)
                .AddIngredient(ItemID.GoldDust, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}