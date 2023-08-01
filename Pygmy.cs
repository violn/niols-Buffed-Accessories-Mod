using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class Pygmy : GlobalProjectile
    {
        public static List<Projectile> modifiedProjectiles = new();

        public override void OnHitNPC(Projectile projectile, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if ((projectile.sentry || projectile.minion) && AccessoryProperties.SummonImmunity && !projectile.usesLocalNPCImmunity)
            {
                projectile.usesLocalNPCImmunity = true;
                modifiedProjectiles.Add(projectile);
            }

            else if (modifiedProjectiles.Contains(projectile))
            {
                projectile.usesLocalNPCImmunity = false;
                modifiedProjectiles.Remove(projectile);
            }
        }
    }
}