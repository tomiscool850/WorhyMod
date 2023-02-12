using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using WorhyMod.Items.Materials;
using WorhyMod.Items.Weapons.Ranged.Guns.Pistals;

namespace WorhyMod
{
    class NewNPCShops : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Dryad)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<EraserPowder>());
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<EraserPowder>());
                nextSlot++;
            }
            if (type == NPCID.Cyborg)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<ReinforcedSoul>());
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<BlackGoo>());
                nextSlot++;
            }
            if (type == NPCID.Merchant)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<PlatinumDust>());
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Toys>());
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<BrokenToys>());
                nextSlot++;
            }
            if (type == NPCID.ArmsDealer)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Comfifteen>());
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Boomstick);
                nextSlot++;
            }

            else if (type == NPCID.ArmsDealer)
            {
                if (Main.masterMode)
                {

                    shop.item[nextSlot].SetDefaults(ModContent.ItemType<Hellshot>());
                    nextSlot++;
                }
            }
            if (type == NPCID.GoblinTinkerer)
            {
                shop.item[nextSlot].SetDefaults(ItemID.Toilet);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Ruby);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Amber);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Amethyst);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Sapphire);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Diamond);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Emerald);
                nextSlot++;
                shop.item[nextSlot].SetDefaults(ItemID.Topaz);
                nextSlot++;
            }
        }
    }
}