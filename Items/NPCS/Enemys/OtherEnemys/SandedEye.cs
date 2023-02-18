using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader.Utilities;
using Terraria.DataStructures;

namespace WorhyMod.Items.NPCS.Enemys.OtherEnemys
{
    public class SandedEye : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sanded EYe");

            Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.DemonEye];

            NPCID.Sets.NPCBestiaryDrawModifiers value = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            {
                Velocity = 1f
            };
            NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, value);
        }

        public override void SetDefaults()
        {
            NPC.width = 18;
            NPC.height = 40;
            NPC.damage = 5;
            NPC.defense = 5;
            NPC.lifeMax = 80;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath2;
            NPC.value = 200f;
            NPC.knockBackResist = 0.2f;
            NPC.aiStyle = NPCID.DemonEye;

            AIType = NPCID.DemonEye;
            AnimationType = NPCID.DemonEye;
            Banner = Item.NPCtoBanner(NPCID.DemonEye);
            BannerItem = Item.BannerToItem(Banner);
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            var zombieDropRules = Main.ItemDropsDB.GetRulesForNPCID(NPCID.DemonEye, true);
            foreach (var zombieDropRule in zombieDropRules)
            {
                npcLoot.Add(zombieDropRule);
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldDayDesert.Chance * 0.1f;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.DayTime,
                new FlavorTextBestiaryInfoElement("Demon Eye that seems to be covered in sand, kind sus")
            });
        }

    }
}