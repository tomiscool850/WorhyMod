
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;
using WorhyMod.Items.Accessories.RangerA;

namespace ExampleMod.Common.GlobalNPCs
{

    public class NPCDrops : GlobalNPC
    {

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (!NPCID.Sets.Zombies[npc.type])
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KetaminePills>(), 1));
            }
        }
    }
}