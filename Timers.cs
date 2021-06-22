using Terraria.ModLoader;

public class Timers : ModPlayer
{
    public static int magicCounter = 0;
    public static int magicStacksDelay = 0;
    public static int beeTimer = 0;
    public static int starTimer = 0;
    public static int stoneTimer = 0;

    public override void PostUpdateEquips()
    {
        if (!player.shinyStone || !ShinyStone.playerIsStill)
        {
            player.statDefense -= ShinyStone.stoneDefBoost;
            ShinyStone.stoneDefBoost = 0;
        }
        else player.statDefense += ShinyStone.stoneDefBoost;

        if (magicStacksDelay < 260)
        {
            magicStacksDelay++;
        }

        if (magicCounter > 12 && magicStacksDelay > 120)
        {
            MageEmblem.currentOnHitBoost -= MageEmblem.currentOnHitBoost - .01f < 0f ? MageEmblem.currentOnHitBoost : .01f;

            if (MageEmblem.celestialRegen > 15)
            {
                MageEmblem.celestialRegen -= 1;
            }

            magicCounter = 0;
        }

        if (stoneTimer > 60)
        {
            if (player.shinyStone && ShinyStone.playerIsStill)
            {
                if (ShinyStone.stoneDefBoost <= 50)
                {
                    ShinyStone.stoneDefBoost++;
                }
            }

            stoneTimer = 0;
        }

        if (beeTimer == 120)
        {
            SpawnProjectiles.BeesSpawned = 0;
        }

        if (starTimer == 120)
        {
            SpawnProjectiles.StarsSpawned = 0;
        }

        beeTimer++;
        starTimer++;
        stoneTimer++;
        magicCounter++;
    }
}
