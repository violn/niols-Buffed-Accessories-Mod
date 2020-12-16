using Microsoft.Xna.Framework;
using niolsBuffedAccessories;
using References;
using System;
using Terraria;
using Terraria.ModLoader;

//Handles the things that happen when using a weapon that creates a projectile
public class OnShoot : GlobalItem
{
    //Terraria hook that runs when shooting a projectile
    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        Random rand = new Random();

        //Duplicate a ranged item projectile if a scope accessory is equipped
        if ((Reference.equippedRangerE || Reference.equippedSScope) && (item.ranged || Reference.blackListedItems.Contains(player.HeldItem.type)) && rand.Next(100) < 33)
        {
            if (rand.Next(100) > CalcChance(item.useTime))
            {
                ProjectileHandler.CreateDuplicate(type, position, speedX, speedY, damage, knockBack);
            }
        }

        //Create three yoyos when using a yoyo with a yoyobag equipped
        if (item.melee && Reference.equippedYoyoBag && Reference.yoyoProj.Count > 0)
        {
            foreach (Projectile proj in Reference.yoyoProj)
            {
                if (proj.type == type)
                {
                    for (int x = 0; x < 2; x++)
                    {
                        ProjectileHandler.CreateDuplicate(type, position, speedX, speedY, damage, knockBack);
                    }
                    break;
                }
            }
        }

        //Gets the players position to be used later for calculating damage based on distance
        if (item.ranged)
        {
            for (int x = 0; x < 2; x++)
            {
                Reference.playerPosition = new Vector2(player.position.X, player.position.Y);
            }
        }
        return true;
    }

    //Decides if a weapon should consume ammo when shot
    public override bool ConsumeAmmo(Item item, Player player)
    {
        Random rand = new Random();
        int chance = 0;
        if (item.ranged && Reference.equippedRangerE)
        {
            chance += 10;
        }

        if (item.ranged && Reference.equippedSScope)
        {
            chance += 15;
        }

        if (item.ranged && Reference.equippedOWABuckler)
        {
            chance += 3;
        }

        return rand.Next(100) > chance;
    }

    //Caculates the chance of something happening based on the use time of the item
    public static int CalcChance(int time)
    {
        if (time > 60)
        {
            return 60;
        }

        if (time < 11)
        {
            return 25;
        }

        return (int)(.25f + (.5f * 60f));
    }
}
