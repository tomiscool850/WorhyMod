using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.MeleeP.SpearP;
using WorhyMod.Items.Projectiles.MageP.WandP;
using WorhyMod.Items.Projectiles.MageP.TomeP;

namespace WorhyMod.Items.Weapons.Mage.Tomes
{
    public class LeadTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A tome of Lead");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 13;
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
            Item.autoReuse = false;
            Item.shoot = ModContent.ProjectileType<LeadTomeProjectile>();
            Item.shootSpeed = 15;
            Item.crit = 12;
            Item.mana = 6;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LeadBar, 12)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}