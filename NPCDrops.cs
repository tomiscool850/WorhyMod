
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;
using WorhyMod.Items.Accessories.RangerA;
using WorhyMod.Items.Materials;
using WorhyMod.Items.Food;
using WorhyMod.Items.Weapons.Summon.Minions;
using WorhyMod.Items.Weapons.Melee.Racket;
using WorhyMod.Items.Weapons.Melee.Spear;

namespace ExampleMod.Common.GlobalNPCs
{

    public class NPCDrops : GlobalNPC
    {

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Zombie)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<KetaminePills>(), 1));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ZombieRacket>(), 1));
            }
            if (npc.type == NPCID.TheDestroyer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ReinforcedSoul>(), 2));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MecanicalParts>(), 5));
            }
            if (npc.type == NPCID.SkeletronPrime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ReinforcedSoul>(), 2));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MecanicalParts>(), 5));
            }
            if (npc.type == NPCID.Retinazer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ReinforcedSoul>(), 2));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MecanicalParts>(), 5));
            }
            if (npc.type == NPCID.Spazmatism)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<ReinforcedSoul>(), 2));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MecanicalParts>(), 5));
            }
            if (npc.type == NPCID.Plantera)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BlackGoo>(), 8));
            }
            if (npc.type == NPCID.CaveBat)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BlueCandie>()));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<RedCandie>()));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GreenCandie>()));
            }
            if (npc.type == NPCID.BloodJelly)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<BlueCandie>()));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<RedCandie>()));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GreenCandie>()));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.WallCreeper)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<DoritoTaco>()));
            }
            if (npc.type == NPCID.GoblinArcher)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GoblinHeldToBat>()));
            }
            if (npc.type == NPCID.GoblinScout)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GoblinHeldToBat>()));
            }
            if (npc.type == NPCID.GoblinSorcerer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GoblinHeldToBat>()));
            }
            if (npc.type == NPCID.GoblinSummoner)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GoblinHeldToBat>()));

            }
            if (npc.type == NPCID.GoblinThief)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GoblinHeldToBat>()));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GoblinSpear>()));

            }
            if (npc.type == NPCID.GoblinWarrior)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GoblinHeldToBat>()));
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<GoblinSpear>()));
            }
            if (npc.type == NPCID.BloodMummy)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.Herpling)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.Crimslime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.BloodFeeder)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.CrimsonAxe)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.IchorSticker)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.FloatyGross)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.BigMimicCrimson)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.PigronCrimson)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.Corruptor)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.CorruptSlime)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.Slimeling)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.DesertGhoulCorruption)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.DesertGhoulCrimson)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.Slimer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.Slimer2)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.SeekerHead)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.DarkMummy)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.SandsharkCrimson)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueTissuesSamples>()));
            }
            if (npc.type == NPCID.CursedHammer)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.SandsharkCorrupt)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.Clinger)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.PigronCorruption)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
            if (npc.type == NPCID.BigMimicCorruption)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueShadowScales>()));
            }
        }
    }
}