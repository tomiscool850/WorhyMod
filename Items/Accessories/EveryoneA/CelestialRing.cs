using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Accessories.EveryoneA
{
    public class CelestialRing : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Ring Made by the fragments of moonlord.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.buyPrice(10);
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;

            Item.defense = 8;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 2f;
            player.statLifeMax2 += 50;
            player.maxMinions += 5;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.FragmentSolar, 15)
                .AddIngredient(ItemID.FragmentNebula, 15)
                .AddIngredient(ItemID.FragmentStardust, 15)
                .AddIngredient(ItemID.FragmentVortex, 15)
                .AddIngredient(ItemID.LunarBar, 20)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
    }
}