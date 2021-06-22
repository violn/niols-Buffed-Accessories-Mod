using niolsBuffedAccessories;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class CreateProjectiles : GlobalProjectile
{
    private static readonly List<int> blacklistedProjectiles = new List<int>()
    {
        ProjectileID.HallowStar,
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
        AddModdedProjectiles();
        if (!blacklistedProjectiles.Contains(proj.type))
        {
            if (AccessoryProperties.equippedPlagueHive && SpawnProjectile(UseTime.itemUseTime))
            {
                SpawnProjectiles.CreatePlagueBees(target, damage);
            }
            else if (AccessoryProperties.equippedBee && SpawnProjectile(UseTime.itemUseTime))
            {
                if (AccessoryProperties.equippedHive && BuffedAccessories.ran.Next(6) > 3)
                {
                    SpawnProjectiles.CreateStrongBees(target, damage);
                }
                else SpawnProjectiles.CreateWeakBees(target, damage);
            }

            if (AccessoryProperties.equippedStar && SpawnProjectile(UseTime.itemUseTime))
            {
                SpawnProjectiles.CreateStars(target, damage);
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

        return BuffedAccessories.ran.Next(1, 100) < (10 + (time / 10 * 40) > 65 ? 65 : 10 + (time / 10 * 40));
    }

    private static void AddModdedProjectiles()
    {
        if (BuffedAccessories.calamity != null)
        {
            if (!blacklistedProjectiles.Contains(BuffedAccessories.calamity.ProjectileType("PlaguenadeBee")))
            {
                blacklistedProjectiles.Add(BuffedAccessories.calamity.ProjectileType("PlaguenadeBee"));
            }
            if (!blacklistedProjectiles.Contains(BuffedAccessories.calamity.ProjectileType("PlagueSeeker")))
            {
                blacklistedProjectiles.Add(BuffedAccessories.calamity.ProjectileType("PlagueSeeker"));
            }
        }
    }
}

public class CreateProjectilesMelee : GlobalItem
{
    public override void ModifyHitNPC(Item item, Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
    {
        if (AccessoryProperties.equippedPlagueHive && CreateProjectiles.SpawnProjectile(UseTime.itemUseTime))
        {
            SpawnProjectiles.CreatePlagueBees(target, damage);
        }
        else if (AccessoryProperties.equippedBee && CreateProjectiles.SpawnProjectile(UseTime.itemUseTime))
        {
            if (AccessoryProperties.equippedHive && BuffedAccessories.ran.Next(1, 100) < 50)
            {
                SpawnProjectiles.CreateStrongBees(target, damage);
            }
            else SpawnProjectiles.CreateWeakBees(target, damage);
        }

        if (AccessoryProperties.equippedStar && CreateProjectiles.SpawnProjectile(UseTime.itemUseTime))
        {
            SpawnProjectiles.CreateStars(target, damage);
        }
    }
}