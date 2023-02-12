using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Armor.Shoes
{
    [AutoloadEquip(EquipType.Legs)]
    public class PlasticGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Plastic Upgrade.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 1);
            Item.rare = ItemRarityID.Orange;
            Item.defense = 4;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed += 0.1f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Plastic>(15)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}