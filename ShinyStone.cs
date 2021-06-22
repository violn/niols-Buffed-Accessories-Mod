using Microsoft.Xna.Framework;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class ShinyStone
{
    public static bool playerIsStill = false;
    public static bool breakStill = false;
    public static int stoneDefBoost = 0;
}

public class BreakStillStateItem : GlobalItem
{
    public override bool UseItem(Item item, Player player)
    {
        ShinyStone.breakStill = true;
        return base.UseItem(item, player);
    }

    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        ShinyStone.breakStill = true;
        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }
}

public class BreakStillStatePlayer : ModPlayer
{
    public override void PostUpdate()
    {
        ShinyStone.playerIsStill = true;

        if (player.velocity.X != 0 || player.velocity.Y != 0)
        {
            ShinyStone.playerIsStill = false;
        }

        foreach (var _ in from int b in player.buffType
                          where b == BuffID.BrokenArmor
                          select new { })
            ShinyStone.playerIsStill = false;

        if (ShinyStone.breakStill)
        {
            ShinyStone.playerIsStill = false;
            ShinyStone.breakStill = false;
        }
    }

    public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
    {
        ShinyStone.playerIsStill = false;
    }
}
