using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Accessories.MeleeA
{
    [AutoloadEquip(EquipType.Shoes)]
    public class MecanicalBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Made by the fastest beings.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.buyPrice(10);
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;

        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.accRunSpeed += 7;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<MecanicalBoots>(25)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}