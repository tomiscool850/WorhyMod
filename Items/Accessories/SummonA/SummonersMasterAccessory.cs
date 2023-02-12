using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Accessories.SummonA
{
    public class SummonersMasterAccessory : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A New Star of a Summoner but omega.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 28;
            Item.value = Item.buyPrice(10);
            Item.rare = ItemRarityID.Orange;
            Item.accessory = true;

            Item.defense = 15;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Summon) += 5f;
            player.maxMinions += 40;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LunarBar, 25)
                .AddIngredient<SummonersExtraStar>(5)
                .AddIngredient<ReinforcedSoul>(20)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}