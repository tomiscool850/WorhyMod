using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Accessories.MeleeA
{
    [AutoloadEquip(EquipType.Shield)]
    public class TinShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shield of Tin.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.buyPrice(10);
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;

            Item.defense = 2;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Melee) += 0.2f;
            player.endurance = 1f - (0.1f * (1f - player.endurance));
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.TinBar, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}