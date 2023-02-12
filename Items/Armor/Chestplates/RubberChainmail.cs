using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Armor.Chestplates
{
    [AutoloadEquip(EquipType.Body)]
    public class RubberChainmail : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Rubber Chainmain");
            Tooltip.SetDefault("Rubber Armor for a upgrade.");

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
            player.GetDamage(DamageClass.Melee) += 0.2f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Rubber>(25)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}