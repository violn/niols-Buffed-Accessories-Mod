using Microsoft.Xna.Framework;
using niolsBuffedAccessories;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class OnHitProj : GlobalProjectile
{
    private static readonly Random rand = new Random();
    public static Vector2 targetPosition;
    public static Vector2 playerPosition;
    public static int itemUseTime = 20;
    public static int celestialRegen = 15;
    public static double currentOnHitBoost = 0;
    public static double depleteBoost = 0;

    public override void ModifyHitNPC(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
    {
        //Increases ranged damage based on how far the player is from the NPC.
        if (proj.ranged && (AccessoryProperties.equippedRifleScope || AccessoryProperties.equippedSniperScope))
        {
            targetPosition = new Vector2(target.position.X, target.position.Y);
            damage = CalcDamage(damage, proj);
        }

        //Increase magic damage and mana regeneration when continously damaging a NPC.
        if (proj.magic && (AccessoryProperties.equippedCelestialEmblem || AccessoryProperties.equippedSorcerorEmblem))
        {
            Counter.DelayCount = 0;
            Counter.Count = 0;
            double stacksGained;
            stacksGained = CalcStacks(itemUseTime);

            currentOnHitBoost += stacksGained - depleteBoost;
            depleteBoost = .0;
            if (currentOnHitBoost < .0)
            {
                currentOnHitBoost = .0;
            }

            if (currentOnHitBoost > .30)
            {
                currentOnHitBoost = .30;
            }

            if (currentOnHitBoost > .0 && currentOnHitBoost < .01)
            {
                currentOnHitBoost = .01;
            }

            if (AccessoryProperties.equippedCelestialEmblem)
            {
                damage = (int)(damage * (1 + currentOnHitBoost));

                if (celestialRegen < 60)
                {
                    celestialRegen = (int)(celestialRegen + (2 * (currentOnHitBoost * 100)));
                }
            }
            else
            {
                damage = (int)(damage * (1 + (currentOnHitBoost / 2)));
            }
        }
        
        //Chance to spawn plague bees on hit.
        if (proj.type != ProjectileID.HallowStar &&
            proj.type != ProjectileID.GiantBee &&
            proj.type != ProjectileID.Bee &&
            proj.type != ProjectileID.SporeGas &&
            proj.type != ProjectileID.SporeGas2 &&
            proj.type != ProjectileID.SporeGas3 &&
            proj.type != ProjectileID.SporeTrap &&
            proj.type != ProjectileID.SporeTrap2 &&
            BuffedAccessories.calamity != null && proj.type != BuffedAccessories.calamity.ProjectileType("PlaguenadeBee") &&
            BuffedAccessories.calamity != null && proj.type != BuffedAccessories.calamity.ProjectileType("PlagueSeeker"))
        {
            if (AccessoryProperties.equippedPlagueHive)
            {
                if (rand.Next(100) < CalcChance(itemUseTime))
                {
                    ProjectileHandler.CreatePlagueBees(target, damage);
                    AccessoryProperties.equippedBee = false;
                }
            }
        }

        //Chance to spawn bees and star on hit.
        if (proj.type != ProjectileID.HallowStar &&
            proj.type != ProjectileID.GiantBee &&
            proj.type != ProjectileID.Bee &&
            proj.type != ProjectileID.SporeGas &&
            proj.type != ProjectileID.SporeGas2 &&
            proj.type != ProjectileID.SporeGas3 &&
            proj.type != ProjectileID.SporeTrap &&
            proj.type != ProjectileID.SporeTrap2 &&
            BuffedAccessories.calamity == null)
        {
            if (AccessoryProperties.equippedBee && AccessoryProperties.equippedStar)
            {
                if (rand.Next(100) < CalcChance(itemUseTime))
                {
                    ProjectileHandler.CreateStars(target, damage);
                }

                if (rand.Next(100) < CalcChance(itemUseTime))
                {
                    if (AccessoryProperties.equippedHive && rand.Next(2) == 1)
                    {
                        ProjectileHandler.CreateStrongBees(target, damage);
                    }
                    else ProjectileHandler.CreateWeakBees(target, damage);
                }
            }
            else if (AccessoryProperties.equippedBee && !AccessoryProperties.equippedStar)
            {
                if (rand.Next(100) < CalcChance(itemUseTime))
                {
                    if (AccessoryProperties.equippedHive && rand.Next(2) == 1)
                    {
                        ProjectileHandler.CreateStrongBees(target, damage);
                    }
                    else ProjectileHandler.CreateWeakBees(target, damage);
                }
            }
            else if (!AccessoryProperties.equippedBee && AccessoryProperties.equippedStar)
            {
                if (rand.Next(100) < CalcChance(itemUseTime))
                {
                    ProjectileHandler.CreateStars(target, damage);
                }
            }
        }

        //Chance to spawn bees and star on hit if calamity is enabled.
        else if (proj.type != ProjectileID.HallowStar &&
            proj.type != ProjectileID.GiantBee &&
            proj.type != ProjectileID.Bee &&
            proj.type != ProjectileID.SporeGas &&
            proj.type != ProjectileID.SporeGas2 &&
            proj.type != ProjectileID.SporeGas3 &&
            proj.type != ProjectileID.SporeTrap &&
            proj.type != ProjectileID.SporeTrap2 &&
            BuffedAccessories.calamity != null && proj.type != BuffedAccessories.calamity.ProjectileType("PlaguenadeBee") &&
            BuffedAccessories.calamity != null && proj.type != BuffedAccessories.calamity.ProjectileType("PlagueSeeker"))
        if (AccessoryProperties.equippedBee && AccessoryProperties.equippedStar)
        {
            if (rand.Next(100) < CalcChance(itemUseTime))
            {
                    ProjectileHandler.CreateStars(target, damage);
            }

            if (rand.Next(100) < CalcChance(itemUseTime))
            {
                if (AccessoryProperties.equippedHive && rand.Next(2) == 1)
                {
                        ProjectileHandler.CreateStrongBees(target, damage);
                }
                else ProjectileHandler.CreateWeakBees(target, damage);
            }
        }
        else if (AccessoryProperties.equippedBee && !AccessoryProperties.equippedStar)
        {
            if (rand.Next(100) < CalcChance(itemUseTime))
            {
                if (AccessoryProperties.equippedHive && rand.Next(2) == 1)
                {
                        ProjectileHandler.CreateStrongBees(target, damage);
                }
                else ProjectileHandler.CreateWeakBees(target, damage);
            }
        }
        else if (!AccessoryProperties.equippedBee && AccessoryProperties.equippedStar)
        {
            if (rand.Next(100) < CalcChance(itemUseTime))
            {
                    ProjectileHandler.CreateStars(target, damage);
            }
        }
    }

    /// <summary>
    /// Calculates damage based on distance the player is from the NPC.
    /// </summary>
    /// <param name="damage">The original damage.</param>
    /// <param name="proj">The projectile that did that damage.</param>
    /// <returns>Boosted damage.</returns>
    public static int CalcDamage(int damage, Projectile proj)
    {
        double distance;
        double velocityBooster;
        double damageMulti;
        double calcMulti;
        if (AccessoryProperties.equippedSniperScope)
        {
            distance = CalcDistance(playerPosition, targetPosition);
            velocityBooster = Math.Abs(proj.velocity.X) + Math.Abs(proj.velocity.Y);
            if (velocityBooster < 1)
            {
                velocityBooster = 1;
            }

            damageMulti = velocityBooster / distance / (velocityBooster / 1000);
            if (damageMulti < 1)
            {
                damageMulti = 1;
            }

            calcMulti = (1 + (.4 / damageMulti));
            if (calcMulti < 1.01)
            {
                calcMulti = 1.01;
            }
            return (int)(damage * calcMulti);
        }
        else if (AccessoryProperties.equippedRifleScope)
        {
            distance = CalcDistance(playerPosition, targetPosition);
            velocityBooster = Math.Abs(proj.velocity.X) + Math.Abs(proj.velocity.Y);
            if (velocityBooster < 1)
            {
                velocityBooster = 1;
            }

            damageMulti = velocityBooster / distance / (velocityBooster / 1000);
            if (damageMulti < 1)
            {
                damageMulti = 1;
            }

            calcMulti = (1 + (.2 / damageMulti));
            if (calcMulti < 1.01)
            {
                calcMulti = 1.01;
            }
            return (int)(damage * calcMulti);
        }

        return damage;
    }

    /// <summary>
    /// Calculates distance using the distance formula.
    /// </summary>
    /// <param name="player">The player's position.</param>
    /// <param name="target">The target's position.</param>
    /// <returns>Their distance from eachother.</returns>
    public static float CalcDistance(Vector2 player, Vector2 target)
    {
        return (float)Math.Sqrt(Math.Pow((target.X - player.X), 2) + Math.Pow((target.Y - player.Y), 2));
    }

    /// <summary>
    /// Calculates stacks gained depending on the the item use time.
    /// </summary>
    /// <param name="use">The items use time.</param>
    /// <returns>The amount of stacks the player gets.</returns>
    public static double CalcStacks(int use)
    {
        double useBoost = (double)(use * ((277m / 60m) / 1500m));
        return Math.Round(useBoost, 2, MidpointRounding.AwayFromZero);
    }

    /// <summary>
    /// Calculates the chance for something to happen based on used time.
    /// </summary>
    /// <param name="time">The use time of the item.</param>
    /// <returns>The chance of something happening.</returns>
    public static int CalcChance(int time)
    {
        if (time > 60)
        {
            return 100;
        }

        if (time < 30)
        {
            return 30;
        }

        return (int)(30f + (.8f * 60f));
    }
}
