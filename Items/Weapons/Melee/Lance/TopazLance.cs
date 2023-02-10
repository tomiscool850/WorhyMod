using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria.Enums;
using Terraria.Localization;
using Terraria.ID;

namespace WorhyMod.Items.Weapons.Melee.Lance
{
    public class TopazLance : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault(Language.GetTextValue("ItemTooltip.HallowJoustingLance") + "\nYEEEE.");

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {

            Item.DefaultToSpear(ModContent.ProjectileType<Projectiles.MeleeP.LanceP.TopazLanceProjectile>(), 1f, 24);

            Item.DamageType = DamageClass.MeleeNoSpeed;

            Item.SetWeaponValues(26, 5.2f, 2);

            Item.SetShopValues(ItemRarityColor.LightRed4, Item.buyPrice(0, 6));

            Item.channel = true;
            Item.StopAnimationOnHurt = true;
        }

        public override bool MeleePrefix()
        {
            return true;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Topaz, 18)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}