using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.MeleeP.SpearP;
using WorhyMod.Items.Projectiles.MageP.WandP;

namespace WorhyMod.Items.Weapons.Mage.Staffs
{
    public class TheDirtWand : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The Wand i dont want");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 2;
            Item.DamageType = DamageClass.Magic;
            Item.width = 34;
            Item.height = 40;
            Item.useTime = 1;
            Item.scale = 1.2f;
            Item.useAnimation = 12;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 6;
            Item.rare = ItemRarityID.Orange;
            Item.UseSound = SoundID.Item71;
            Item.autoReuse = false;
            Item.shoot = ModContent.ProjectileType<TheDirtWandProjectile>();
            Item.shootSpeed = 15;
            Item.crit = 12;
            Item.mana = 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.DirtBlock, 50)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}