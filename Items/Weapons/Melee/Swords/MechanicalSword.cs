using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Melee.Swords
{
    public class MechanicalSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("ID plz.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.scale = 2f;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 56;
            Item.knockBack = 1.5f;
            Item.crit = 6;

            Item.value = Item.buyPrice(gold: 1);
            Item.UseSound = SoundID.Item1;
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<MecanicalParts>(12)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}