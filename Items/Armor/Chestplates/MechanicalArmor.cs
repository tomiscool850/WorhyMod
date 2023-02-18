using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Armor.Chestplates
{
    [AutoloadEquip(EquipType.Body)]
    public class MechanicalArmor : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Mechanical Armor");
            Tooltip.SetDefault("Mechanical parts for the best things.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.height = 18;
            Item.value = Item.sellPrice(gold: 1);
            Item.rare = ItemRarityID.Orange;
            Item.defense = 13;
        }

        public override void UpdateEquip(Player player)
        {
            player.GetDamage(DamageClass.Summon) += 0.5f;
            player.statManaMax2 += 25;
            player.maxMinions += 3;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<MecanicalParts>(20)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}