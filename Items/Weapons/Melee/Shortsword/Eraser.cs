using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;
using WorhyMod.Items.Projectiles.MeleeP.ShortswordP;

namespace WorhyMod.Items.Weapons.Melee.Shortsword
{
    public class Eraser : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cardboard Shiv");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 50;
            Item.knockBack = 1f;
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.useAnimation = 2;
            Item.useTime = 2;
            Item.width = 32;
            Item.height = 32;
            Item.UseSound = SoundID.Item1;
            Item.DamageType = DamageClass.MeleeNoSpeed;
            Item.autoReuse = true;
            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 2, 25, 0);

            Item.shoot = ModContent.ProjectileType<EraserProjectile>();
            Item.shootSpeed = 2.2f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<EraserDust>(15)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }
    }
}