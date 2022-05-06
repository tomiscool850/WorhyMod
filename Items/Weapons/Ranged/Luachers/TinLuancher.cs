using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Ranged.Luachers
{
	public class TinLuancher : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("a Yellow pretty Shot, reminds me of the oldern days");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 62;
			Item.height = 32;
			Item.rare = ItemRarityID.Yellow;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.autoReuse = false;
			Item.UseSound = SoundID.Item17;
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 8;
			Item.knockBack = 2f;
			Item.noMelee = true;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 10f;
			Item.useAmmo = AmmoID.Arrow;
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