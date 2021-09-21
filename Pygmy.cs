using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class Pygmy : GlobalProjectile
    {
        public static List<Projectile> modifiedPorjectiles = new();

        public override void OnHitNPC(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if ((proj.sentry || proj.minion) && AccessoryProperties.equippedPygmyNecklace && !proj.usesLocalNPCImmunity)
            {
                proj.usesLocalNPCImmunity = true;
                proj.localNPCImmunity[target.whoAmI] = 2;
                target.immune[proj.owner] = 0;
                modifiedPorjectiles.Add(proj);
            }

            else if (modifiedPorjectiles.Contains(proj))
            {
                proj.usesLocalNPCImmunity = false;
                modifiedPorjectiles.Remove(proj);
            }
        }
    }
}