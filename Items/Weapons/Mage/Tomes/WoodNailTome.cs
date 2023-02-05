using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.MeleeP.SpearP;
using WorhyMod.Items.Projectiles.MageP.WandP;
using WorhyMod.Items.Projectiles.MageP.TomeP;

namespace WorhyMod.Items.Weapons.Mage.Tomes
{
    public class WoodNailTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots Wood Nails");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 6;
            Item.DamageType = DamageClass.Magic;
            Item.width = 34;
            Item.height = 40;
            Item.useTime = 8;
            Item.scale = 1.2f;
            Item.useAnimation = 8;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.noMelee = true;
            Item.knockBack = 6;
            Item.rare = ItemRarityID.Gray;
            Item.UseSound = SoundID.Item71;
            Item.autoReuse = false;
            Item.shoot = ModContent.ProjectileType<WoodNailProjectile>();
            Item.shootSpeed = 15;
            Item.crit = 12;
            Item.mana = 2;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Wood, 20)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}