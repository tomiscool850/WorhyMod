using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader.Utilities;
using Terraria.DataStructures;

namespace WorhyMod.Items.NPCS.Enemys.Slimes
{
    public class DiamondSlime : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Diamond Slime");

            Main.npcFrameCount[Type] = Main.npcFrameCount[NPCID.BlueSlime];

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
            NPC.damage = 12;
            NPC.defense = 11;
            NPC.lifeMax = 200;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath2;
            NPC.value = 75f;
            NPC.knockBackResist = 0.2f;
            NPC.aiStyle = 1;

            AIType = NPCID.BlueSlime;
            AnimationType = NPCID.BlueSlime;
            Banner = Item.NPCtoBanner(NPCID.BlueSlime);
            BannerItem = Item.BannerToItem(Banner);
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            var zombieDropRules = Main.ItemDropsDB.GetRulesForNPCID(NPCID.BlueSlime, true);
            foreach (var zombieDropRule in zombieDropRules)
            {
                npcLoot.Add(zombieDropRule);
            }
            npcLoot.Add(ItemDropRule.Common(ItemID.Diamond, 3));
            npcLoot.Add(ItemDropRule.Common(ItemID.Diamond));
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.Cavern.Chance * 0.1f;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.NightTime,
                new FlavorTextBestiaryInfoElement("Great for getting diamond, dont know why you would need that though to be hosnest.")
            });
        }

    }
}