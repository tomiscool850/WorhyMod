using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Armor.Chestplates
{
    [AutoloadEquip(EquipType.Body)]
    public class PlasticChainmail : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Plastic Chainmain");
            Tooltip.SetDefault("Plastic Armor for a upgrade.");

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
            player.GetDamage(DamageClass.Ranged) += 0.2f;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Plastic>(25)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}