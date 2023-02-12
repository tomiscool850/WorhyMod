using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Melee.Claws
{
    public class AmberClaws : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Clawwing enemys.");

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
            Item.damage = 17;
            Item.knockBack = 1f;
            Item.crit = 6;

            Item.value = Item.buyPrice(silver: 10);
            Item.UseSound = SoundID.Item1;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Amber, 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}