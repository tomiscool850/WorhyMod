using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Mage.LazarRifles
{
    public class LavaShooter : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Some Lava lol");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 15;
            Item.DamageType = DamageClass.Magic;
            Item.width = 34;
            Item.height = 40;
            Item.useTime = 25;
            Item.scale = 1.2f;
            Item.useAnimation = 25;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 6;
            Item.rare = ItemRarityID.Orange;
            Item.UseSound = SoundID.Item71;
            Item.autoReuse = true;
            Item.shoot = ProjectileID.SlimeGun;
            Item.shootSpeed = 6;
            Item.crit = 12;
            Item.mana = 12;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LavaBomb)
                .AddIngredient(ItemID.SlimeGun)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}