using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class Pygmy : GlobalProjectile
    {
        public override void OnHitNPC(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if ((proj.sentry || proj.minion) && AccessoryProperties.equippedPygmyNecklace)
            {
                proj.usesLocalNPCImmunity = true;
                proj.localNPCImmunity[target.whoAmI] = 10;
                target.immune[proj.owner] = 0;
            }
        }
    }
}