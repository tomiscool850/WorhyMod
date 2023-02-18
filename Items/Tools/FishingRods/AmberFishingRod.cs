using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace WorhyMod.Items.Tools.FishingRods
{
    public class AmberFishingRod : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amber Fishing Rod");
            Tooltip.SetDefault("Wow fishing with Amber.\n" +
                "The fishing line never snaps.");

            ItemID.Sets.CanFishInLava[Item.type] = true;
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {

            Item.CloneDefaults(ItemID.WoodFishingPole);

            Item.fishingPole = 100;
            Item.shootSpeed = 12f;
            Item.shoot = ModContent.ProjectileType<Projectiles.Bobbers.AmberBobber>();
        }
        public override void HoldItem(Player player)
        {
            player.accFishingLine = true;
        }
        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            int bobberAmount = Main.rand.Next(3, 5);
            float spreadAmount = 75f;

            for (int index = 0; index < bobberAmount; ++index)
            {
                Vector2 bobberSpeed = velocity + new Vector2(Main.rand.NextFloat(-spreadAmount, spreadAmount) * 0.05f, Main.rand.NextFloat(-spreadAmount, spreadAmount) * 0.05f);

                Projectile.NewProjectile(source, position, bobberSpeed, type, 0, 0f, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Amber, 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}