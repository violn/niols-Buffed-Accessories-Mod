using Microsoft.Xna.Framework;
using niolsBuffedAccessories.Configs;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class Stalkers : GlobalProjectile
    {
        public override bool? CanHitNPC(Projectile projectile, NPC target)
        {
            projectile.CritChance = projectile.owner == Main.myPlayer && projectile.arrow && AccessoryProperties.EquippedStalkersQuiver ? 
                (int)(1.1 * projectile.CritChance) : projectile.CritChance;

            return base.CanHitNPC(projectile, target);
        }
    }
}
