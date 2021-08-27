using niolsBuffedAccessories.Configs;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class CreateProjectiles : GlobalProjectile
    {
        private static readonly List<int> blacklistedProjectiles = new()
        {
            ProjectileID.StarCannonStar,
            ProjectileID.GiantBee,
            ProjectileID.Bee,
            ProjectileID.SporeGas,
            ProjectileID.SporeGas2,
            ProjectileID.SporeGas3,
            ProjectileID.SporeTrap,
            ProjectileID.SporeTrap2,
        };

        public override void ModifyHitNPC(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (!blacklistedProjectiles.Contains(proj.type))
            {
                if (AccessoryProperties.equippedBee && ModContent.GetInstance<Config>().Bee && SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
                {
                    if (AccessoryProperties.equippedHive && BuffedAccessories.ran.Next(6) > 3)
                    {
                        SpawnProjectiles.CreateBees(target, damage, true, proj.GetProjectileSource_FromThis());
                    }
                    else SpawnProjectiles.CreateBees(target, damage, false, proj.GetProjectileSource_FromThis());
                }

                if (AccessoryProperties.equippedStar && ModContent.GetInstance<Config>().Star && SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
                {
                    SpawnProjectiles.CreateStars(target, damage, proj.GetProjectileSource_FromThis());
                }
            }
        }

        public static bool SpawnProjectile(int time)
        {
            if (time > 40)
            {
                return BuffedAccessories.ran.Next(1, 100) < 65;
            }

            if (time < 10)
            {
                return BuffedAccessories.ran.Next(1, 100) < 10;
            }

            return BuffedAccessories.ran.Next(1, 100) < (10 + time / 10 * 40 > 65 ? 65 : 10 + time / 10 * 40);
        }
    }
}