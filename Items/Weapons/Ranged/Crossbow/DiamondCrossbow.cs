using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Ranged.Crossbow
{
    public class DiamondCrossbow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Diamond Crossbow");

            Tooltip.SetDefault("This Crossbow be hitting diffrent");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 62;
            Item.height = 32;
            Item.scale = 1.2f;
            Item.rare = ItemRarityID.White;

            Item.useTime = 24;
            Item.useAnimation = 24;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;
            Item.UseSound = SoundID.Item11;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 23;
            Item.knockBack = 2f;
            Item.noMelee = true;

            Item.shoot = ProjectileID.WoodenArrowFriendly;
            Item.shootSpeed = 8f;
            Item.useAmmo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Diamond, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(2f, -2f);
        }
    }
}