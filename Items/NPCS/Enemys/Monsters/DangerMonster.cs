using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader.Utilities;
using Terraria.DataStructures;

namespace WorhyMod.Items.NPCS.Enemys.Monsters
{
    public class DangerMonster : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Danger Monster");

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
            NPC.damage = 20;
            NPC.defense = 12;
            NPC.lifeMax = 200;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath2;
            NPC.value = 200f;
            NPC.knockBackResist = 0.2f;
            NPC.aiStyle = 3;

            AIType = NPCID.Zombie;
            AnimationType = NPCID.BlueSlime;
            Banner = Item.NPCtoBanner(NPCID.SwampThing);
            BannerItem = Item.BannerToItem(Banner);
        }

        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            var zombieDropRules = Main.ItemDropsDB.GetRulesForNPCID(NPCID.BoneLee, true);
            foreach (var zombieDropRule in zombieDropRules)
            {
                npcLoot.Add(zombieDropRule);
            }
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return SpawnCondition.OverworldNightMonster.Chance * 0.1f;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.NightTime,
                new FlavorTextBestiaryInfoElement("Danger Monster, a mix of Monster with reinforced fragments making a powerful entity")
            });
        }

    }
}