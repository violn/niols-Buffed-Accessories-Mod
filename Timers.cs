using niolsBuffedAccessories.Buffed;
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
                MageEmblem.celestialRegen -= MageEmblem.celestialRegen > 15 ? 1 : 0;
                magicCounter = 0;
            }

            SpawnProjectiles.beesSpawned = beeTimer == 120 ? 0 : SpawnProjectiles.starsSpawned;
            SpawnProjectiles.starsSpawned = starTimer == 120 ? 0 : SpawnProjectiles.starsSpawned;

            beeTimer++;
            starTimer++;
            magicCounter++;
        }
    }
}