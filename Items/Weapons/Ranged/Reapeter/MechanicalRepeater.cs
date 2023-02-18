using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;

namespace WorhyMod.Items.Weapons.Ranged.Reapeter
{
	public class MechanicalRepeater : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Repeater of Metals");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 62;
			Item.height = 32;
			Item.rare = ItemRarityID.Orange;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.autoReuse = true;
			Item.UseSound = SoundID.Item17;
			Item.DamageType = DamageClass.Ranged;
			Item.damage = 51;
			Item.knockBack = 2f;
			Item.noMelee = true;
			Item.shoot = ProjectileID.WoodenArrowFriendly;
			Item.shootSpeed = 8f;
			Item.useAmmo = AmmoID.Arrow;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient<MecanicalParts>(15)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}