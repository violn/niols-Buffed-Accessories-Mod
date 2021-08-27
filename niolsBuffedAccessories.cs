//This mod was made by niol#1299 add me on discord if you have any questions.
using System;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class BuffedAccessories : Mod
    {
        public static Random ran = new();
    }

    public class Reset : ModPlayer
    {
        public override void ResetEffects()
        {
            AccessoryProperties.equippedBee = false;
            AccessoryProperties.equippedStar = false;
            AccessoryProperties.equippedHive = false;
            AccessoryProperties.equippedRangerEmblem = false;
            AccessoryProperties.equippedRifleScope = false;
            AccessoryProperties.equippedSorcerorEmblem = false;
            AccessoryProperties.equippedCelestialEmblem = false;
            AccessoryProperties.equippedWarriorEmblem = false;
            AccessoryProperties.equippedBuckler = false;
            AccessoryProperties.equippedYoyoBag = false;
            AccessoryProperties.equippedShackle = false;
            AccessoryProperties.equippedMagicCuffs = false;
            AccessoryProperties.equippedCelestialCuffs = false;
            AccessoryProperties.equippedCrossNecklace = false;
            AccessoryProperties.equippedPygmyNecklace = false;
        }
    }
}