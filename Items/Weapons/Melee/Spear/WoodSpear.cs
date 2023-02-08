using WorhyMod.Items.Projectiles.MeleeP.SpearP;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Melee.Spear
{
    public class WoodSpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Spear of Wood is... kinda bad, but also ok(use a better one)");

            ItemID.Sets.SkipsInitialUseSound[Item.type] = true;
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Orange;
            Item.value = Item.sellPrice(silver: 2);


            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAnimation = 18;
            Item.useTime = 18;
            Item.UseSound = SoundID.Item71;
            Item.autoReuse = false;

            Item.damage = 5;
            Item.knockBack = 2f;
            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 4.5f;
            Item.shoot = ModContent.ProjectileType<WoodSpearProjectile>();
        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[Item.shoot] < 1;
        }

        public override bool? UseItem(Player player)
        {
            if (!Main.dedServ)
            {
                SoundEngine.PlaySound(Item.UseSound, player.Center);
            }

            return null;
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Wood, 12)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}