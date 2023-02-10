using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using WorhyMod.Items.Armor.Chestplates;
using WorhyMod.Items.Armor.Shoes;

namespace WorhyMod.Items.Armor.Helm
{
    [AutoloadEquip(EquipType.Head)]
    public class AmberHelm : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Amber upgrade.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;

        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 1);
            Item.rare = ItemRarityID.Orange;
            Item.defense = 5;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<AmberBreastplate>() && legs.type == ModContent.ItemType<AmberLeggins>();
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases dealt damage by 20%";
            player.GetDamage(DamageClass.Generic) += 0.2f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Amber, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}