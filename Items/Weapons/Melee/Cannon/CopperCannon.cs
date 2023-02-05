using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Melee.Cannon
{
    public class CopperCannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Cannon of Copper");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 9;
            Item.DamageType = DamageClass.Magic;
            Item.width = 34;
            Item.height = 40;
            Item.useTime = 18;
            Item.scale = 1.2f;
            Item.useAnimation = 18;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 6;
            Item.rare = ItemRarityID.Orange;
            Item.UseSound = SoundID.Item71;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.BoxingGlove;
            Item.shootSpeed = 15;
            Item.crit = 12;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.CopperBar, 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}