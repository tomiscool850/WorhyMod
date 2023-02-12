using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace WorhyMod.Items.Materials
{
    public class BlackGoo : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Black Goo");
            Tooltip.SetDefault("Use this for black gooo");

            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(6, 6));
            ItemID.Sets.AnimatesAsSoul[Item.type] = true;

            ItemID.Sets.ItemIconPulse[Item.type] = true;
            ItemID.Sets.ItemNoGravity[Item.type] = true;

            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 25;
        }

        public override void SetDefaults()
        {
            Item.width = 18;
            Item.scale = 2f;
            Item.height = 18;
            Item.maxStack = 999;
            Item.value = 20000;
            Item.rare = ItemRarityID.Blue;
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(Item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale);
        }
    }
}