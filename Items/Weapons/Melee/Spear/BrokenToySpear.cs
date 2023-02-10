using WorhyMod.Items.Projectiles.MeleeP.SpearP;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Melee.Spear
{
    public class BrokenToySpear : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Spear of Broken Toy, why did you break the spear");

            ItemID.Sets.SkipsInitialUseSound[Item.type] = true;
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.rare = ItemRarityID.Yellow;
            Item.value = Item.sellPrice(silver: 5);


            Item.useStyle = ItemUseStyleID.Shoot;
            Item.useAnimation = 21;
            Item.useTime = 21;
            Item.UseSound = SoundID.Item71;
            Item.autoReuse = false;

            Item.damage = 9;
            Item.knockBack = 3.2f;
            Item.noUseGraphic = true;
            Item.noMelee = true;

            Item.shootSpeed = 4.2f;
            Item.shoot = ModContent.ProjectileType<BrokenToySpearProjectile>();
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
                .AddIngredient<BrokenToys>(12)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}