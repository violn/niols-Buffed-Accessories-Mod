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
            AccessoryProperties.SpawnBees = false;
            AccessoryProperties.SpawnStars = false;
            AccessoryProperties.StrongBees = false;
            AccessoryProperties.RangedDupe = false;
            AccessoryProperties.ScopeIncrease = false;
            AccessoryProperties.MagicStacking = false;
            AccessoryProperties.BeserkerRage = false;
            AccessoryProperties.YoyoDupe = false;
            AccessoryProperties.DeathPrevention = false;
            AccessoryProperties.SummonImmunity = false;
            AccessoryProperties.Stalker = false;
            AccessoryProperties.Cuffs = false;
            AccessoryProperties.Celestial = false;
            AccessoryProperties.Shackle = false;
            AccessoryProperties.Huntress = false;
            AccessoryProperties.Band = false;
        }
    }
}