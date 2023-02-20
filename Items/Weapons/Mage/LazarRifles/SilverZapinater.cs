using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Mage.LazarRifles
{
    public class SilverZapinater : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Some Lazar lol");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 16;
            Item.DamageType = DamageClass.Magic;
            Item.width = 34;
            Item.height = 40;
            Item.useTime = 19;
            Item.scale = 1.2f;
            Item.useAnimation = 19;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 6;
            Item.rare = ItemRarityID.Orange;
            Item.UseSound = SoundID.Item71;
            Item.autoReuse = false;
            Item.shoot = ProjectileID.GreenLaser;
            Item.shootSpeed = 6;
            Item.crit = 12;
            Item.mana = 7;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SilverBar, 8)
                .AddIngredient(ItemID.ZapinatorGray)
                .AddTile(TileID.Anvils)
                .Register();

            CreateRecipe()
                .AddIngredient(ItemID.SilverBar, 8)
                .AddIngredient(ItemID.ZapinatorOrange)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}