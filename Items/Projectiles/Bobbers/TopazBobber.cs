using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Projectiles.Bobbers
{
    public class TopazBobber : ModProjectile
    {
        public static readonly Color[] PossibleLineColors = new Color[] {
            new Color(255, 215, 0),
            new Color(0, 191, 255)
        };

        private int fishingLineColorIndex;

        private Color FishingLineColor => PossibleLineColors[fishingLineColorIndex];

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Example Bobber");
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.BobberWooden);

            DrawOriginOffsetY = -8;
        }

        public override void OnSpawn(IEntitySource source)
        {
            fishingLineColorIndex = (byte)Main.rand.Next(PossibleLineColors.Length);
        }
        public override void AI()
        {
            if (!Main.dedServ)
            {
                Lighting.AddLight(Projectile.Center, FishingLineColor.ToVector3());
            }
        }

        public override void ModifyFishingLine(ref Vector2 lineOriginOffset, ref Color lineColor)
        {
            lineOriginOffset = new Vector2(47, -31);
            lineColor = FishingLineColor;
        }

        public override void SendExtraAI(BinaryWriter writer)
        {
            writer.Write((byte)fishingLineColorIndex);
        }

        public override void ReceiveExtraAI(BinaryReader reader)
        {
            fishingLineColorIndex = reader.ReadByte();
        }
    }
}