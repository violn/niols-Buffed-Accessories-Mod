using niolsBuffedAccessories.Buffed;
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
                    equippedBee = true;
                    equippedStar = true;
                    break;

                case ItemID.StarCloak:
                    equippedStar = true;
                    break;

                case ItemID.ManaCloak:
                    equippedStar = true;
                    break;

                case ItemID.StarVeil:
                    equippedStar = true;
                    equippedCrossNecklace = true;
                    break;

                case ItemID.CrossNecklace:
                    equippedCrossNecklace = true;
                    break;

                case ItemID.HiveBackpack:
                    equippedHive = true;
                    break;

                case ItemID.BandofRegeneration:
                    player.lifeRegen += 1;
                    break;

                case ItemID.CharmofMyths:
                    player.lifeRegen += 3;
                    break;

                case ItemID.SorcererEmblem:
                    player.statManaMax2 += 50;
                    player.manaCost *= .85f;
                    equippedSorcerorEmblem = true;
                    break;

                case ItemID.CelestialEmblem:
                    player.manaRegenBonus += MageEmblem.celestialRegen;
                    player.manaRegenDelayBonus += 5;
                    player.statManaMax2 += 100;
                    player.manaCost *= .82f;
                    equippedSorcerorEmblem = true;
                    equippedCelestialEmblem = true;
                    break;

                case ItemID.RangerEmblem:
                    equippedRangerEmblem = true;
                    break;

                case ItemID.RifleScope:
                    equippedRifleScope = true;
                    break;

                case ItemID.SniperScope:
                    equippedRangerEmblem = true;
                    equippedRifleScope = true;
                    break;

                case ItemID.MagicCuffs:
                    player.manaRegenBonus += 33;
                    player.manaRegenDelayBonus += 1;
                    equippedMagicCuffs = true;
                    break;

                case ItemID.CelestialCuffs:
                    player.manaRegenBonus += 38;
                    player.manaRegenDelayBonus += 2;
                    equippedCelestialCuffs = true;
                    break;

                case ItemID.SummonerEmblem:
                    player.maxMinions += 2;
                    player.maxTurrets += 2;
                    break;

                case ItemID.WarriorEmblem:
                    player.maxRunSpeed += 0.27f;
                    player.moveSpeed += .10f;
                    player.GetCritChance(DamageClass.Melee) += 8;
                    equippedWarriorEmblem = true;
                    break;

                case ItemID.MonkBelt:
                    player.maxMinions += 1;
                    player.meleeSpeed += .04f;
                    player.maxRunSpeed += 0.27f;
                    player.moveSpeed += .05f;
                    player.GetDamage(DamageClass.Melee) += .04f;
                    player.GetDamage(DamageClass.Summon) += .05f;
                    player.GetCritChance(DamageClass.Melee) += 4;
                    break;

                case ItemID.ApprenticeScarf:
                    player.maxMinions += 1;
                    player.manaCost *= .97f;
                    player.maxRunSpeed += 0.27f;
                    player.moveSpeed += .04f;
                    player.GetDamage(DamageClass.Magic) += .04f;
                    player.GetDamage(DamageClass.Summon) += .05f;
                    player.GetCritChance(DamageClass.Magic) += 4;
                    break;

                case ItemID.SquireShield:
                    player.maxMinions += 1;
                    player.maxRunSpeed += 0.27f;
                    player.moveSpeed += .5f;
                    player.lifeRegen += 1;
                    player.GetDamage(DamageClass.Melee) += .02f;
                    player.GetDamage(DamageClass.Summon) += .05f;
                    player.GetCritChance(DamageClass.Melee) += 4;
                    break;

                case ItemID.HuntressBuckler:
                    player.maxMinions += 1;
                    player.maxRunSpeed += 0.27f;
                    player.moveSpeed += .04f;
                    equippedBuckler = true;
                    player.GetDamage(DamageClass.Ranged) += .04f;
                    player.GetDamage(DamageClass.Summon) += .05f;
                    player.GetCritChance(DamageClass.Ranged) += 4;
                    break;

                case ItemID.MechanicalGlove:
                    player.maxRunSpeed += 0.47f;
                    player.moveSpeed += 0.17f;
                    player.GetCritChance(DamageClass.Melee) += 12;
                    break;

                case ItemID.FireGauntlet:
                    player.maxRunSpeed += 0.54f;
                    player.moveSpeed += 0.20f;
                    player.GetDamage(DamageClass.Melee) += .03f;
                    player.GetCritChance(DamageClass.Melee) += 16;
                    player.meleeSpeed += 0.04f;
                    equippedWarriorEmblem = true;
                    break;

                case ItemID.PygmyNecklace:
                    equippedPygmyNecklace = true;
                    break;

                case ItemID.Shackle:
                    equippedShackle = true;
                    break;

                case ItemID.YoyoBag:
                    equippedYoyoBag = true;
                    break;
            }
        }
    }
}