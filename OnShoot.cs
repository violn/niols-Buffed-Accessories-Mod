using Microsoft.Xna.Framework;
using niolsBuffedAccessories;
using System;
using Terraria;
using Terraria.ModLoader;

public class OnShoot : GlobalItem
{
    public static Random rand = new Random();

    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        OnHitProj.itemUseTime = item.useTime;

        //Duplicate a ranged item projectile if a scope accessory is equipped.
        if ((AccessoryProperties.equippedRangerEmblem || AccessoryProperties.equippedSniperScope) && item.ranged && rand.Next(100) < 33)
        {
            if (rand.Next(100) > OnHitProj.CalcChance(item.useTime))
            {
                ProjectileHandler.CreateDuplicate(type, position, speedX, speedY, damage, knockBack);
            }
        }

        //Create three yoyos when using a yoyo with a yoyobag equipped.
        if (item.melee && AccessoryProperties.equippedYoyoBag && ProjectileHandler.YoyoProj.Count > 0)
        {
            foreach (Projectile proj in ProjectileHandler.YoyoProj)
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

        //Gets the players position to be used later for calculating damage based on distance.
        if (item.ranged)
        {
            for (int x = 0; x < 2; x++)
            {
                OnHitProj.playerPosition = new Vector2(player.position.X, player.position.Y);
            }
        }
        return true;
    }
    
    //Decides if a weapon should consume ammo when shot while having cetain ranger items equipped.
    public override bool ConsumeAmmo(Item item, Player player)
    {
        int chance = 0;
        if (item.ranged && AccessoryProperties.equippedRangerEmblem)
        {
            chance += 10;
        }

        if (item.ranged && AccessoryProperties.equippedSniperScope)
        {
            chance += 15;
        }

        if (item.ranged && AccessoryProperties.equippedOOABuckler)
        {
            chance += 3;
        }

        return rand.Next(100) > chance;
    }
}
