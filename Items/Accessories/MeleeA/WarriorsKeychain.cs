using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Accessories.MeleeA
{
    public class WarriorsKeychain : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Keychain of a warrior.");

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
            player.GetDamage(DamageClass.Melee) += 0.25f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.GoldBar, 5)
                .AddIngredient(ItemID.Chain, 2)
                .AddTile(TileID.Anvils)
                .Register();

            CreateRecipe()
                .AddIngredient(ItemID.PlatinumBar, 5)
                .AddIngredient(ItemID.Chain, 2)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}