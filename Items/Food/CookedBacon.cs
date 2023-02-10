using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Food
{
    public class CookedBacon : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cooked Bacon");
            Tooltip.SetDefault("{$CommonItemTooltip.MediumStats}\n'Cooked Pork'");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 5;

            Main.RegisterItemAnimation(Type, new DrawAnimationVertical(int.MaxValue, 3));

            ItemID.Sets.FoodParticleColors[Item.type] = new Color[3] {
                new Color(249, 230, 136),
                new Color(152, 93, 95),
                new Color(174, 192, 192)
            };

            ItemID.Sets.IsFood[Type] = true;
        }

        public override void SetDefaults()
        {

            Item.DefaultToFood(22, 22, BuffID.WellFed3, 57600);
            Item.value = Item.buyPrice(0, 3);
            Item.rare = ItemRarityID.Blue;
        }

        public override void OnConsumeItem(Player player)
        {
            player.AddBuff(BuffID.SugarRush, 3600);
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Bacon)
                .AddTile(TileID.Furnaces)
                .Register();
        }
    }
}