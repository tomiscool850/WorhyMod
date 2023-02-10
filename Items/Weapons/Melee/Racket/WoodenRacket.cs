using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Melee.Racket
{
	public class WoodenRacket : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Tennis player i do belive wood GOOD tho."); 

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;

			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTime = 25;
			Item.useAnimation = 25;
			Item.autoReuse = true;

            Item.DamageType = ModContent.GetInstance<TennisClass>();
            Item.damage = 7;
			Item.knockBack = 2;
			Item.crit = 2;

			Item.value = Item.buyPrice(copper: 50);
			Item.rare = ItemRarityID.Gray;
			Item.UseSound = SoundID.Item1;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Wood, 9)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}