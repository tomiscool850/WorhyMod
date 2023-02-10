using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.MeleeP.SpearP;
using WorhyMod.Items.Projectiles.MageP.WandP;

namespace WorhyMod.Items.Weapons.Mage.Staffs
{
    public class SpammerWand : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("I SWEAR DONT SPAM THE WAND");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 2;
            Item.DamageType = DamageClass.Magic;
            Item.width = 34;
            Item.height = 40;
            Item.useTime = 2;
            Item.scale = 1.2f;
            Item.useAnimation = 2;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 6;
            Item.rare = ItemRarityID.Orange;
            Item.UseSound = SoundID.Item71;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<SpammerWandProjectile>();
            Item.shootSpeed = 12;
            Item.crit = 12;
            Item.mana = 1;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.BlackLens)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}