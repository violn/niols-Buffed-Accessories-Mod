using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace niolsBuffedAccessories.Configs
{
    public class Config : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("Buff Toggles")]
        [Label("Item Buffs")]
        [Tooltip("Toggles the buffed accessories")]
        [DefaultValue(true)]
        public bool AllBuffs;

        [Label("Bee Spawning")]
        [Tooltip("Toggles bee spawning items. (Items that have the honey comb in their recipe)")]
        [DefaultValue(true)]
        public bool SpawnBees;

        [Label("Star Spawning")]
        [Tooltip("Toggles star spawning items. (Items that have the star cloak in their recipe)")]
        [DefaultValue(true)]
        public bool SpawnStars;

        [Label("Strong Bee Spawning")]
        [Tooltip("Toggles strong bee spawning items. (Hive Pack)")]
        [DefaultValue(true)]
        public bool StrongBee;

        [Label("Ranged Duplication")]
        [Tooltip("Toggles ranged projectile duplication items. (Ranger Emblem, Sniper Scope)")]
        [DefaultValue(true)]
        public bool RangedDupe;

        [Label("Scope Damage Increase")]
        [Tooltip("Toggles damage increasing based on distance items. (Recon Scope, Sniper Scope, Rifle Scope)")]
        [DefaultValue(true)]
        public bool ScopeIncrease;

        [Label("Magic Stacks")]
        [Tooltip("Toggles items that give magic stacks. (Sorcerer Emblem, Celestial Emblem)")]
        [DefaultValue(true)]
        public bool MagicStacking;

        [Label("Extra Yoyo")]
        [Tooltip("Toggles items that spawn an extra yoyo prjectile. (Yoyo Bag)")]
        [DefaultValue(true)]
        public bool ExtraYoyo;

        [Label("Death Prevention")]
        [Tooltip("Toggles items that prevent death. (Cross Necklace)")]
        [DefaultValue(true)]
        public bool DeathPrevention;

        [Label("Remove Summon I-Frames")]
        [Tooltip("Toggles items that remove the summon iframes. (Pygmy Necklace)")]
        [DefaultValue(true)]
        public bool SummonImmunity;

        [Label("BeserkerRage")]
        [Tooltip("Toggles the enhance mana regeneration buff. (Items that have the star cloak in their recipe)")]
        [DefaultValue(true)]
        public bool BeserkerRage;
    }
}
