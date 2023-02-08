using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Projectiles.SummonP.WhipP;

namespace WorhyMod.Items.Weapons.Summon.Whip
{
    public class RubyWhip : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.DefaultToWhip(ModContent.ProjectileType<RubyWhipProjectile>(), 12, 3, 6);

            Item.shootSpeed = 4;
            Item.rare = ItemRarityID.Red;

            Item.channel = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Ruby, 15)
                .AddTile(TileID.Anvils)
                .Register();
        }

        public override bool MeleePrefix()
        {
            return true;
        }
    }
}