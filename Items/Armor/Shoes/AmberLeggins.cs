using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace WorhyMod.Items.Armor.Shoes
{
    [AutoloadEquip(EquipType.Legs)]
    public class AmberLeggins : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Amber Upgrade.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 1);
            Item.rare = ItemRarityID.Orange;
            Item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.05f;
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