using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Pets
{
    public class MiniShrub : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[Projectile.type] = 7;
            Main.projPet[Projectile.type] = true;
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.Puppy);

            AIType = ProjectileID.Puppy;
        }

        public override bool PreAI()
        {
            Player player = Main.player[Projectile.owner];

            player.zephyrfish = false;

            return true;
        }

        public override void AI()
        {
            Player player = Main.player[Projectile.owner];

            if (!player.dead && player.HasBuff(ModContent.BuffType<MiniShrubBuff>()))
            {
                Projectile.timeLeft = 2;
            }
        }
    }
}