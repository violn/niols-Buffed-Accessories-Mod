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
            ProjectileID.StarCloakStar,
            ProjectileID.GiantBee,
            ProjectileID.Bee,
            ProjectileID.SporeGas,
            ProjectileID.SporeGas2,
            ProjectileID.SporeGas3,
            ProjectileID.SporeTrap,
            ProjectileID.SporeTrap2,
        };

        public override void ModifyHitNPC(Projectile projectile, NPC target, ref NPC.HitModifiers modifiers)
        {
            if (!blacklistedProjectiles.Contains(projectile.type))
            {
                if (AccessoryProperties.SpawnBees && SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
                {
                    if (AccessoryProperties.StrongBees && BuffedAccessories.Ran.Next(2) == 0)
                    {
                        SpawnProjectiles.CreateBees(target, projectile.damage, true, projectile.GetSource_FromThis());
                    }
                    else SpawnProjectiles.CreateBees(target, projectile.damage, false, projectile.GetSource_FromThis());
                }

                if (AccessoryProperties.SpawnStars && SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
                {
                    SpawnProjectiles.CreateStars(target, projectile.damage, projectile.GetSource_FromThis());
                }
            }
        }

        public static bool SpawnProjectile(int time)
        {
            return time > 25 ?
                BuffedAccessories.Ran.Next(101) < Math.Pow(time, 2f) / 25f :
                BuffedAccessories.Ran.Next(101) < time;
        }
    }
}