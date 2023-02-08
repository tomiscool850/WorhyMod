using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.MeleeP.SpearP;
using WorhyMod.Items.Projectiles.MageP.WandP;
using WorhyMod.Items.Projectiles.MageP.TomeP;

namespace WorhyMod.Items.Weapons.Mage.Tomes
{
    public class IceBolt : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Casts a Slow moving bolt of Ice");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 26;
            Item.DamageType = DamageClass.Magic;
            Item.width = 34;
            Item.height = 40;
            Item.useTime = 15;
            Item.scale = 1.2f;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 6;
            Item.rare = ItemRarityID.Cyan;
            Item.UseSound = SoundID.Item71;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<IceBoltProjectile>();
            Item.shootSpeed = 3;
            Item.crit = 12;
            Item.mana = 12;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.IceBlock, 25)
                .AddIngredient(ItemID.SnowBlock, 25)
                .AddIngredient(ItemID.FrostCore)
                .AddIngredient(ItemID.WaterBolt)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}