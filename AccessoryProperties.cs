using niolsBuffedAccessories.Buffed;
using niolsBuffedAccessories.Configs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class AccessoryProperties : GlobalItem
    {
        public static bool SpawnBees = false;
        public static bool SpawnStars = false;
        public static bool StrongBees = false;
        public static bool RangedDupe = false;
        public static bool ScopeIncrease = false;
        public static bool MagicStacking = false;
        public static bool BeserkerRage = false;
        public static bool YoyoDupe = false;
        public static bool DeathPrevention = false;
        public static bool SummonImmunity = false;
        public static bool Stalker = false;
        public static bool Cuffs = false;
        public static bool Celestial = false;
        public static bool Shackle = false;
        public static bool Huntress = false;
        public static bool Band = false;

        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (ModContent.GetInstance<Config>().AllBuffs)
            {
                switch (item.type)
                {
                    case ItemID.BandofStarpower:
                        Band = ModContent.GetInstance<Config>().Band;
                        break;

                    case ItemID.ManaRegenerationBand:
                        Band = ModContent.GetInstance<Config>().Band;
                        break;

                    case ItemID.HoneyComb:
                        SpawnBees = ModContent.GetInstance<Config>().SpawnBees;
                        break;

                    case ItemID.HoneyBalloon:
                        SpawnBees = ModContent.GetInstance<Config>().SpawnBees;
                        break;

                    case ItemID.BalloonHorseshoeHoney:
                        SpawnBees = ModContent.GetInstance<Config>().SpawnBees;
                        break;

                    case ItemID.StingerNecklace:
                        SpawnBees = ModContent.GetInstance<Config>().SpawnBees;
                        break;

                    case ItemID.SweetheartNecklace:
                        SpawnBees = ModContent.GetInstance<Config>().SpawnBees;
                        break;

                    case ItemID.BeeCloak:
                        SpawnBees = ModContent.GetInstance<Config>().SpawnBees;
                        SpawnStars = ModContent.GetInstance<Config>().SpawnStars;
                        break;

                    case ItemID.StarCloak:
                        SpawnStars = ModContent.GetInstance<Config>().SpawnStars;
                        break;

                    case ItemID.ManaCloak:
                        SpawnStars = ModContent.GetInstance<Config>().SpawnStars;
                        break;

                    case ItemID.StarVeil:
                        SpawnStars = ModContent.GetInstance<Config>().SpawnStars;
                        DeathPrevention = ModContent.GetInstance<Config>().DeathPrevention;
                        break;

                    case ItemID.CrossNecklace:
                        DeathPrevention = ModContent.GetInstance<Config>().DeathPrevention;
                        break;

                    case ItemID.HiveBackpack:
                        StrongBees = ModContent.GetInstance<Config>().StrongBee;
                        break;

                    case ItemID.BandofRegeneration:

                        player.lifeRegen += 1;
                        break;

                    case ItemID.CharmofMyths:

                        player.lifeRegen += 3;
                        break;

                    case ItemID.SorcererEmblem:
                        MagicStacking = ModContent.GetInstance<Config>().MagicStacking;
                        break;

                    case ItemID.CelestialEmblem:
                        player.manaRegenBonus += MageEmblem.CelestialRegen;
                        player.manaRegenDelayBonus += 5;
                        player.statManaMax2 += 100;
                        player.manaCost *= .82f;
                        MagicStacking = ModContent.GetInstance<Config>().MagicStacking;
                        break;

                    case ItemID.RangerEmblem:
                        RangedDupe = ModContent.GetInstance<Config>().RangedDupe;
                        break;

                    case ItemID.RifleScope:
                        ScopeIncrease = ModContent.GetInstance<Config>().ScopeIncrease;
                        break;

                    case ItemID.SniperScope:
                        ScopeIncrease = ModContent.GetInstance<Config>().ScopeIncrease;
                        break;

                    case ItemID.ReconScope:
                        RangedDupe = ModContent.GetInstance<Config>().RangedDupe;
                        ScopeIncrease = ModContent.GetInstance<Config>().ScopeIncrease;
                        break;

                    case ItemID.MagicCuffs:
                        Cuffs = true;
                        Band = ModContent.GetInstance<Config>().Band;
                        break;

                    case ItemID.CelestialCuffs:
                        Celestial = true;
                        Band = ModContent.GetInstance<Config>().Band;
                        break;

                    case ItemID.SummonerEmblem:

                        player.maxMinions += 1;
                        player.maxTurrets += 1;
                        break;

                    case ItemID.WarriorEmblem:
                        player.maxRunSpeed += 0.27f;
                        player.moveSpeed += .10f;
                        player.GetCritChance(DamageClass.Melee) += 8;
                        BeserkerRage = ModContent.GetInstance<Config>().BeserkerRage;
                        break;

                    case ItemID.MonkBelt:
                        player.maxMinions += 1;
                        player.GetAttackSpeed(DamageClass.Melee) += .04f;
                        player.maxRunSpeed += 0.27f;
                        player.moveSpeed += .05f;
                        player.GetDamage(DamageClass.Melee) += .04f;
                        player.GetDamage(DamageClass.Summon) += .05f;
                        player.GetCritChance(DamageClass.Melee) += 4;
                        break;

                    case ItemID.ApprenticeScarf:
                        player.manaCost *= .97f;
                        player.maxRunSpeed += 0.27f;
                        player.moveSpeed += .04f;
                        player.GetDamage(DamageClass.Magic) += .04f;
                        player.GetDamage(DamageClass.Summon) += .05f;
                        player.GetCritChance(DamageClass.Magic) += 4;
                        break;

                    case ItemID.SquireShield:
                        player.maxRunSpeed += 0.27f;
                        player.moveSpeed += .05f;
                        player.lifeRegen += 1;
                        player.GetDamage(DamageClass.Melee) += .02f;
                        player.GetDamage(DamageClass.Summon) += .05f;
                        player.GetCritChance(DamageClass.Melee) += 4;
                        break;

                    case ItemID.HuntressBuckler:
                        player.maxMinions += 1;
                        player.maxRunSpeed += 0.27f;
                        player.moveSpeed += .04f;
                        player.GetDamage(DamageClass.Ranged) += .04f;
                        player.GetDamage(DamageClass.Summon) += .05f;
                        player.GetCritChance(DamageClass.Ranged) += 4;
                        Huntress = true;
                        break;

                    case ItemID.MechanicalGlove:
                        player.maxRunSpeed += 0.47f;
                        player.moveSpeed += 0.17f;
                        player.GetCritChance(DamageClass.Melee) += 12;
                        BeserkerRage = ModContent.GetInstance<Config>().BeserkerRage;
                        break;

                    case ItemID.FireGauntlet:
                        player.maxRunSpeed += 0.54f;
                        player.moveSpeed += 0.20f;
                        player.GetDamage(DamageClass.Melee) += .03f;
                        player.GetCritChance(DamageClass.Melee) += 16;
                        player.GetAttackSpeed(DamageClass.Melee) += 0.04f;
                        BeserkerRage = ModContent.GetInstance<Config>().BeserkerRage;
                        break;

                    case ItemID.PygmyNecklace:
                        SummonImmunity = ModContent.GetInstance<Config>().SummonImmunity;
                        break;

                    case ItemID.Shackle:
                        Shackle = true;
                        break;

                    case ItemID.YoyoBag:
                        YoyoDupe = ModContent.GetInstance<Config>().ExtraYoyo;
                        break;

                    case ItemID.ArcaneFlower:
                        player.GetDamage(DamageClass.Magic) += .10f;
                        player.GetCritChance(DamageClass.Magic) += 5;
                        break;

                    case ItemID.StalkersQuiver:
                        Stalker = true;
                        break;
                }
            }
        }
    }
}