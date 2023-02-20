using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.SummonP.WhipP;

namespace WorhyMod.Items.Weapons.Summon.Whip
{
    public class ChainWhip : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.DefaultToWhip(ModContent.ProjectileType<ChainWhipProjectile>(), 8, 2, 2);

            Item.shootSpeed = 4;
            Item.rare = ItemRarityID.Green;

            Item.channel = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Chain, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }

        public override bool MeleePrefix()
        {
            return true;
        }
    }
}