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
    public class RubberHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Plastic upgrade.");

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
            return body.type == ModContent.ItemType<RubberChainmail>() && legs.type == ModContent.ItemType<RubberGreaves>();
        }
        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increases ranged damage by 20%";
            player.GetDamage(DamageClass.Ranged) += 0.2f;
            player.statDefense += 5;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Rubber>(15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}