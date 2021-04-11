//This mod was made by niol#1299 add me on discord if you have any questions.
using System.Collections;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class BuffedAccessories : Mod
    {
        public static Mod calamity = ModLoader.GetMod("CalamityMod");
        public static Mod thorium = ModLoader.GetMod("ThoriumMod");
        public static Mod elementsAwokened = ModLoader.GetMod("ElementsAwoken");
        public static Mod upgradedAccessories = ModLoader.GetMod("UpgradedAccessories");
        public static ArrayList hiveItems = new ArrayList();
        public static ArrayList starItems = new ArrayList();
        public static ArrayList beeItems = new ArrayList();
        public static ArrayList countweightBlackList = new ArrayList();

        //Creates hotkey for quick summon.
        public override void Load()
        {
            ToggleSummon.toggleQuickSummon = base.RegisterHotKey("Quick Summon", "I");
            AddItems();
        }

        //Add certain items with similar properties.
        public static void AddItems()
        {
            beeItems.Add(1249);
            beeItems.Add(1132);
            beeItems.Add(1247);
            beeItems.Add(1578);
            beeItems.Add(3251);

            starItems.Add(532);
            starItems.Add(862);
            starItems.Add(1247);

            hiveItems.Add(3333);

            countweightBlackList.Add(556);
            countweightBlackList.Add(557);
            countweightBlackList.Add(558);
            countweightBlackList.Add(559);
            countweightBlackList.Add(560);
            countweightBlackList.Add(561);
        }
    }

    //Reset variables to be rechecked.
    public class Reset : ModPlayer
    {
        public override void ResetEffects()
        {
            AccessoryProperties.equippedBee = false;
            AccessoryProperties.equippedStar = false;
            AccessoryProperties.equippedHive = false;
            AccessoryProperties.equippedPlagueHive = false;
            AccessoryProperties.equippedRangerEmblem = false;
            AccessoryProperties.equippedSniperScope = false;
            AccessoryProperties.equippedRifleScope = false;
            AccessoryProperties.equippedSorcerorEmblem = false;
            AccessoryProperties.equippedCelestialEmblem = false;
            AccessoryProperties.equippedMechGlove = false;
            AccessoryProperties.equippedFireGauntlet = false;
            AccessoryProperties.equippedWarriorEmblem = false;
            AccessoryProperties.equippedRegenerationBand = false;
            AccessoryProperties.equippedYoyoBag = false;
            AccessoryProperties.equippedOOABuckler = false;
            AccessoryProperties.equippedPygmyNecklace = false;
            AccessoryProperties.equippedMagicQuiver = false;

            if (!AccessoryProperties.equippedShackle)
            {
                IncreaseItemStats.shackleBoostCheck = false;
                if (IncreaseItemStats.moddedDamage.Count > 0)
                {
                    foreach (Item item in IncreaseItemStats.moddedDamage)
                    {
                        item.damage -= 1;
                    }
                }
                IncreaseItemStats.moddedDamage.RemoveRange(0, IncreaseItemStats.moddedDamage.Count);
            }

            AccessoryProperties.equippedShackle = false;

            if (!AccessoryProperties.equippedMCuffs)
            {
                IncreaseItemStats.shackleBoostCheck2 = false;
                if (IncreaseItemStats.moddedDamage2.Count > 0)
                {
                    foreach (Item item in IncreaseItemStats.moddedDamage2)
                    {
                        item.damage -= 3;
                    }
                }
                IncreaseItemStats.moddedDamage2.RemoveRange(0, IncreaseItemStats.moddedDamage2.Count);
            }

            AccessoryProperties.equippedMCuffs = false;

            if (!AccessoryProperties.equippedCCuffs)
            {
                IncreaseItemStats.shackleBoostCheck3 = false;
                if (IncreaseItemStats.moddedDamage3.Count > 0)
                {
                    foreach (Item item in IncreaseItemStats.moddedDamage3)
                    {
                        item.damage -= 5;
                    }
                }
                IncreaseItemStats.moddedDamage3.RemoveRange(0, IncreaseItemStats.moddedDamage3.Count);
            }

            AccessoryProperties.equippedCCuffs = false;
        }
    }
}
