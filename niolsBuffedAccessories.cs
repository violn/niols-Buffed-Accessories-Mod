using References;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class BuffedAccessories : Mod
    {
        //Does stuff on loading the game
        public override void Load()
        {
            AddItems();
        }

        //Add certain items with similar properties
        public static void AddItems()
        {
            Reference.beeItems.Add(1249);
            Reference.beeItems.Add(1132);
            Reference.beeItems.Add(1247);
            Reference.beeItems.Add(1578);
            Reference.beeItems.Add(3251);

            Reference.starItems.Add(532);
            Reference.starItems.Add(862);
            Reference.starItems.Add(1247);

            Reference.hiveItems.Add(3333);

            Reference.countweightBlackList.Add(556);
            Reference.countweightBlackList.Add(557);
            Reference.countweightBlackList.Add(558);
            Reference.countweightBlackList.Add(559);
            Reference.countweightBlackList.Add(560);
            Reference.countweightBlackList.Add(561);

            Reference.blackListedItems.Add(1553);
            Reference.blackListedItems.Add(2797);
            Reference.blackListedItems.Add(2624);
            Reference.blackListedItems.Add(679);
            Reference.blackListedItems.Add(534);
            Reference.blackListedItems.Add(1929);
            Reference.blackListedItems.Add(1229);
            Reference.blackListedItems.Add(1265);
            Reference.blackListedItems.Add(3029);
            Reference.blackListedItems.Add(3859);
            Reference.blackListedItems.Add(3854);
            Reference.blackListedItems.Add(533);
            Reference.blackListedItems.Add(98);
            Reference.blackListedItems.Add(3788);
            Reference.blackListedItems.Add(2270);
            Reference.blackListedItems.Add(3019);
            Reference.blackListedItems.Add(964);
            Reference.blackListedItems.Add(197);
            Reference.blackListedItems.Add(3540);
            Reference.blackListedItems.Add(434);
        }
    }

    //Reset variables to be rechecked
    public class Reset : ModPlayer
    {
        public override void ResetEffects()
        {
            Reference.equippedBee = false;
            Reference.equippedStar = false;
            Reference.equippedHive = false;
            Reference.equippedPlague = false;
            Reference.equippedRangerE = false;
            Reference.equippedSScope = false;
            Reference.equippedRScope = false;
            Reference.equippedSorcE = false;
            Reference.equippedCeleE = false;
            Reference.equippedMechGlove = false;
            Reference.equippedFGaunt = false;
            Reference.equippedWarE = false;
            Reference.equippedRegBand = false;
            Reference.equippedRegBand = false;
            Reference.equippedYoyoBag = false;
            Reference.celeRegen = 15;
            Reference.equippedOWABuckler = false;
        }
    }
}
