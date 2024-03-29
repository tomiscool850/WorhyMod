using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Ranged.Guns.Pistals
{
    public class LeadGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Gun of Lead ik wouldnt expect this.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 62;
            Item.height = 32;
            Item.scale = 1.5f;
            Item.rare = ItemRarityID.Orange;

            Item.useTime = 12;
            Item.useAnimation = 12;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = false;
            Item.UseSound = SoundID.Item11;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 11;
            Item.knockBack = 2f;
            Item.noMelee = true;

            Item.shoot = ProjectileID.Bullet;
            Item.shootSpeed = 12f;
            Item.useAmmo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LeadBar, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(2f, -2f);
        }
    }
}