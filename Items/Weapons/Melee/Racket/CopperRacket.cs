using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Melee.Racket
{
	public class CopperRacket : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("sometimes i do belive that one day tin or copper will be useful" +
				"but for now its just used for stupid weapons like this.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.autoReuse = true;

			Item.DamageType = DamageClass.Melee;
			Item.damage = 14;
			Item.knockBack = 3.5f;
			Item.crit = 3;

			Item.value = Item.buyPrice(silver: 5);
			Item.rare = ItemRarityID.Orange;
			Item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.CopperBar, 9)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}