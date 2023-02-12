using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Melee.Katana
{
    public class WoodKatana : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Faster Wood");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 15;
            Item.useAnimation = 15;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 4;
            Item.knockBack = 0.3f;
            Item.crit = 3;

            Item.value = Item.buyPrice(copper: 75);
            Item.rare = ItemRarityID.Gray;
            Item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Wood, 8)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}