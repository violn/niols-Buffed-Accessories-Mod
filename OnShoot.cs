using Microsoft.Xna.Framework;
using niolsBuffedAccessories;
using References;
using System;
using Terraria;
using Terraria.ModLoader;

public class OnShoot : GlobalItem
{
    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        Random rand = new Random();
        if ((Reference.equippedRangerE || Reference.equippedSScope) && (item.ranged || Reference.blackListedItems.Contains(player.HeldItem.type)) && rand.Next(100) < 33)
        {
            if (rand.Next(100) > CalcChance(item.useTime))
            {
                ProjectileHandler.CreateDuplicate(type, position, speedX, speedY, damage, knockBack);
            }
        }

        if (item.melee && Reference.equippedYoyoBag && Reference.yoyoProj.Count > 0)
        {
            foreach(Projectile proj in Reference.yoyoProj)
            {
                if(proj.type == type)
                {
                    for(int x = 0; x < 2; x++)
                    {
                        ProjectileHandler.CreateDuplicate(type, position, speedX, speedY, damage, knockBack);
                    }
                    break;
                }
            }
        }

        if (item.ranged)
        {
            for (int x = 0; x < 2; x++)
            {
                Reference.playerPosition = new Vector2(player.position.X, player.position.Y);
            }
        }
        return true;
    }

    public override bool ConsumeAmmo(Item item, Player player)
    {
        Random rand = new Random();
        if (item.ranged && Reference.equippedRangerE && rand.Next(100) < 10)
        {
            return false;
        }
        else if (item.ranged && Reference.equippedSScope && rand.Next(100) < 15)
        {
            return false;
        }
        return true;
    }

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