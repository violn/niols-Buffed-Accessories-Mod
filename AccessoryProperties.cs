using niolsBuffedAccessories.Buffed;
using niolsBuffedAccessories.Configs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class AccessoryProperties : GlobalItem
    {
        public static bool equippedBee = false;
        public static bool equippedStar = false;
        public static bool equippedRangerEmblem = false;
        public static bool equippedRifleScope = false;
        public static bool equippedSorcerorEmblem = false;
        public static bool equippedCelestialEmblem = false;
        public static bool equippedWarriorEmblem = false;
        public static bool equippedYoyoBag = false;
        public static bool equippedShackle = false;
        public static bool equippedMagicCuffs = false;
        public static bool equippedCelestialCuffs = false;
        public static bool equippedCrossNecklace = false;
        public static bool equippedPygmyNecklace = false;
        public static bool equippedBuckler = false;
        public static bool equippedHive = false;

        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (ModContent.GetInstance<Config>().AllBuffs)
            {
                switch (item.type)
                {
                    case ItemID.HoneyComb:
                        equippedBee = true;
                        break;

                    case ItemID.HoneyBalloon:
                        equippedBee = true;
                        break;

                    case ItemID.BalloonHorseshoeHoney:
                        equippedBee = true;
                        break;

                    case ItemID.StingerNecklace:
                        equippedBee = true;
                        break;

                    case ItemID.SweetheartNecklace:
                        equippedBee = true;
                        break;

                    case ItemID.BeeCloak:
                        equippedBee = equippedStar = true;
                        break;

                    case ItemID.StarCloak:
                        equippedStar = true;
                        break;

                    case ItemID.ManaCloak:
                        equippedStar = true;
                        break;

                    case ItemID.StarVeil:
                        equippedStar = equippedCrossNecklace = true;
                        break;

                    case ItemID.CrossNecklace:
                        equippedCrossNecklace = true;
                        break;

                    case ItemID.HiveBackpack:
                        equippedHive = true;
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
                        equippedSorcerorEmblem = ModContent.GetInstance<Config>().Sorceror;
                        break;

                    case ItemID.CelestialEmblem:
                        if (ModContent.GetInstance<Config>().CelestialEmblem)
                        {
                            player.manaRegenBonus += MageEmblem.celestialRegen;
                            player.manaRegenDelayBonus += 5;
                            player.statManaMax2 += 100;
                            player.manaCost *= .82f;
                            equippedSorcerorEmblem = true;
                            equippedCelestialEmblem = true;
                        }
                        break;

                    case ItemID.RangerEmblem:
                        equippedRangerEmblem = ModContent.GetInstance<Config>().Ranger;
                        break;

                    case ItemID.RifleScope:
                        equippedRifleScope = ModContent.GetInstance<Config>().Rifle;
                        break;

                    case ItemID.SniperScope:
                        equippedRangerEmblem = equippedRifleScope = ModContent.GetInstance<Config>().Sniper;
                        break;

                    case ItemID.MagicCuffs:
                        equippedMagicCuffs = ModContent.GetInstance<Config>().Magic;
                        break;

                    case ItemID.CelestialCuffs:
                        equippedCelestialCuffs = ModContent.GetInstance<Config>().CelestialCuffs;
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
                            equippedWarriorEmblem = true;
                        }
                        break;

                    case ItemID.MonkBelt:
                        if (ModContent.GetInstance<Config>().Belt)
                        {
                            player.maxMinions += 1;
                            player.meleeSpeed += .04f;
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
                            equippedBuckler = true;
                        }
                        break;

                    case ItemID.MechanicalGlove:
                        if (ModContent.GetInstance<Config>().Glove)
                        {
                            player.maxRunSpeed += 0.47f;
                            player.moveSpeed += 0.17f;
                            player.GetCritChance(DamageClass.Melee) += 12;
                            equippedWarriorEmblem = true;
                        }
                        break;

                    case ItemID.FireGauntlet:
                        if (ModContent.GetInstance<Config>().Glove)
                        {
                            player.maxRunSpeed += 0.54f;
                            player.moveSpeed += 0.20f;
                            player.GetDamage(DamageClass.Melee) += .03f;
                            player.GetCritChance(DamageClass.Melee) += 16;
                            player.meleeSpeed += 0.04f;
                            equippedWarriorEmblem = true;
                        }
                        break;

                    case ItemID.PygmyNecklace:
                        equippedPygmyNecklace = ModContent.GetInstance<Config>().Pygmy;
                        break;

                    case ItemID.Shackle:
                        equippedShackle = ModContent.GetInstance<Config>().Shackle;
                        break;

                    case ItemID.YoyoBag:
                        equippedYoyoBag = ModContent.GetInstance<Config>().Yoyo;
                        break;
                }
            }
        }
    }
}