using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace niolsBuffedAccessories.Configs
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [DefaultValue(true)]
        public bool AllBuffs;

        [DefaultValue(true)]
        public bool SpawnBees;

        [DefaultValue(true)]
        public bool SpawnStars;

        [DefaultValue(true)]
        public bool StrongBee;

        [DefaultValue(true)]
        public bool RangedDupe;

        [DefaultValue(true)]
        public bool ScopeIncrease;

        [DefaultValue(true)]
        public bool MagicStacking;

        [DefaultValue(true)]
        public bool ExtraYoyo;

        [DefaultValue(true)]
        public bool DeathPrevention;

        [DefaultValue(true)]
        public bool SummonImmunity;

        [DefaultValue(true)]
        public bool BeserkerRage;

        [DefaultValue(true)]
        public bool Band;
    }
}
