using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class BreakStillState
{
    /// <summary>
    /// Checks whether or not the player is still.
    /// </summary>
    public static bool stillState = false;

    /// <summary>
    /// Checks whether or not the player is still.
    /// </summary>
    public static bool breakStillItem = false;

    /// <summary>
    /// The defense boost a player gets when being still with the shiny stone.
    /// </summary>
    public static int StoneDefBoost = 0;
}

public class BreakStillStateItem : GlobalItem
{
    public override bool UseItem(Item item, Player player)
    {
        BreakStillState.breakStillItem = true;
        return base.UseItem(item, player);
    }

    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        BreakStillState.breakStillItem = true;
        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }
}

public class BreakStillStatePlayer : ModPlayer
{
    public override void PostUpdate()
    {
        BreakStillState.stillState = true;

        if (player.velocity.X != 0)
        {
            BreakStillState.stillState = false;
        }

        if (player.velocity.Y != 0)
        {
            BreakStillState.stillState = false;
        }

        for (int x = 0; x < player.buffType.Length; x++)
        {
            if (player.buffType[x] == BuffID.BrokenArmor)
            {
                BreakStillState.stillState = false;
            }
        }

        if(BreakStillState.breakStillItem)
        {
            BreakStillState.stillState = false;
            BreakStillState.breakStillItem = false;
        }
    }

    public override void Hurt(bool pvp, bool quiet, double damage, int hitDirection, bool crit)
    {
        BreakStillState.stillState = false;
    }
}