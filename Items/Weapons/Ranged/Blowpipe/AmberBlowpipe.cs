using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Ranged.Blowpipe
{
    public class AmberBlowpipe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amber Blowpipe");

            Tooltip.SetDefault("Blowpipe Sussy.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 62;
            Item.height = 32;
            Item.rare = ItemRarityID.Orange;

            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.autoReuse = true;
            Item.UseSound = SoundID.Item11;

            Item.DamageType = DamageClass.Ranged;
            Item.damage = 12;
            Item.knockBack = 1.5f;
            Item.noMelee = true;

            Item.shoot = ProjectileID.PurificationPowder;
            Item.shootSpeed = 12f;
            Item.useAmmo = AmmoID.Dart;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Amber, 12)
                .AddIngredient<BlowpipeCore>()
                .AddTile(TileID.Anvils)
                .Register();
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(2f, -2f);
        }
    }
}