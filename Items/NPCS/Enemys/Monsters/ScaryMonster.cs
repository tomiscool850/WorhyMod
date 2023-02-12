using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader.Utilities;
using Terraria.DataStructures;
using WorhyMod.Items.Materials;
using WorhyMod.Items.Accessories.RangerA;

namespace WorhyMod.Items.NPCS.Enemys.Monsters
{
    public class ScaryMonster : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Scary Monster");

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
            NPC.defense = 20;
            NPC.lifeMax = 550;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath2;
            NPC.value = 200;
            NPC.knockBackResist = 0.5f;
            NPC.aiStyle = NPCID.Zombie;

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
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<MonsterFur>(), 2));
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Main.hardMode)
            {
                return SpawnCondition.OverworldNightMonster.Chance * 0.3f;
            }
            return SpawnCondition.OverworldNightMonster.Chance * 0f;
        }
        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Times.NightTime,
                new FlavorTextBestiaryInfoElement("a new enemy type also called the same thing as every other enemy, be careful there strong btw, this man scary.")
            });
        }

    }
}