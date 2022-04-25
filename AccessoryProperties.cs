using niolsBuffedAccessories.Buffed;
using niolsBuffedAccessories.Configs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class AccessoryProperties : GlobalItem
    {
        public static bool EquippedBee = false;
        public static bool EquippedStar = false;
        public static bool EquippedRangerEmblem = false;
        public static bool EquippedRifleScope = false;
        public static bool EquippedSorcerorEmblem = false;
        public static bool EquippedCelestialEmblem = false;
        public static bool EquippedWarriorEmblem = false;
        public static bool EquippedYoyoBag = false;
        public static bool EquippedShackle = false;
        public static bool EquippedMagicCuffs = false;
        public static bool EquippedCelestialCuffs = false;
        public static bool EquippedCrossNecklace = false;
        public static bool EquippedPygmyNecklace = false;
        public static bool EquippedBuckler = false;
        public static bool EquippedHive = false;

        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (ModContent.GetInstance<Config>().AllBuffs)
            {
                switch (item.type)
                {
                    case ItemID.HoneyComb:
                        EquippedBee = true;
                        break;

                    case ItemID.HoneyBalloon:
                        EquippedBee = true;
                        break;

                    case ItemID.BalloonHorseshoeHoney:
                        EquippedBee = true;
                        break;

                    case ItemID.StingerNecklace:
                        EquippedBee = true;
                        break;

                    case ItemID.SweetheartNecklace:
                        EquippedBee = true;
                        break;

                    case ItemID.BeeCloak:
                        EquippedBee = EquippedStar = true;
                        break;

                    case ItemID.StarCloak:
                        EquippedStar = true;
                        break;

                    case ItemID.ManaCloak:
                        EquippedStar = true;
                        break;

                    case ItemID.StarVeil:
                        EquippedStar = EquippedCrossNecklace = true;
                        break;

                    case ItemID.CrossNecklace:
                        EquippedCrossNecklace = true;
                        break;

                    case ItemID.HiveBackpack:
                        EquippedHive = true;
                        break;

                    case ItemID.BandofRegeneration:
                        if (ModContent.GetInstance<Config>().Band)
                        {
                            player.lifeRegen += 1;
                        }
                        break;

                    case ItemID.CharmofMyths:
                        if (ModContent.GetInstance<Config>().Charm)
                        {
                            player.lifeRegen += 3;
                        }
                        break;

                    case ItemID.SorcererEmblem:
                        EquippedSorcerorEmblem = ModContent.GetInstance<Config>().Sorceror;
                        break;

                    case ItemID.CelestialEmblem:
                        if (ModContent.GetInstance<Config>().CelestialEmblem)
                        {
                            player.manaRegenBonus += MageEmblem.CelestialRegen;
                            player.manaRegenDelayBonus += 5;
                            player.statManaMax2 += 100;
                            player.manaCost *= .82f;
                            EquippedSorcerorEmblem = true;
                            EquippedCelestialEmblem = true;
                        }
                        break;

                    case ItemID.RangerEmblem:
                        EquippedRangerEmblem = ModContent.GetInstance<Config>().Ranger;
                        break;

                    case ItemID.RifleScope:
                        EquippedRifleScope = ModContent.GetInstance<Config>().Rifle;
                        break;

                    case ItemID.SniperScope:
                        EquippedRangerEmblem = EquippedRifleScope = ModContent.GetInstance<Config>().Sniper;
                        break;

                    case ItemID.ReconScope:
                        EquippedRangerEmblem = EquippedRifleScope = ModContent.GetInstance<Config>().Recon;
                        break;

                    case ItemID.MagicCuffs:
                        EquippedMagicCuffs = ModContent.GetInstance<Config>().Magic;
                        break;

                    case ItemID.CelestialCuffs:
                        EquippedCelestialCuffs = ModContent.GetInstance<Config>().CelestialCuffs;
                        break;

                    case ItemID.SummonerEmblem:
                        if (ModContent.GetInstance<Config>().Summon)
                        {
                            player.maxMinions += 2;
                            player.maxTurrets += 2;
                        }
                        break;

                    case ItemID.WarriorEmblem:
                        if (ModContent.GetInstance<Config>().Warrior)
                        {
                            player.maxRunSpeed += 0.27f;
                            player.moveSpeed += .10f;
                            player.GetCritChance(DamageClass.Melee) += 8;
                            EquippedWarriorEmblem = true;
                        }
                        break;

                    case ItemID.MonkBelt:
                        if (ModContent.GetInstance<Config>().Belt)
                        {
                            player.maxMinions += 1;
                            player.GetAttackSpeed(DamageClass.Melee) += .04f;
                            player.maxRunSpeed += 0.27f;
                            player.moveSpeed += .05f;
                            player.GetDamage(DamageClass.Melee) += .04f;
                            player.GetDamage(DamageClass.Summon) += .05f;
                            player.GetCritChance(DamageClass.Melee) += 4;
                        }
                        break;

                    case ItemID.ApprenticeScarf:
                        if (ModContent.GetInstance<Config>().Scarf)
                        {
                            player.maxMinions += 1;
                            player.manaCost *= .97f;
                            player.maxRunSpeed += 0.27f;
                            player.moveSpeed += .04f;
                            player.GetDamage(DamageClass.Magic) += .04f;
                            player.GetDamage(DamageClass.Summon) += .05f;
                            player.GetCritChance(DamageClass.Magic) += 4;
                        }
                        break;

                    case ItemID.SquireShield:
                        if (ModContent.GetInstance<Config>().Shield)
                        {
                            player.maxMinions += 1;
                            player.maxRunSpeed += 0.27f;
                            player.moveSpeed += .5f;
                            player.lifeRegen += 1;
                            player.GetDamage(DamageClass.Melee) += .02f;
                            player.GetDamage(DamageClass.Summon) += .05f;
                            player.GetCritChance(DamageClass.Melee) += 4;
                        }
                        break;

                    case ItemID.HuntressBuckler:
                        if (ModContent.GetInstance<Config>().Buckler)
                        {
                            player.maxMinions += 1;
                            player.maxRunSpeed += 0.27f;
                            player.moveSpeed += .04f;
                            player.GetDamage(DamageClass.Ranged) += .04f;
                            player.GetDamage(DamageClass.Summon) += .05f;
                            player.GetCritChance(DamageClass.Ranged) += 4;
                            EquippedBuckler = true;
                        }
                        break;

                    case ItemID.MechanicalGlove:
                        if (ModContent.GetInstance<Config>().Glove)
                        {
                            player.maxRunSpeed += 0.47f;
                            player.moveSpeed += 0.17f;
                            player.GetCritChance(DamageClass.Melee) += 12;
                            EquippedWarriorEmblem = true;
                        }
                        break;

                    case ItemID.FireGauntlet:
                        if (ModContent.GetInstance<Config>().Glove)
                        {
                            player.maxRunSpeed += 0.54f;
                            player.moveSpeed += 0.20f;
                            player.GetDamage(DamageClass.Melee) += .03f;
                            player.GetCritChance(DamageClass.Melee) += 16;
                            player.GetAttackSpeed(DamageClass.Melee) += 0.04f;
                            EquippedWarriorEmblem = true;
                        }
                        break;

                    case ItemID.PygmyNecklace:
                        EquippedPygmyNecklace = ModContent.GetInstance<Config>().Pygmy;
                        break;

                    case ItemID.Shackle:
                        EquippedShackle = ModContent.GetInstance<Config>().Shackle;
                        break;

                    case ItemID.YoyoBag:
                        EquippedYoyoBag = ModContent.GetInstance<Config>().Yoyo;
                        break;
                }
            }
        }
    }
}