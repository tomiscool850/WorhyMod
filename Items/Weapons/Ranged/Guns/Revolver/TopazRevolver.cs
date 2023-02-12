using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Ranged.Guns.Revolver
{
    public class TopazRevolver : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Topaz Revolver");

            Tooltip.SetDefault("Shoot Bam");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 62;
            Item.height = 32;
            Item.scale = 1.2f;
            Item.rare = ItemRarityID.White;

            Item.useTime = 50;
            Item.useAnimation = 50;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = false;
            Item.UseSound = SoundID.Item11;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 28;
            Item.knockBack = 3f;
            Item.noMelee = true;

            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 15f;
            Item.useAmmo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Topaz, 25)
                .AddTile(TileID.Anvils)
                .Register();
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(2f, -2f);
        }
    }
}