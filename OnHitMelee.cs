using System;
using Terraria;
using Terraria.ModLoader;

public class OnHitMelee : GlobalItem
{
    private static readonly Random rand = new Random();

    public override void ModifyHitNPC(Item item, Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
    {
        //Gives melee weapon a chance to spawn up to two projectiles when hitting an enemy.
        for (int x = 0; x < 2; x++)
        {
            if (AccessoryProperties.equippedPlagueHive)
            {
                if (rand.Next(100) < OnHitProj.CalcChance(item.useTime))
                {
                    ProjectileHandler.CreatePlagueBees(target, damage);
                    AccessoryProperties.equippedBee = false;
                }
            }

            if (AccessoryProperties.equippedBee && AccessoryProperties.equippedStar)
            {
                if (rand.Next(100) < OnHitProj.CalcChance(item.useTime))
                {
                    ProjectileHandler.CreateStars(target, damage);
                }

                if (rand.Next(100) < OnHitProj.CalcChance(item.useTime))
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
                if (rand.Next(100) < OnHitProj.CalcChance(item.useTime))
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
                if (rand.Next(100) < OnHitProj.CalcChance(item.useTime))
                {
                    ProjectileHandler.CreateStars(target, damage);
                }
            }
        }
    }
}
