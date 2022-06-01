using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class Pygmy : GlobalProjectile
    {
        public static List<Projectile> modifiedProjectiles = new();

        public override void OnHitNPC(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if ((proj.sentry || proj.minion) && AccessoryProperties.SummonImmunity && !proj.usesLocalNPCImmunity)
            {
                proj.usesLocalNPCImmunity = true;
                modifiedProjectiles.Add(proj);
            }

            else if (modifiedProjectiles.Contains(proj))
            {
                proj.usesLocalNPCImmunity = false;
                modifiedProjectiles.Remove(proj);
            }
        }
    }
}