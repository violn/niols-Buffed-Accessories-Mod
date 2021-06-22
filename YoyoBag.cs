using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

public class YoyoBag : GlobalItem
{
    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        if (AccessoryProperties.equippedYoyoBag && YoyoProjectiles.yoyoProjectiles.Contains(type))
        {
            SpawnProjectiles.CreateDuplicate(type, position, speedX, speedY, damage, knockBack, 2);
        }

        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }
}

public class YoyoProjectiles : GlobalProjectile
{
    public static List<int> yoyoProjectiles = new List<int>();

    public static List<int> countweightBlackList = new List<int>()
    {
        556,
        557,
        558,
        559,
        560,
        561
    };

    public override void SetDefaults(Projectile proj)
    {
        if (!yoyoProjectiles.Contains(proj.type) && proj.aiStyle == 99 && !countweightBlackList.Contains(proj.type))
        {
            yoyoProjectiles.Add(proj.type);
        }
    }
}