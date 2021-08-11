using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class YoyoProjectiles : GlobalProjectile
    {
        public static List<int> yoyoProjectiles = new();

        public static List<int> countweightBlackList = new()
        {
            556,
            557,
            558,
            559,
            560,
            561
        };

        public override void SetDefaults(Projectile proj)
        {
            if (!yoyoProjectiles.Contains(proj.type) && proj.aiStyle == 99 && !countweightBlackList.Contains(proj.type))
            {
                yoyoProjectiles.Add(proj.type);
            }
        }
    }
}