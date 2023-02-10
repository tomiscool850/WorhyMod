using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.MeleeP.ShortswordP;

namespace WorhyMod.Items.Weapons.Melee.Shortsword
{
    public class AmberShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amber Shortsword");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 14;
            Item.knockBack = 3f;
            Item.useStyle = ItemUseStyleID.Rapier;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.width = 32;
            Item.height = 32;
            Item.UseSound = SoundID.Item1;
            Item.DamageType = DamageClass.MeleeNoSpeed;
            Item.autoReuse = true;
            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.rare = ItemRarityID.White;
            Item.value = Item.sellPrice(0, 2, 25, 0);

            Item.shoot = ModContent.ProjectileType<AmberShortswordProjectile>();
            Item.shootSpeed = 2.2f;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Amber, 6)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}