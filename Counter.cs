using Terraria.ModLoader;

//Used for timing stuff.
public class Counter : ModPlayer
{
    public static int Count = 0;
    public static int DelayCount = 0;
    public static int SecondsPassed = 0;
    public static int SecondsPassed2 = 0;
    public static int Counter2 = 0;
    public static int Counter3 = 0;

    public override void PostUpdateEquips()
    {
        if (!player.shinyStone || !BreakStillState.stillState)
        {
            player.statDefense -= BreakStillState.StoneDefBoost;
            BreakStillState.StoneDefBoost = 0;
        }
        else player.statDefense += BreakStillState.StoneDefBoost;

        Count++;

        Counter2++;

        Counter3++;

        if (DelayCount < 260)
        {
            DelayCount++;
        }

        if (Count > 12 && DelayCount > 120)
        {
            if (OnHitProj.depleteBoost < .31)
            {
                OnHitProj.depleteBoost += .01;
            }

            if (OnHitProj.celestialRegen > 15)
            {
                OnHitProj.celestialRegen -= 1;
            }

            Count = 0;
        }

        if (Counter2 > 60)
        {
            if (player.shinyStone && BreakStillState.stillState)
            {
                if (BreakStillState.StoneDefBoost <= 50)
                {
                    BreakStillState.StoneDefBoost++;
                }
            }

            Counter2 = 0;
            SecondsPassed++;
        }

        if (Counter3 > 60)
        {
            Counter3 = 0;
            SecondsPassed2++;
        }

        if (SecondsPassed > 0)
        {
            if (SecondsPassed > 0)
            {
                ProjectileHandler.BeesSpawned = 0;
            }

            if (SecondsPassed > 10)
            {
                SecondsPassed = 0;
            }
        }

        if (SecondsPassed2 > 0)
        {
            if (SecondsPassed2 > 2)
            {
                ProjectileHandler.StarsSpawned = 0;
            }

            if (SecondsPassed2 > 10)
            {
                SecondsPassed2 = 0;
            }
        }
    }
}