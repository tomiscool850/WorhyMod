using WorhyMod.Items.Projectiles.MeleeP.SpearP;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Melee.Spear
{
	public class TinSpear : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Spear of Tin is... kinda bad, but also ok(use a better one)");

			ItemID.Sets.SkipsInitialUseSound[Item.type] = true;
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.rare = ItemRarityID.Yellow;
			Item.value = Item.sellPrice(silver: 2);


			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 16;
			Item.useTime = 16;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = false;

			Item.damage = 9;
			Item.knockBack = 3.2f;
			Item.noUseGraphic = true;
			Item.noMelee = true;

			Item.shootSpeed = 4.2f;
			Item.shoot = ModContent.ProjectileType<TinSpearProjectile>();
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
				.AddIngredient(ItemID.TinBar, 9)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}