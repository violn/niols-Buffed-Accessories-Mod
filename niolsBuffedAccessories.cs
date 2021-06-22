//This mod was made by niol#1299 add me on discord if you have any questions.
using System;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class BuffedAccessories : Mod
    {
        public static Random ran = new Random();
        public static Mod calamity = ModLoader.GetMod("CalamityMod");
        public static Mod thorium = ModLoader.GetMod("ThoriumMod");
        public static Mod elementsAwokened = ModLoader.GetMod("ElementsAwoken");
        public static Mod upgradedAccessories = ModLoader.GetMod("UpgradedAccessories");

        public override void Load()
        {
            ToggleSummon.toggleQuickSummon = RegisterHotKey("Quick Summon", "I");
        }
    }

    public class Reset : ModPlayer
    {
        public override void ResetEffects()
        {
            AccessoryProperties.equippedBee = false;
            AccessoryProperties.equippedStar = false;
            AccessoryProperties.equippedHive = false;
            AccessoryProperties.equippedPlagueHive = false;
            AccessoryProperties.equippedRangerEmblem = false;
            AccessoryProperties.equippedSniperScope = false;
            AccessoryProperties.equippedRifleScope = false;
            AccessoryProperties.equippedSorcerorEmblem = false;
            AccessoryProperties.equippedCelestialEmblem = false;
            AccessoryProperties.equippedMechGlove = false;
            AccessoryProperties.equippedWarriorEmblem = false;
            AccessoryProperties.equippedOOABuckler = false;
            AccessoryProperties.equippedYoyoBag = false;
            AccessoryProperties.equippedShackle = false;
            AccessoryProperties.equippedMagicCuffs = false;
            AccessoryProperties.equippedCelestialCuffs = false;
            AccessoryProperties.equippedCrossNecklace = false;
            AccessoryProperties.equippedPygmyNecklace = false;
            AccessoryProperties.equippedSufferWithMe = false;
        }
    }
}
