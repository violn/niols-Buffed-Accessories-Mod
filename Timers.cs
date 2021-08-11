using niolsBuffedAccessories.Buffed;
using System;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class Timers : ModPlayer
    {
        public static int magicCounter = 0;
        public static int magicStacksDelay = 0;
        public static int beeTimer = 0;
        public static int starTimer = 0;

        public override void PostUpdateEquips()
        {
            magicStacksDelay += magicStacksDelay < 260 ? 1 : 0;

            if (magicCounter > 12 && magicStacksDelay > 120)
            {
                MageEmblem.currentOnHitBoost -= MageEmblem.currentOnHitBoost - .01f < 0f ? MageEmblem.currentOnHitBoost : .01f;

                if (MageEmblem.celestialRegen > 15)
                {
                    MageEmblem.celestialRegen -= 1;
                }

                magicCounter = 0;
            }

            SpawnProjectiles.BeesSpawned = beeTimer == 120 ? 0 : SpawnProjectiles.StarsSpawned;
            SpawnProjectiles.StarsSpawned = starTimer == 120 ? 0 : SpawnProjectiles.StarsSpawned;

            beeTimer++;
            starTimer++;
            magicCounter++;
        }
    }
}