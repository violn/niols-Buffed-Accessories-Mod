using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class YoyoProjectiles : GlobalProjectile
    {
        public static List<int> YoyoProjectilesList = new();

        public static List<int> CounterweightBlackList = new()
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
            if (!YoyoProjectilesList.Contains(proj.type) && proj.aiStyle == 99 && !CounterweightBlackList.Contains(proj.type))
            {
                YoyoProjectilesList.Add(proj.type);
            }
        }
    }
}