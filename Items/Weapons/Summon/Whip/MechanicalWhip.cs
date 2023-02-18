using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;
using WorhyMod.Items.Projectiles.SummonP.WhipP;

namespace WorhyMod.Items.Weapons.Summon.Whip
{
    public class MechanicalWhip : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.DefaultToWhip(ModContent.ProjectileType<MechanicalWhipProjectile>(), 61, 5, 8);

            Item.shootSpeed = 5;
            Item.rare = ItemRarityID.Green;

            Item.channel = true;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<MecanicalParts>(8)
                .AddTile(TileID.Anvils)
                .Register();
        }

        public override bool MeleePrefix()
        {
            return true;
        }
    }
}