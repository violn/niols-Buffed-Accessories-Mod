using niolsBuffedAccessories.Configs;
using System;
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
                if (AccessoryProperties.EquippedBee && ModContent.GetInstance<Config>().Bee && SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
                {
                    if (AccessoryProperties.EquippedHive && BuffedAccessories.Ran.Next(2) == 0)
                    {
                        SpawnProjectiles.CreateBees(target, damage, true, proj.GetSource_FromThis());
                    }
                    else SpawnProjectiles.CreateBees(target, damage, false, proj.GetSource_FromThis());
                }

                if (AccessoryProperties.EquippedStar && ModContent.GetInstance<Config>().Star && SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
                {
                    SpawnProjectiles.CreateStars(target, damage, proj.GetSource_FromThis());
                }
            }
        }

        public static bool SpawnProjectile(int time)
        {
            if (time > 25)
            {
                return BuffedAccessories.Ran.Next(101) < Math.Pow(time, 2f) / 25f;
            }

            return BuffedAccessories.Ran.Next(101) < time;
        }
    }
}