using System;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class BuffedAccessories : Mod
    {
        public static Random Ran = new();
    }

    public class Reset : ModPlayer
    {
        public override void ResetEffects()
        {
            AccessoryProperties.EquippedBee = false;
            AccessoryProperties.EquippedStar = false;
            AccessoryProperties.EquippedHive = false;
            AccessoryProperties.EquippedRangerEmblem = false;
            AccessoryProperties.EquippedRifleScope = false;
            AccessoryProperties.EquippedSorcerorEmblem = false;
            AccessoryProperties.EquippedCelestialEmblem = false;
            AccessoryProperties.EquippedWarriorEmblem = false;
            AccessoryProperties.EquippedBuckler = false;
            AccessoryProperties.EquippedYoyoBag = false;
            AccessoryProperties.EquippedShackle = false;
            AccessoryProperties.EquippedMagicCuffs = false;
            AccessoryProperties.EquippedCelestialCuffs = false;
            AccessoryProperties.EquippedCrossNecklace = false;
            AccessoryProperties.EquippedPygmyNecklace = false;
        }
    }
}