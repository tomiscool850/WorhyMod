using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Projectiles.MeleeP.YoyoP
{
    public class BoneYoyoProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {

            ProjectileID.Sets.YoyosLifeTimeMultiplier[Projectile.type] = 1.8f;

            ProjectileID.Sets.YoyosMaximumRange[Projectile.type] = 132f;

            ProjectileID.Sets.YoyosTopSpeed[Projectile.type] = 7.5f;
        }

        public override void SetDefaults()
        {
            Projectile.width = 16;
            Projectile.height = 16;

            Projectile.aiStyle = ProjAIStyleID.Yoyo;

            Projectile.friendly = true;
            Projectile.DamageType = DamageClass.MeleeNoSpeed;
            Projectile.penetrate = -1;
        }
    }
}