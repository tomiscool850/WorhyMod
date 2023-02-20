using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.OtherStuff
{
    public class DotlessGolfBall : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.shoot = ProjectileID.DirtGolfBall;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.shootSpeed = 12f;
            Item.width = 18;
            Item.height = 20;
            Item.maxStack = 1;
            Item.UseSound = SoundID.Item1;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.value = Item.buyPrice(0, 0, 0, 0);
            Item.accessory = true;
            Item.rare = ItemRarityID.Green;
            Item.canBePlacedInVanityRegardlessOfConditions = true;
        }
    }
}