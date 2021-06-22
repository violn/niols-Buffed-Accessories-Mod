using niolsBuffedAccessories;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class AccessoryProperties : GlobalItem
{
    public static bool equippedBee = false;
    public static bool equippedStar = false;
    public static bool equippedHive = false;
    public static bool equippedPlagueHive = false;
    public static bool equippedRangerEmblem = false;
    public static bool equippedSniperScope = false;
    public static bool equippedRifleScope = false;
    public static bool equippedSorcerorEmblem = false;
    public static bool equippedCelestialEmblem = false;
    public static bool equippedMechGlove = false;
    public static bool equippedWarriorEmblem = false;
    public static bool equippedOOABuckler = false;
    public static bool equippedYoyoBag = false;
    public static bool equippedShackle = false;
    public static bool equippedMagicCuffs = false;
    public static bool equippedCelestialCuffs = false;
    public static bool equippedCrossNecklace = false;
    public static bool equippedPygmyNecklace = false;
    public static bool equippedSufferWithMe = false;

    public override void UpdateAccessory(Item item, Player player, bool hideVisual)
    {
        switch (item.type)
        {
            case ItemID.BandofRegeneration:
                player.lifeRegen += 1;
                break;

            case ItemID.CharmofMyths:
                player.lifeRegen += 3;
                break;

            case ItemID.SorcererEmblem:
                player.statManaMax2 += 50;
                player.manaCost *= .85f;
                break;

            case ItemID.CelestialEmblem:
                player.manaRegenBonus += MageEmblem.celestialRegen;
                player.manaRegenDelayBonus += 5;
                player.statManaMax2 += 100;
                player.manaCost *= .82f;
                break;

            case ItemID.MagicCuffs:
                player.manaRegenBonus += 33;
                player.manaRegenDelayBonus += 1;
                break;

            case ItemID.CelestialCuffs:
                player.manaRegenBonus += 38;
                player.manaRegenDelayBonus += 2;
                break;

            case ItemID.SummonerEmblem:
                player.maxMinions += 2;
                player.maxTurrets += 2;
                break;

            case ItemID.WarriorEmblem:
                player.maxRunSpeed += 0.27f;
                player.moveSpeed += .10f;
                player.meleeCrit += 8;
                break;

            case ItemID.MonkBelt:

                player.maxMinions += 1;
                player.meleeDamage += .04f;
                player.meleeSpeed += .04f;
                player.minionDamage += .05f;
                player.meleeCrit += 4;
                player.maxRunSpeed += 0.27f;
                player.moveSpeed += .05f;
                break;

            case ItemID.ApprenticeScarf:
                player.maxMinions += 1;
                player.magicDamage += .04f;
                player.manaCost *= .97f;
                player.minionDamage += .05f;
                player.magicCrit += 4;
                player.maxRunSpeed += 0.27f;
                player.moveSpeed += .04f;
                break;

            case ItemID.SquireShield:
                player.maxMinions += 1;
                player.meleeDamage += .02f;
                player.minionDamage += .05f;
                player.meleeCrit += 4;
                player.maxRunSpeed += 0.27f;
                player.moveSpeed += .5f;
                player.lifeRegen += 1;
                break;

            case ItemID.HuntressBuckler:
                player.maxMinions += 1;
                player.rangedDamage += .04f;
                player.minionDamage += .5f;
                player.rangedCrit += 4;
                player.maxRunSpeed += 0.27f;
                player.moveSpeed += .04f;
                equippedOOABuckler = true;
                break;

            case ItemID.MechanicalGlove:
                player.maxRunSpeed += 0.47f;
                player.moveSpeed += 0.17f;
                player.meleeCrit += 12;
                break;

            case ItemID.FireGauntlet:
                player.maxRunSpeed += 0.54f;
                player.moveSpeed += 0.20f;
                player.meleeCrit += 16;
                player.meleeDamage += BuffedAccessories.calamity != null ? 0f : 0.03f;
                player.meleeSpeed += BuffedAccessories.calamity != null ? 0f : 0.04f;
                break;
        }

        if (AssignItems.buffedItems.ContainsKey(item.type))
        {
            string identifiers = AssignItems.buffedItems[item.type];

            if (identifiers.Contains("bee"))
            {
                equippedBee = true;
            }

            if (identifiers.Contains("hive"))
            {
                equippedHive = true;
            }

            if (identifiers.Contains("star"))
            {
                equippedStar = true;
            }

            if (identifiers.Contains("hive"))
            {
                equippedHive = true;
            }

            if (identifiers.Contains("rangeremblem"))
            {
                equippedRangerEmblem = true;
            }

            if (identifiers.Contains("yoyobag"))
            {
                equippedYoyoBag = true;
            }

            if (identifiers.Contains("shackle"))
            {
                equippedShackle = true;
            }

            if (identifiers.Contains("sniperscope"))
            {
                equippedSniperScope = true;
            }

            if (identifiers.Contains("crossnecklace"))
            {
                equippedCrossNecklace = true;
            }

            if (identifiers.Contains("pygmynecklace"))
            {
                equippedPygmyNecklace = true;
            }

            if (identifiers.Contains("riflescope"))
            {
                equippedRifleScope = true;
            }

            if (identifiers.Contains("sorcereremblem"))
            {
                equippedSorcerorEmblem = true;
            }

            if (identifiers.Contains("celestialemblem"))
            {
                equippedCelestialEmblem = true;
            }

            if (identifiers.Contains("magiccuffs"))
            {
                equippedMagicCuffs = true;
            }

            if (identifiers.Contains("celestialcuffs"))
            {
                equippedCelestialCuffs = true;
            }

            if (identifiers.Contains("mechglove"))
            {
                equippedMechGlove = true;
            }

            if (identifiers.Contains("warrioremblem"))
            {
                equippedWarriorEmblem = true;
            }
        }

        if (BuffedAccessories.calamity != null && item.type == BuffedAccessories.calamity.ItemType("PlagueHive"))
        {
            equippedPlagueHive = true;
        }

        if (BuffedAccessories.elementsAwokened != null)
        {
            if (item.type == BuffedAccessories.elementsAwokened.ItemType("SufferWithMe"))
            {
                equippedSufferWithMe = true;
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("NebulaEmblem"))
            {
                player.statManaMax2 += 120;
                player.manaCost *= .80f;
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("StardustEmblem"))
            {
                player.maxMinions += 3;
                player.maxTurrets += 3;
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("SolarEmblem"))
            {
                player.maxRunSpeed += 0.27f;
                player.moveSpeed += .12f;
                player.meleeCrit += 10;
            }
        }
    }
}
