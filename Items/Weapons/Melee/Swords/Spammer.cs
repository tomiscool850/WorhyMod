using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Melee.Swords
{
    public class Spammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Spams.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 2;
            Item.useAnimation = 2;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 5;
            Item.knockBack = 1;
            Item.crit = 6;

            Item.value = Item.buyPrice(gold: 2);
            Item.UseSound = SoundID.Item1;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.BlackLens)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}