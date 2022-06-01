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
            AccessoryProperties.SpawmBees = false;
            AccessoryProperties.SpawnStars = false;
            AccessoryProperties.StrongBees = false;
            AccessoryProperties.RangedDupe = false;
            AccessoryProperties.ScopeIncrease = false;
            AccessoryProperties.MagicStacking = false;
            AccessoryProperties.BeserkerRage = false;
            AccessoryProperties.YoyoDupe = false;
            AccessoryProperties.DeathPrevention = false;
            AccessoryProperties.SummonImmunity = false;
            AccessoryProperties.EquippedStalkersQuiver = false;
            AccessoryProperties.EquippedMagicCuffs = false;
            AccessoryProperties.EquippedCelestialCuffs = false;
            AccessoryProperties.EquippedShackle = false;
            AccessoryProperties.EquippedHuntressBuckler = false;
        }
    }
}