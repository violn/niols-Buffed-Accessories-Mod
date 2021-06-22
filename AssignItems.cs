using niolsBuffedAccessories;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class AssignItems : GlobalItem
{
    public static Dictionary<int, string> buffedItems = new Dictionary<int, string>()
    {
        { ItemID.BeeCloak, "bee, star" },
        { ItemID.StarCloak, "star" },
        { ItemID.HoneyComb, "bee" },
        { ItemID.HoneyBalloon, "bee"},
        { ItemID.BalloonHorseshoeHoney, "bee"},
        { ItemID.SweetheartNecklace, "bee"},
        { ItemID.StarVeil, "star, crossnecklace"},
        { ItemID.CrossNecklace, "crossnecklace"},
        { ItemID.HiveBackpack, "hive"},
        { ItemID.RangerEmblem, "rangeremblem"},
        { ItemID.SniperScope, "sniperscope, riflescope"},
        { ItemID.YoyoBag, "yoyobag"},
        { ItemID.Shackle, "shackle"},
        { ItemID.PygmyNecklace, "pygmynecklace"},
        { ItemID.RifleScope, "riflescope"},
        { ItemID.SorcererEmblem, "sorcereremblem"},
        { ItemID.CelestialEmblem, "celestialemblem"},
        { ItemID.MagicCuffs, "magiccuffs"},
        { ItemID.CelestialCuffs, "celestialcuffs"},
        { ItemID.MechanicalGlove, "mechglove, warrioremblem"},
        { ItemID.FireGauntlet, "mechglove, warrioremblem"},
        { ItemID.WarriorEmblem, "warrioremblem"}
    };

    public override void SetDefaults(Item item)
    {
        if (buffedItems.Count == 20)
        {
            if (BuffedAccessories.upgradedAccessories != null)
            {
                buffedItems.Add(BuffedAccessories.upgradedAccessories.ItemType("Vengeance"), "bee, star, hive, magiccuffs, crossnecklace");
                buffedItems.Add(BuffedAccessories.upgradedAccessories.ItemType("SharktoothCuffs"), "magiccuffs");
                buffedItems.Add(BuffedAccessories.upgradedAccessories.ItemType("VortexScope"), "sniperscope, riflescope, rangeremblem");
                buffedItems.Add(BuffedAccessories.upgradedAccessories.ItemType("SolarFlareGlove"), "warrioremblem, yoyobag");
                buffedItems.Add(BuffedAccessories.upgradedAccessories.ItemType("NebulaFlower"), "celestialemblem");
            }

            if (BuffedAccessories.thorium != null)
            {
                buffedItems.Add(BuffedAccessories.thorium.ItemType("SweetVengeance"), "bee, star, crossnecklace");
                buffedItems.Add(BuffedAccessories.thorium.ItemType("SacredHeart"), "crossnecklace");
                buffedItems.Add(BuffedAccessories.thorium.ItemType("SpikedBracer"), "shackle");
            }

            if (BuffedAccessories.calamity != null)
            {
                buffedItems.Add(BuffedAccessories.calamity.ItemType("DeificAmulet"), "star, crossnecklace");
                buffedItems.Add(BuffedAccessories.calamity.ItemType("ArtemisEmblem"), "rangeremblem");
                buffedItems.Add(BuffedAccessories.calamity.ItemType("ElementalQuiver"), "rangeremblem");
                buffedItems.Add(BuffedAccessories.calamity.ItemType("YharimsInsignia"), "warrioremblem, crossnecklace");
                buffedItems.Add(BuffedAccessories.calamity.ItemType("ElementalGauntlet"), "mechglove, warrioremblem, crossnecklace");
                buffedItems.Add(BuffedAccessories.calamity.ItemType("EtherealTalisman"), "celestialcuffs, sorcereremblem");
                buffedItems.Add(BuffedAccessories.calamity.ItemType("SigilofCalamitas"), "elestialcuffs, sorcereremblem");
                buffedItems.Add(BuffedAccessories.calamity.ItemType("PlagueHive"), "hive");
            }

            if (BuffedAccessories.elementsAwokened != null)
            {
                buffedItems.Add(BuffedAccessories.elementsAwokened.ItemType("FrozenGauntlet"), "star, mechglove, warrioremblem, crossnecklace");
                buffedItems.Add(BuffedAccessories.elementsAwokened.ItemType("ElementalArcanum"), "star, mechglove, warrioremblem, crossnecklace, celestialcuffs, sorcereremblem");
                buffedItems.Add(BuffedAccessories.elementsAwokened.ItemType("VortexEmblem"), "rangeremblem");
                buffedItems.Add(BuffedAccessories.elementsAwokened.ItemType("NebulaEmblem"), "sorcereremblem");
                buffedItems.Add(BuffedAccessories.elementsAwokened.ItemType("SolarEmblem"), "warrioremblem");
                buffedItems.Add(BuffedAccessories.elementsAwokened.ItemType("SharktoothShackle"), "shackle");
                buffedItems.Add(BuffedAccessories.elementsAwokened.ItemType("EtherealShell"), "sorcereremblem, celestialcuffs");
            }
        }
    }
}