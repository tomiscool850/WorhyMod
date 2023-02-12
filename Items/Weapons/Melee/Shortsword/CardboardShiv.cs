using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;
using WorhyMod.Items.Projectiles.MeleeP.ShortswordP;

namespace WorhyMod.Items.Weapons.Melee.Shortsword
{
    public class CardboardShiv : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cardboard Shiv");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 6;
            Item.knockBack = 1f;
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.useAnimation = 25;
            Item.useTime = 25;
            Item.width = 32;
            Item.height = 32;
            Item.UseSound = SoundID.Item1;
            Item.DamageType = DamageClass.MeleeNoSpeed;
            Item.autoReuse = false;
            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 2, 25, 0);

            Item.shoot = ModContent.ProjectileType<CardboardShivProjectile>();
            Item.shootSpeed = 2.2f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<Cardboard>(5)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}