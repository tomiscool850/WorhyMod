
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;
using WorhyMod.Items.Accessories.RangerA;
using WorhyMod.Items.Materials;

namespace ExampleMod.Common.GlobalNPCs
{

    public class NPCDrops : GlobalNPC
    {

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Zombie)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KetaminePills>(), 1));
            }
            if (npc.type == NPCID.TheDestroyer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ReinforcedSoul>(), 2));
            }
            if (npc.type == NPCID.SkeletronPrime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ReinforcedSoul>(), 2));
            }
            if (npc.type == NPCID.Retinazer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ReinforcedSoul>(), 2));
            }
            if (npc.type == NPCID.Spazmatism)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ReinforcedSoul>(), 2));
            }
        }
    }
}