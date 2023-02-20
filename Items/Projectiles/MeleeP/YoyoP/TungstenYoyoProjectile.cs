using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorhyMod.Items.Projectiles.MeleeP.YoyoP
{
    public class TungstenYoyoProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {

            ProjectileID.Sets.YoyosLifeTimeMultiplier[Projectile.type] = 1.85f;

            ProjectileID.Sets.YoyosMaximumRange[Projectile.type] = 138f;

            ProjectileID.Sets.YoyosTopSpeed[Projectile.type] = 7.6f;
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