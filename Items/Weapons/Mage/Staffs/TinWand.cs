using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Weapons.Mage.Staffs
{
	public class TinWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Some Wand lol");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 7;
			Item.DamageType = DamageClass.Magic;
			Item.width = 34;
			Item.height = 40;
			Item.scale = 1.2f;
			Item.useTime = 18;
			Item.useAnimation = 18;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.knockBack = 6;
			Item.rare = ItemRarityID.Yellow;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.TopazBolt;
			Item.shootSpeed = 7;
			Item.crit = 8;
			Item.mana = 4;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.TinBar, 8)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}