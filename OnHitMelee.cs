using niolsBuffedAccessories;
using References;
using System;
using Terraria;
using Terraria.ModLoader;

public class OnHitMelee : GlobalItem
{
    private static readonly Random rand = new Random();

    public override void ModifyHitNPC(Item item, Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
    {
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
            target.life < damage)
        {
            player.AddBuff(ModContent.BuffType<niolsBuffedAccessories.Buffs.BeserkerRage>(), 340, true);
        }

        for (int x = 0; x < 2; x++)
        {
            if (Reference.equippedPlague)
            {
                if (rand.Next(100) < CalcChance(item.useTime))
                {
                    ProjectileHandler.CreatePlagueBees(target, damage);
                    Reference.equippedBee = false;
                }
            }

            if (Reference.equippedBee && Reference.equippedStar)
            {
                if (rand.Next(100) < CalcChance(item.useTime))
                {
                    ProjectileHandler.CreateStars(target, damage);
                }

                if (rand.Next(100) < CalcChance(item.useTime))
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
                if (rand.Next(100) < CalcChance(item.useTime))
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
                if (rand.Next(100) < CalcChance(item.useTime))
                {
                    ProjectileHandler.CreateStars(target, damage);
                }
            }
        }
    }

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