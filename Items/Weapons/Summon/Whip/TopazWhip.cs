using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.SummonP.WhipP;

namespace WorhyMod.Items.Weapons.Summon.Whip
{
    public class TopazWhip : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.DefaultToWhip(ModContent.ProjectileType<TopazWhipProjectile>(), 8, 3, 6);

            Item.shootSpeed = 4;
            Item.rare = ItemRarityID.Red;

            Item.channel = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Topaz, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }

        public override bool MeleePrefix()
        {
            return true;
        }
    }
}