using Microsoft.Xna.Framework;
using System.Collections;
using Terraria;
using Terraria.ModLoader;

namespace References
{
    //Global variables that are called throughout classes
    public class Reference
    {
        public static Mod cal = ModLoader.GetMod("CalamityMod");
        public static Mod thor = ModLoader.GetMod("ThoriumMod");
        public static Mod ea = ModLoader.GetMod("ElementsAwoken");
        public static Mod upa = ModLoader.GetMod("UpgradedAccessories");
        public static Vector2 playerPosition;
        public static Vector2 targetPosition;
        public static float distanceDamageMultiplier;
        public static double depleteBoost = 0;
        public static double currentOnHitBoost = 0;
        public static int counter = 0;
        public static int counter2 = 0;
        public static int counter3 = 0;
        public static int delayCounter = 0;
        public static int secondsPassed = 0;
        public static int secondsPassed2 = 0;
        public static int celeRegen = 15;
        public static int buffCheck1 = 0;
        public static int buffCheck2 = 0;
        public static int buffCheck3 = 0;
        public static int beesSpawned = 0;
        public static int starsSpawned = 0;
        public static Item itemUsed;
        public static bool equippedBee = false;
        public static bool equippedStar = false;
        public static bool equippedHive = false;
        public static bool equippedPlague = false;
        public static bool equippedRangerE = false;
        public static bool equippedSScope = false;
        public static bool equippedRScope = false;
        public static bool equippedSorcE = false;
        public static bool equippedCeleE = false;
        public static bool equippedMechGlove = false;
        public static bool equippedFGaunt = false;
        public static bool equippedWarE = false;
        public static bool equippedRegBand = false;
        public static bool blockBees = false;
        public static bool blockStars = false;
        public static bool equippedYoyoBag = false;
        public static bool equippedOWABuckler = false;
        public static ArrayList yoyoProj = new ArrayList();
        public static ArrayList countweightBlackList = new ArrayList();
        public static ArrayList beeItems = new ArrayList();
        public static ArrayList starItems = new ArrayList();
        public static ArrayList hiveItems = new ArrayList();
        public static ArrayList blackListedItems = new ArrayList();
        public static ArrayList addedAutoSwing = new ArrayList();
    }
}
