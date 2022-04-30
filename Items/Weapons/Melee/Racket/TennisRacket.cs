using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Melee.Racket
{
	public class TennisRacket : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("become a great tennis player my son:)");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 16;
			Item.useAnimation = 16;
			Item.autoReuse = true;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 24;
			Item.knockBack = 3.5f;
			Item.crit = 3;

			Item.value = Item.buyPrice(gold: 2);
			Item.rare = ItemRarityID.Red;
			Item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.WhiteString, 2)
				.AddIngredient(ItemID.Lens)
				.AddIngredient(ItemID.IronBar, 12)
				.AddTile(TileID.Anvils)
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.WhiteString, 2)
				.AddIngredient(ItemID.Lens)
				.AddIngredient(ItemID.LeadBar, 12)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}