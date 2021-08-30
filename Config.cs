using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace niolsBuffedAccessories.Configs
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("Item Toggles")]
        [Label("Items Buffs")]
        [Tooltip("Toggle item stats and property buffs.")]
        [DefaultValue(true)]
        public bool AllBuffs;

        [Label("Shackle")]
        [DefaultValue(true)]
        public bool Shackle;

        [Label("Bee")]
        [DefaultValue(true)]
        public bool Bee;

        [Label("Star")]
        [DefaultValue(true)]
        public bool Star;

        [Label("Band of Regeneration")]
        [DefaultValue(true)]
        public bool Band;

        [Label("Charm of Myths")]
        [DefaultValue(true)]
        public bool Charm;

        [Label("Ranger Emblem")]
        [DefaultValue(true)]
        public bool Ranger;

        [Label("Rifle Scope")]
        [DefaultValue(true)]
        public bool Rifle;

        [Label("Sniper Scope")]
        [DefaultValue(true)]
        public bool Sniper;

        [Label("Sorceror Emblem")]
        [DefaultValue(true)]
        public bool Sorceror;

        [Label("Celestial Emblem")]
        [DefaultValue(true)]
        public bool CelestialEmblem;

        [Label("Warrior Emblem")]
        [DefaultValue(true)]
        public bool Warrior;

        [Label("Mech Glove")]
        [DefaultValue(true)]
        public bool Glove;

        [Label("Fire Gauntlet")]
        [DefaultValue(true)]
        public bool Gauntlet;

        [Label("Yoyo Bag")]
        [DefaultValue(true)]
        public bool Yoyo;

        [Label("Magic Cuffs")]
        [DefaultValue(true)]
        public bool Magic;

        [Label("Celestial Cuffs")]
        [DefaultValue(true)]
        public bool CelestialCuffs;

        [Label("Cross Necklace")]
        [DefaultValue(true)]
        public bool Cross;

        [Label("Pygmy Necklace")]
        [DefaultValue(true)]
        public bool Pygmy;

        [Label("Summoner Emblem")]
        [DefaultValue(true)]
        public bool Summon;

        [Label("Monk Belt")]
        [DefaultValue(true)]
        public bool Belt;

        [Label("Apprentice Scarf")]
        [DefaultValue(true)]
        public bool Scarf;

        [Label("Squire Shield")]
        [DefaultValue(true)]
        public bool Shield;

        [Label("Huntress Buckler")]
        [DefaultValue(true)]
        public bool Buckler;

        [Label("Recon Scope")]
        [DefaultValue(true)]
        public bool Recon;
    }
}
