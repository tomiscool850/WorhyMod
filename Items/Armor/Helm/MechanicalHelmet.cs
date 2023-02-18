using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using WorhyMod.Items.Armor.Chestplates;
using WorhyMod.Items.Armor.Shoes;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Armor.Helm
{
    [AutoloadEquip(EquipType.Head)]
    public class MechanicalHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Mechanical upgrade.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 3;

        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 1);
            Item.rare = ItemRarityID.Orange;
            Item.defense = 13;
        }
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<MechanicalArmor>() && legs.type == ModContent.ItemType<MechanicalLeggins>();
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Lots of new mana and summon damage";
            player.GetDamage(DamageClass.Summon) += 0.2f;
            player.statManaMax2 += 25;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<MecanicalParts>(12)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}