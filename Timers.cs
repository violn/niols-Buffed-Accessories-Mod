using niolsBuffedAccessories.Buffed;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class Timers : ModPlayer
    {
        public static int MagicCounter = 0;
        public static int MagicStacksDelay = 0;
        public static int BeeTimer = 0;
        public static int StarTimer = 0;

        public override void PostUpdateEquips()
        {
            MagicStacksDelay += MagicStacksDelay < 260 ? 1 : 0;

            if (MagicCounter > 12 && MagicStacksDelay > 120)
            {
                MageEmblem.CurrentOnHitBoost -= MageEmblem.CurrentOnHitBoost - .01f < 0f ? 
                    MageEmblem.CurrentOnHitBoost : .01f;

                MageEmblem.CelestialRegen -= MageEmblem.CelestialRegen > 15 ? 1 : 0;
                MagicCounter = 0;
            }

            SpawnProjectiles.BeesSpawned = BeeTimer == 120 ? 0 : SpawnProjectiles.StarsSpawned;
            SpawnProjectiles.StarsSpawned = StarTimer == 120 ? 0 : SpawnProjectiles.StarsSpawned;

            BeeTimer++;
            StarTimer++;
            MagicCounter++;
        }
    }
}