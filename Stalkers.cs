using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class Stalkers : GlobalProjectile
    {
        public override bool? CanHitNPC(Projectile projectile, NPC target)
        {
            projectile.CritChance = projectile.owner == Main.myPlayer && projectile.arrow && AccessoryProperties.Stalker ?
                (int)(1.1 * projectile.CritChance) : projectile.CritChance;

            return base.CanHitNPC(projectile, target);
        }
    }
}
