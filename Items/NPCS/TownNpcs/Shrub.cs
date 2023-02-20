using Microsoft.Xna.Framework;
using System;
using System.Linq;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.Utilities;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.Personalities;
using Terraria.DataStructures;
using System.Collections.Generic;
using ReLogic.Content;
using Terraria.ModLoader.IO;
using WorhyMod.Items.Weapons.Melee.Swords;
using WorhyMod.Items.OtherStuff;
using WorhyMod.Items.Food;
using WorhyMod.Items.Pets;
using WorhyMod.Items.Weapons.Melee.Sythe;
using WorhyMod.Items.Placeables.PcStuff.GamingChair;
using WorhyMod.Items.Placeables.PcStuff.Pc;
using WorhyMod.Items.Placeables.PcStuff.Setup;
using WorhyMod.Items.Vanity.VanityHead;
using WorhyMod.Items.Vanity.VanityBody;
using WorhyMod.Items.Projectiles.MeleeP.SwordP;
using WorhyMod.Items.Projectiles.MeleeP.FlailP;

namespace WorhyMod.Items.NPCS.TownNpcs
{
    [AutoloadHead]
    public class Shrub : ModNPC
    {
        public int NumberOfTimesTalkedTo = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shrub");
            Main.npcFrameCount[Type] = 25;

            NPCID.Sets.ExtraFramesCount[Type] = 9;
            NPCID.Sets.AttackFrameCount[Type] = 4;
            NPCID.Sets.DangerDetectRange[Type] = 700;
            NPCID.Sets.AttackType[Type] = 0;
            NPCID.Sets.AttackTime[Type] = 90;
            NPCID.Sets.AttackAverageChance[Type] = 30;
            NPCID.Sets.HatOffsetY[Type] = 4;

            NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers = new NPCID.Sets.NPCBestiaryDrawModifiers(0)
            {
                Velocity = 1f,
                Direction = 1
            };

            NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, drawModifiers);

            NPC.Happiness
                .SetBiomeAffection<ForestBiome>(AffectionLevel.Love)
                .SetBiomeAffection<SnowBiome>(AffectionLevel.Like)
                .SetBiomeAffection<DesertBiome>(AffectionLevel.Hate)
                .SetBiomeAffection<JungleBiome>(AffectionLevel.Like)
                .SetNPCAffection(NPCID.Dryad, AffectionLevel.Love)
                .SetNPCAffection(NPCID.Guide, AffectionLevel.Like)
                .SetNPCAffection(NPCID.ArmsDealer, AffectionLevel.Like)
                .SetNPCAffection(NPCID.Demolitionist, AffectionLevel.Like)
                .SetNPCAffection(NPCID.Truffle, AffectionLevel.Hate)
                .SetNPCAffection(NPCID.GoblinTinkerer, AffectionLevel.Dislike)
            ;
        }

        public override void SetDefaults()
        {
            NPC.townNPC = true;
            NPC.friendly = true;
            NPC.width = 18;
            NPC.height = 40;
            NPC.aiStyle = 7;
            NPC.damage = 10;
            NPC.defense = 15;
            NPC.lifeMax = 250;
            NPC.HitSound = SoundID.NPCHit1;
            NPC.DeathSound = SoundID.NPCDeath1;
            NPC.knockBackResist = 0.5f;

            AnimationType = NPCID.Guide;
        }

        public override void SetBestiary(BestiaryDatabase database, BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.Info.AddRange(new IBestiaryInfoElement[] {
                BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Surface,

                new FlavorTextBestiaryInfoElement("Shrub a magical bush the came to life one day, dont queston it.."),

                new FlavorTextBestiaryInfoElement("Something about shrub isnt right, hes alive")
            });
        }

        public override bool PreDraw(SpriteBatch spriteBatch, Vector2 screenPos, Color drawColor)
        {
            if (NPCID.Sets.NPCBestiaryDrawOffset.TryGetValue(Type, out NPCID.Sets.NPCBestiaryDrawModifiers drawModifiers))
            {
                drawModifiers.Rotation += 0.001f;

                NPCID.Sets.NPCBestiaryDrawOffset.Remove(Type);
                NPCID.Sets.NPCBestiaryDrawOffset.Add(Type, drawModifiers);
            }

            return true;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (!player.active)
                {
                    continue;
                }

                if (player.inventory.Any(item => item.type == ModContent.ItemType<FryingPan>()))
                {
                    return true;
                }
            }

            return false;
        }

        public override ITownNPCProfile TownNPCProfile()
        {
            return new ShrubStuff();
        }

        public override List<string> SetNPCNameList()
        {
            return new List<string>() {
                "Shrub",
                "Zycote",
                "Bush",
                "Lil Tree",
                "BushMen",
                "Shrubenner",
                "Your Stacker",
                "Fog Warning"

            };
        }

        public override void FindFrame(int frameHeight)
        {
            /*npc.frame.Width = 40;
			if (((int)Main.time / 10) % 2 == 0)
			{
				npc.frame.X = 40;
			}
			else
			{
				npc.frame.X = 0;
			}*/
        }

        public override string GetChat()
        {
            WeightedRandom<string> chat = new WeightedRandom<string>();

            int partyGirl = NPC.FindFirstNPC(NPCID.PartyGirl);
            if (partyGirl >= 0 && Main.rand.NextBool(4))
            {
                chat.Add(Language.GetTextValue("Bruh, That Pink Girl looks gay ima be honest", Main.npc[partyGirl].GivenName));
            }
            chat.Add(Language.GetTextValue("I Was able to catch you in my smella vision from 50 yards away, also you should take a bath"));
            chat.Add(Language.GetTextValue("Gorden do you have furtalizer, oh nevermind ill get it myself"));
            chat.Add(Language.GetTextValue("Did you think i was a american bush, Well guess what bud, im infact a canadian bush bozo"));
            chat.Add(Language.GetTextValue("Hi gorden"), 2.0);
            chat.Add(Language.GetTextValue("Hey gorden are a yummy wummy, bozzoy man, or are you a bravey soul"), 0.1);
            chat.Add(Language.GetTextValue("Arnt you just a stupid ni--"), 0.001);

            NumberOfTimesTalkedTo++;
            if (NumberOfTimesTalkedTo >= 10)
            {
                chat.Add(Language.GetTextValue("Gorden go the fuck away"));
            }
            if (Main.LocalPlayer.HasItem(ItemID.HiveBackpack))
            {
                chat.Add(Language.GetTextValue("Bruh i just snuck some furtalizer in this bitch, want some?"));
            }

            return chat;
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
            button2 = "Upgrade Thee Frying Pan";
            if (Main.LocalPlayer.HasItem(ItemID.HiveBackpack))
            {
                button = "Upgrade " + Lang.GetItemNameValue(ItemID.HiveBackpack);
            }
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {

                if (Main.LocalPlayer.HasItem(ItemID.HiveBackpack))
                {
                    SoundEngine.PlaySound(SoundID.Item37); 

                    Main.npcChatText = $"I upgraded your {Lang.GetItemNameValue(ModContent.ItemType<FryingPan>())} to a {Lang.GetItemNameValue(ModContent.ItemType<ShrubsSharpnessFiveKnockbackThreeFryingPan>())}";

                    int hiveBackpackItemIndex = Main.LocalPlayer.FindItem(ModContent.ItemType<FryingPan>());
                    var entitySource = NPC.GetSource_GiftOrReward();

                    Main.LocalPlayer.inventory[hiveBackpackItemIndex].TurnToAir();
                    Main.LocalPlayer.QuickSpawnItem(entitySource, ModContent.ItemType<ShrubsSharpnessFiveKnockbackThreeFryingPan>());

                    return;
                }

                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot++].SetDefaults(ModContent.ItemType<FryingPan>());
            shop.item[nextSlot++].SetDefaults(ModContent.ItemType<ShrubsSharpnessFiveKnockbackThreeFryingPan>());
            shop.item[nextSlot++].SetDefaults(ModContent.ItemType<MacAndCheese>());
            shop.item[nextSlot++].SetDefaults(ModContent.ItemType<PossesedFryingPan>());
            if (Main.LocalPlayer.HasBuff(BuffID.Ironskin))
            {
                shop.item[nextSlot++].SetDefaults(ModContent.ItemType<HockyStickSythe>());
            }

            if (Main.moonPhase < 2)
            {
                shop.item[nextSlot++].SetDefaults(ModContent.ItemType<ShrubsGamingChair>());
                nextSlot++;
                shop.item[nextSlot++].SetDefaults(ModContent.ItemType<ShrubsGamingLaptop>());
                nextSlot++;
                shop.item[nextSlot++].SetDefaults(ModContent.ItemType<ShrubsSetup>());
                nextSlot++;
            }
            if (Main.moonPhase < 4)
            {
                shop.item[nextSlot++].SetDefaults(ModContent.ItemType<ShrubMask>());
                nextSlot++;
                shop.item[nextSlot++].SetDefaults(ModContent.ItemType<ShrubChestplate>());
                nextSlot++;
            }
            if (Main.moonPhase < 6)
            {
                shop.item[nextSlot++].SetDefaults(ModContent.ItemType<Furtalizer>());
                nextSlot++;
                shop.item[nextSlot++].SetDefaults(ModContent.ItemType<EmotinolDamage>());
                nextSlot++;
            }
        }
        public override void ModifyNPCLoot(NPCLoot npcLoot)
        {
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<FryingPan>()));
            npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Furtalizer>()));
        }

        public void StatueTeleport()
        {
            for (int i = 0; i < 30; i++)
            {
                Vector2 position = Main.rand.NextVector2Square(-20, 21);
                if (Math.Abs(position.X) > Math.Abs(position.Y))
                {
                    position.X = Math.Sign(position.X) * 20;
                }
                else
                {
                    position.Y = Math.Sign(position.Y) * 20;
                }
            }
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 20;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 30;
        }
        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = (ModContent.ProjectileType<FryingPanProjectile>());
            attackDelay = 1;
        }
        

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }

        public override void LoadData(TagCompound tag)
        {
            NumberOfTimesTalkedTo = tag.GetInt("numberOfTimesTalkedTo");
        }

        public override void SaveData(TagCompound tag)
        {
            tag["numberOfTimesTalkedTo"] = NumberOfTimesTalkedTo;
        }
    }

    public class ShrubStuff : ITownNPCProfile
    {
        public int RollVariation() => 0;
        public string GetNameForVariant(NPC npc) => npc.getNewNPCName();

        public Asset<Texture2D> GetTextureNPCShouldUse(NPC npc)
        {
            if (npc.IsABestiaryIconDummy && !npc.ForcePartyHatOn)
                return ModContent.Request<Texture2D>("WorhyMod/Items/NPCS/TownNpcs/Shrub");

            if (npc.altTexture == 1)
                return ModContent.Request<Texture2D>("WorhyMod/Items/NPCS/TownNpcs/Shrub_Party");

            return ModContent.Request<Texture2D>("WorhyMod/Items/NPCS/TownNpcs/Shrub");
        }

        public int GetHeadTextureIndex(NPC npc) => ModContent.GetModHeadSlot("WorhyMod/Items/NPCS/TownNpcs/Shrub_Head");
    }
}