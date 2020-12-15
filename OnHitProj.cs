using Microsoft.Xna.Framework;
using niolsBuffedAccessories;
using References;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

//Handles actions done when hitting an enemy with a projectile
public class OnHitProj : GlobalProjectile
{
    private static readonly Random rand = new Random();

    //Terraria hook that runs when hitting an enemy with a projectile
    public override void ModifyHitNPC(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
    {
        //Handles things done when player has the sniper or ranger scope equipped
        if (proj.ranged && (Reference.equippedRScope || Reference.equippedSScope))
        {
            Reference.targetPosition = new Vector2(target.position.X, target.position.Y);
            damage = CalcDamage(damage, proj);
        }
        
        //Handles things done if the player has the celestial emblem equipped
        if (proj.magic && (Reference.equippedCeleE || Reference.equippedSorcE))
        {
            Reference.counter = 0;
            double stacksGained;
            if(Reference.itemUsed != null)
            {
                stacksGained = CalcStacks(Reference.itemUsed.useTime);
            }
            
            else stacksGained = CalcStacks(25);

            Reference.currentOnHitBoost += stacksGained - Reference.depleteBoost;
            Reference.depleteBoost = .0;
            if (Reference.currentOnHitBoost < .0)
            {
                Reference.currentOnHitBoost = .0;
            }

            if (Reference.currentOnHitBoost > .30)
            {
                Reference.currentOnHitBoost = .30;
            }

            if (Reference.currentOnHitBoost > .0 && Reference.currentOnHitBoost < .01)
            {
                Reference.currentOnHitBoost = .01;
            }
            if (Reference.equippedCeleE && !Reference.equippedSorcE)
            {
                damage = (int)(damage * (1 + Reference.currentOnHitBoost));
                Reference.celeRegen = (int)(Reference.celeRegen + (1.5 * (Reference.currentOnHitBoost * 100)));
            }
            else
            {
                damage = (int)(damage * (1 + (Reference.currentOnHitBoost / 2)));
            }
        }
    
        //Handles things done if the player has a bee or star accessory equipped
        if (proj.type != ProjectileID.HallowStar &&
            proj.type != ProjectileID.GiantBee &&
            proj.type != ProjectileID.Bee &&
            proj.type != ProjectileID.SporeGas &&
            proj.type != ProjectileID.SporeGas2 &&
            proj.type != ProjectileID.SporeGas3 &&
            proj.type != ProjectileID.SporeTrap &&
            proj.type != ProjectileID.SporeTrap2 &&
            proj.type != Reference.cal.ProjectileType("PlaguenadeBee") &&
            proj.type != Reference.cal.ProjectileType("PlagueSeeker"))
        {
            if (Reference.itemUsed != null)
            {
                if (Reference.equippedPlague)
                {
                    if (rand.Next(100) < CalcChance(Reference.itemUsed.useTime))
                    {
                        ProjectileHandler.CreatePlagueBees(target, damage);
                        Reference.equippedBee = false;
                    }
                }
                if (Reference.equippedBee && Reference.equippedStar)
                {
                    if (rand.Next(100) < CalcChance(Reference.itemUsed.useTime))
                    {
                        ProjectileHandler.CreateStars(target, damage);
                    }

                    if (rand.Next(100) < CalcChance(Reference.itemUsed.useTime))
                    {
                        if (Reference.equippedHive && rand.Next(2) == 1)
                        {
                            ProjectileHandler.CreateStrongBees(target, damage);
                        }
                        else ProjectileHandler.CreateWeakBees(target, damage);
                    }
                }
                else if (Reference.equippedBee && !Reference.equippedStar)
                {
                    if (rand.Next(100) < CalcChance(Reference.itemUsed.useTime))
                    {
                        if (Reference.equippedHive && rand.Next(2) == 1)
                        {
                            ProjectileHandler.CreateStrongBees(target, damage);
                        }
                        else ProjectileHandler.CreateWeakBees(target, damage);
                    }
                }
                else if (!Reference.equippedBee && Reference.equippedStar)
                {
                    if (rand.Next(100) < CalcChance(Reference.itemUsed.useTime))
                    {
                        ProjectileHandler.CreateStars(target, damage);
                    }
                }
            }

            else
            {
                if (Reference.equippedPlague)
                {
                    if (rand.Next(100) < CalcChance(20))
                    {
                        ProjectileHandler.CreatePlagueBees(target, damage);
                        Reference.equippedBee = false;
                    }
                }
                if (Reference.equippedBee && Reference.equippedStar)
                {
                    if (rand.Next(100) < CalcChance(20))
                    {
                        ProjectileHandler.CreateStars(target, damage);
                    }

                    if (rand.Next(100) < CalcChance(20))
                    {
                        if (Reference.equippedHive && rand.Next(2) == 1)
                        {
                            ProjectileHandler.CreateStrongBees(target, damage);
                        }
                        else ProjectileHandler.CreateWeakBees(target, damage);
                    }
                }
                else if (Reference.equippedBee && !Reference.equippedStar)
                {
                    if (rand.Next(100) < CalcChance(20))
                    {
                        if (Reference.equippedHive && rand.Next(2) == 1)
                        {
                            ProjectileHandler.CreateStrongBees(target, damage);
                        }
                        else ProjectileHandler.CreateWeakBees(target, damage);
                    }
                }
                else if (!Reference.equippedBee && Reference.equippedStar)
                {
                    if (rand.Next(100) < CalcChance(20))
                    {
                        ProjectileHandler.CreateStars(target, damage);
                    }
                }
            }
        }
    }

    //Calculates the damage of a ranged projectile based on the distance between the player and the target NPC
    public static int CalcDamage(int damage, Projectile proj)
    {
        double distance;
        double velocityBooster;
        double damageMulti;
        double calcMulti;
        if (Reference.equippedSScope)
        {
            distance = CalcDistance(Reference.playerPosition, Reference.targetPosition);
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
        else if (Reference.equippedRScope)
        {
            distance = CalcDistance(Reference.playerPosition, Reference.targetPosition);
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

    //Gets the distance of the target from the player using the distance formula
    public static float CalcDistance(Vector2 player, Vector2 target)
    {
        return (float)Math.Sqrt(Math.Pow((target.X - player.X), 2) + Math.Pow((target.Y - player.Y), 2));
    }

    //Calculates the amount of stacks gained from hitting and enemy with a magic attack
    public static double CalcStacks(int use)
    {
        double useBoost = (double)(use * ((277m / 60m) / 1500m));
        return Math.Round(useBoost, 2, MidpointRounding.AwayFromZero);
    }

    //Calculate the chance of bees and stars spawning based of the use time of an item
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

//Handles actions done when hitting an enemy with a melee projectile
public class OnHitProjMelee : ModPlayer
{

    //Hook that runs when a player hits a NPC with a melee projectile
    public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
    {
        //Gives a different version of the Beserker Rage buff depending on the accessory equipped
        if (Reference.equippedFGaunt)
        {
            Reference.buffCheck1 = 1;
        }
        else if (Reference.equippedMechGlove)
        {
            Reference.buffCheck2 = 1;
        }
        else if (Reference.equippedWarE)
        {
            Reference.buffCheck3 = 1;
        }

        if ((Reference.equippedMechGlove ||
            Reference.equippedFGaunt ||
            Reference.equippedWarE) &&
            proj.melee &&
            target.life < damage)
        {
            player.AddBuff(ModContent.BuffType<niolsBuffedAccessories.Buffs.BeserkerRage>(), 340, true);
        }
    }
}
