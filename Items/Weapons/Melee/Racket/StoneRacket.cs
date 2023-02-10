using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Melee.Racket
{
	public class StoneRacket : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Tennis player i do belive Stone BAD tho.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 24;
			Item.useAnimation = 24;
			Item.autoReuse = true;

            Item.DamageType = ModContent.GetInstance<TennisClass>();
            Item.damage = 11;
			Item.knockBack = 3;
			Item.crit = 2;

			Item.value = Item.buyPrice(silver: 1);
			Item.rare = ItemRarityID.Gray;
			Item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.StoneBlock, 8)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}