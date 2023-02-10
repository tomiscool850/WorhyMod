using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using WorhyMod.Items.Armor.Chestplates;
using WorhyMod.Items.Armor.Shoes;

namespace WorhyMod.Items.Armor.Helm
{
    [AutoloadEquip(EquipType.Head)]
    public class TopazHelm : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Topaz upgrade.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;

        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 1);
            Item.rare = ItemRarityID.Orange;
            Item.defense = 4;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<TopazBreastplate>() && legs.type == ModContent.ItemType<TopazLeggins>();
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases dealt damage by 20%";
            player.GetDamage(DamageClass.Generic) += 0.2f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Topaz, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}