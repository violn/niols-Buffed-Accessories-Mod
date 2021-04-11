using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using niolsBuffedAccessories;

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
    public static bool equippedFireGauntlet = false;
    public static bool equippedWarriorEmblem = false;
    public static bool equippedOOABuckler = false;
    public static bool equippedYoyoBag = false;
    public static bool equippedRegenerationBand = false;
    public static bool equippedShackle = false;
    public static bool equippedMCuffs = false;
    public static bool equippedCCuffs = false;
    public static bool EquippedCrossNecklace = false;
    public static bool equippedPygmyNecklace = false;
    public static bool equippedMagicQuiver = false;

    public override void UpdateAccessory(Item item, Player player, bool hideVisual)
    {
        //Every piece of code similar to this is modifying what accessories do
        if (BuffedAccessories.beeItems.Contains(item.type))
        {
            equippedBee = true;
        }

        if (BuffedAccessories.starItems.Contains(item.type))
        {
            equippedStar = true;
        }

        if (BuffedAccessories.hiveItems.Contains(item.type))
        {
            equippedHive = true;
        }

        if (item.type == ItemID.RangerEmblem)
        {
            equippedRangerEmblem = true;
        }

        if (item.type == ItemID.RifleScope)
        {
            player.rangedCrit += 5;
            equippedRifleScope = true;
        }

        if (item.type == ItemID.SniperScope)
        {
            equippedSniperScope = true;
        }

        if (item.type == ItemID.SorcererEmblem)
        {
            player.statManaMax2 += 50;
            player.manaCost *= .75f;
            equippedSorcerorEmblem = true;
        }

        if (item.type == ItemID.CelestialEmblem)
        {
            player.manaRegenBonus += OnHitProj.celestialRegen;
            player.manaRegenDelayBonus += 5;
            player.statManaMax2 += 100;
            player.manaCost *= .72f;
            equippedCelestialEmblem = true;
        }

        if (item.type == ItemID.Shackle)
        {
            equippedShackle = true;
        }

        if (item.type == ItemID.MagicCuffs)
        {
            player.manaRegenBonus += 33;
            player.manaRegenDelayBonus += 1;
            equippedMCuffs = true;
        }

        if (item.type == ItemID.CelestialCuffs)
        {
            player.manaRegenBonus += 38;
            player.manaRegenDelayBonus += 2;
            equippedCCuffs = true;
        }

        if (item.type == ItemID.SummonerEmblem)
        {
            player.maxMinions += 2;
            player.maxTurrets += 2;
        }

        if (item.type == ItemID.WarriorEmblem)
        {
            player.maxRunSpeed += 0.27f;
            player.moveSpeed += .10f;
            player.meleeCrit += 8;
            equippedWarriorEmblem = true;
        }

        if (item.type == ItemID.BandofRegeneration)
        {
            player.lifeRegen += 1;
        }

        if (item.type == ItemID.CharmofMyths)
        {
            player.lifeRegen += 3;
        }

        if (item.type == ItemID.YoyoBag)
        {
            equippedYoyoBag = true;
        }

        if (item.type == ItemID.MonkBelt)
        {
            player.maxMinions += 1;
            player.meleeDamage += .07f;
            player.meleeSpeed += .07f;
            player.minionDamage += .10f;
            player.meleeCrit += 8;
            player.maxRunSpeed += 0.27f;
            player.moveSpeed += .10f;
        }

        if (item.type == ItemID.ApprenticeScarf)
        {
            player.maxMinions += 1;
            player.magicDamage += .08f;
            player.manaCost *= .95f;
            player.minionDamage += .10f;
            player.magicCrit += 8;
            player.maxRunSpeed += 0.27f;
            player.moveSpeed += .07f;
        }

        if (item.type == ItemID.SquireShield)
        {
            player.maxMinions += 1;
            player.meleeDamage += .03f;
            player.minionDamage += .10f;
            player.meleeCrit += 7;
            player.maxRunSpeed += 0.27f;
            player.moveSpeed += .10f;
            player.lifeRegen += 1;
        }

        if (item.type == ItemID.HuntressBuckler)
        {
            player.maxMinions += 1;
            player.rangedDamage += .08f;
            player.minionDamage += .10f;
            player.rangedCrit += 7;
            player.maxRunSpeed += 0.27f;
            player.moveSpeed += .07f;
            equippedOOABuckler = true;
        }

        if (item.type == ItemID.CrossNecklace)
        {
            EquippedCrossNecklace = true;
        }

        if (item.type == ItemID.PygmyNecklace)
        {
            equippedPygmyNecklace = true;
        }

        if (item.type == ItemID.MagicQuiver)
        {
            equippedMagicQuiver = true;
        }

        //Every piece of code here handles other modded items
        if (BuffedAccessories.upgradedAccessories != null)
        {
            if (item.type == BuffedAccessories.upgradedAccessories.ItemType("Vengeance"))
            {
                equippedBee = true;
                equippedStar = true;
            }

            if (item.type == BuffedAccessories.upgradedAccessories.ItemType("SolarFlareGlove"))
            {
                equippedFireGauntlet = true;
            }

            if (item.type == BuffedAccessories.upgradedAccessories.ItemType("VortexScope"))
            {
                equippedSniperScope = true;
            }

            if (item.type == BuffedAccessories.upgradedAccessories.ItemType("NebulaFlower"))
            {
                equippedCelestialEmblem = true;
            }
        }

        if (BuffedAccessories.thorium != null)
        {
            if (item.type == BuffedAccessories.thorium.ItemType("SweetVengeance"))
            {
                equippedStar = true;
                equippedBee = true;
            }
        }

        if (BuffedAccessories.calamity != null)
        {
            if (item.type == BuffedAccessories.calamity.ItemType("PlagueHive"))
            {
                equippedHive = true;
                equippedBee = true;
                equippedPlagueHive = true;
            }

            if (item.type == BuffedAccessories.calamity.ItemType("DeificAmulet"))
            {
                equippedStar = true;
            }

            if (item.type == BuffedAccessories.calamity.ItemType("RampartofDeities"))
            {
                equippedStar = true;
            }

            if (item.type == BuffedAccessories.calamity.ItemType("ElementalGauntlet"))
            {
                equippedFireGauntlet = true;
            }

            if (item.type == BuffedAccessories.calamity.ItemType("YharimsInsignia"))
            {
                equippedFireGauntlet = true;
            }

            if (item.type == BuffedAccessories.calamity.ItemType("DaedalusEmblem"))
            {
                equippedRangerEmblem = true;
            }

            if (item.type == BuffedAccessories.calamity.ItemType("ElementalQuiver"))
            {
                equippedRangerEmblem = true;
            }

            if (item.type == BuffedAccessories.calamity.ItemType("SigilofCalamitas"))
            {
                equippedCelestialEmblem = true;
            }

            if (item.type == BuffedAccessories.calamity.ItemType("EtherealTalisman"))
            {
                equippedCelestialEmblem = true;
            }

            if (item.type == ItemID.MechanicalGlove)
            {
                player.maxRunSpeed += 0.47f;
                player.moveSpeed += 0.17f;
                player.meleeCrit += 12;
                equippedMechGlove = true;
            }

            if (item.type == ItemID.FireGauntlet)
            {
                player.maxRunSpeed += 0.54f;
                player.moveSpeed += 0.20f;
                player.meleeCrit += 16;
                equippedFireGauntlet = true;
            }
        }
        else
        {
            if (item.type == ItemID.MechanicalGlove)
            {
                player.maxRunSpeed += 0.47f;
                player.moveSpeed += 0.17f;
                player.meleeCrit += 12;
                equippedMechGlove = true;
            }

            if (item.type == ItemID.FireGauntlet)
            {
                player.maxRunSpeed += 0.54f;
                player.meleeDamage += 0.04f;
                player.meleeSpeed += 0.04f;
                player.maxRunSpeed += 0.54f;
                player.moveSpeed += 0.20f;
                player.meleeCrit += 16;
                equippedFireGauntlet = true;
            }
        }

        if (BuffedAccessories.elementsAwokened != null)
        {
            if (item.type == BuffedAccessories.elementsAwokened.ItemType("ElementalArcanum"))
            {
                equippedCelestialEmblem = true;
                equippedFireGauntlet = true;
                equippedStar = true;
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("FrozenGauntlet"))
            {
                equippedFireGauntlet = true;
                equippedStar = true;
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("SolarEmblem"))
            {
                equippedFireGauntlet = true;
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("StardustEmblem"))
            {
                player.maxMinions += 3;
                player.maxTurrets += 3;
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("VortexEmblem"))
            {
                equippedRangerEmblem = true;
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("NebulaEmblem"))
            {
                player.manaRegenBonus += OnHitProj.celestialRegen;
                player.statManaMax2 += 100;
                player.manaCost *= .72f;
                equippedCelestialEmblem = true;
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("EtherealShell"))
            {
                equippedCelestialEmblem = true;
            }
        }
    }
}
