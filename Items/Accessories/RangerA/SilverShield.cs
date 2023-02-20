using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Accessories.RangerA
{
    [AutoloadEquip(EquipType.Shield)]
    public class SilverShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shield of Silver.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.buyPrice(10);
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;

            Item.defense = 4;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Ranged) += 0.27f;
            player.endurance = 0.3f - (0.05f * (0.5f - player.endurance));
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SilverBar, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}