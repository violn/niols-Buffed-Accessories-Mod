using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class AccessoryTooltips : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            //Most code similar to this is changing the tooltip of the accessory to match their new properties
            if (BuffedAccessories.beeItems.Contains(item.type))
            {
                foreach (var line1 in tooltips.Where(line1 => line1.mod == "Terraria" && line1.Name == "Tooltip0"))
                {
                    line1.text += "\nAttacks have a chance to spawn bees";
                }
            }

            if (BuffedAccessories.starItems.Contains(item.type))
            {
                foreach (var line2 in tooltips.Where(line2 => line2.mod == "Terraria" && line2.Name == "Tooltip0"))
                {
                    line2.text += "\nAttacks have a chance to spawn stars from the sky";
                }
            }

            if (item.type == ItemID.RangerEmblem)
            {
                foreach (var line3 in tooltips.Where(line3 => line3.mod == "Terraria" && line3.Name == "Tooltip0"))
                {
                    line3.text += "\n10% chance not to consume ammo\nRanged attacks have a chance to duplicate their projectiles";
                }
            }

            if (item.type == ItemID.RifleScope)
            {
                foreach (var line4 in tooltips.Where(line4 => line4.mod == "Terraria" && line4.Name == "Tooltip0"))
                {
                    line4.text += "\nIncreased ranged damage depending on how far away your target is\n5% increased ranged critical strike chance";
                }
            }

            if (item.type == ItemID.SniperScope)
            {
                foreach (var line5 in tooltips.Where(line5 => line5.mod == "Terraria" && line5.Name == "Tooltip0"))
                {
                    line5.text += "\nRanged attacks have a chance to duplicate their projectiles\nIncreased ranged damage depending on how far away your target is" +
                    "\n15% not to consume ammo";
                }
            }

            if (item.type == ItemID.SorcererEmblem)
            {
                double currentStacks;
                if (OnHitProj.currentOnHitBoost < OnHitProj.depleteBoost)
                {
                    currentStacks = 0;
                }
                else currentStacks = Math.Round((OnHitProj.currentOnHitBoost - OnHitProj.depleteBoost) * 100, 0, MidpointRounding.AwayFromZero);
                foreach (var line6 in tooltips.Where(line6 => line6.mod == "Terraria" && line6.Name == "Tooltip0"))
                {
                    line6.text += "\n+50 mana\n15% reduced mana usage" +
                        "\nConstantly damaging enemies creates stacks that boosts magic damage\nCurrent Stacks: " + currentStacks;
                }
            }

            if (item.type == ItemID.CelestialEmblem)
            {
                double currentStacks;
                if (OnHitProj.currentOnHitBoost < OnHitProj.depleteBoost)
                {
                    currentStacks = 0;
                }
                else currentStacks = Math.Round((OnHitProj.currentOnHitBoost - OnHitProj.depleteBoost) * 100, 0, MidpointRounding.AwayFromZero);
                foreach (var line7 in tooltips.Where(line7 => line7.mod == "Terraria" && line7.Name == "Tooltip0"))
                {
                    line7.text += "\nConstantly damaging enemies creates stacks that boosts magic damage\nCurrent Stacks: " + currentStacks +
                    "\n+100 mana\n17% reduced mana usage";
                }
            }

            if (item.type == ItemID.MagicCuffs)
            {
                foreach (var line8 in tooltips.Where(line8 => line8.mod == "Terraria" && line8.Name == "Tooltip0"))
                {
                    line8.text += "\nIncreased mana regeneration\n+3 magic damage";
                }
            }

            if (item.type == ItemID.CelestialCuffs)
            {
                foreach (var line9 in tooltips.Where(line9 => line9.mod == "Terraria" && line9.Name == "Tooltip0"))
                {
                    line9.text += "\nIncreased mana regeneration\n+5 magic damage";
                }
            }

            if(item.type == ItemID.Shackle)
            {
                foreach (var line0 in tooltips.Where(line0 => line0.mod == "Terraria" && line0.Name == "Tooltip0"))
                {
                    line0.text += "\n+1 damage";
                }
            }

            if (item.type == ItemID.SummonerEmblem)
            {
                foreach (var line10 in tooltips.Where(line10 => line10.mod == "Terraria" && line10.Name == "Tooltip0"))
                {
                    line10.text += "\n+2 max minions\n+2 max sentries";
                }
            }

            if (item.type == ItemID.WarriorEmblem)
            {
                foreach (var line11 in tooltips.Where(line11 => line11.mod == "Terraria" && line11.Name == "Tooltip0"))
                {
                    line11.text += "\n8% increased critical strike chance\n10% increased movement speed\nKilling an enemy enhances your melee abilities";
                }
            }

            if (item.type == ItemID.MonkBelt)
            {
                foreach (var line13 in tooltips)
                {
                    if (line13.Name == "Tooltip0")
                    {
                        line13.text = "Increase your max number of sentries and minions by 1";
                    }

                    if (line13.Name == "Tooltip1")
                    {
                        line13.text = "Increases minion damage by 20%\n7% increased melee speed and damage" +
                        "\n7% increased melee critical strike chance\n10% increased movement speed";
                    }
                }
            }

            if (item.type == ItemID.SquireShield)
            {
                foreach (var line13 in tooltips)
                {
                    if (line13.Name == "Tooltip0")
                    {
                        line13.text = "Increase your max number of sentries and minions by 1";
                    }

                    if (line13.Name == "Tooltip1")
                    {
                        line13.text = "Increases minion damage by 20%\n3% increased melee damage" +
                        "\n8% increased melee critical strike chance\n10% increased movement speed\nIncreased health regeneration";
                    }
                }
            }

            if (item.type == ItemID.ApprenticeScarf)
            {
                foreach (var line13 in tooltips)
                {
                    if (line13.Name == "Tooltip0")
                    {
                        line13.text = "Increase your max number of sentries and minions by 1";
                    }

                    if (line13.Name == "Tooltip1")
                    {
                        line13.text = "Increases minion damage by 20%\n8% increased magic damage and critical strike chance" +
                        "\n5% reduce mana usage\n7% increased movement speed";
                    }
                }
            }

            if (item.type == ItemID.HuntressBuckler)
            {
                foreach (var line13 in tooltips)
                {
                    if (line13.Name == "Tooltip0")
                    {
                        line13.text = "Increase your max number of sentries and minions by 1";
                    }

                    if (line13.Name == "Tooltip1")
                    {
                        line13.text = "Increases minion damage by 20%\n8% increased ranged damage" +
                        "\n7% ranged critical strike chance\n7% increased movement speed\n3% chance to not consume ammo";
                    }
                }
            }

            if (item.type == ItemID.MechanicalGlove)
            {
                foreach (TooltipLine line12 in tooltips)
                {
                    if (BuffedAccessories.calamity != null && line12.Name == "Tooltip1")
                    {
                        line12.text += "\n12% increased melee critical strike chance\n17% increased movement speed\nEnable autoswing for all melee weapons" +
                            "\nKilling an enemy enhances your melee abilities";
                    }
                    else if (BuffedAccessories.calamity == null && line12.Name == "Tooltip1")
                    {
                        line12.text = "12% increased melee damage, speed, and critical strike chance\n17% increased movement speed\nEnable autoswing for all melee weapons" +
                            "\nKilling an enemy enhances your melee abilities";
                    }
                }
            }

            if (item.type == ItemID.FireGauntlet)
            {
                foreach (TooltipLine line12 in tooltips)
                {
                    if (BuffedAccessories.calamity != null && line12.Name == "Tooltip1")
                    {
                        line12.text += "\n16% increased melee critical strike chance\n20% increased movement speed" +
                            "\nEnable autoswing for melee weapons\nKilling an enemy enhances your melee abilities";
                    }
                    else if (BuffedAccessories.calamity == null && line12.Name == "Tooltip1")
                    {
                        line12.text = "16% increased melee damage, speed, and critical strike chance\n20% increased movement speed" +
                            "\nEnables auto swing for melee weapons\nKilling an enemy enhances your melee abilities";
                    }
                }
            }

            if (item.type == ItemID.ShinyStone)
            {
                foreach (var line11 in tooltips.Where(line11 => line11.mod == "Terraria" && line11.Name == "Tooltip0"))
                {
                    line11.text = "Greatly increases life regen and increases defense when not moving";
                }
            }

            if (item.type == ItemID.CrossNecklace)
            {
                foreach (var line11 in tooltips.Where(line11 => line11.mod == "Terraria" && line11.Name == "Tooltip0"))
                {
                    line11.text += "\nGives a chance to prevent death";
                }
            }

            if (item.type == ItemID.PygmyNecklace)
            {
                foreach (var line11 in tooltips.Where(line11 => line11.mod == "Terraria" && line11.Name == "Tooltip0"))
                {
                    line11.text += "\nPrevents iframe creation of minions";
                }
            }

            //All code after this handles other modded item's tooltips
            if (BuffedAccessories.upgradedAccessories != null)
            {
                if (item.type == BuffedAccessories.upgradedAccessories.ItemType("Vengeance"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nAttacks have a chance to spawn bees and stars";
                        }
                        else if (line1.Name.Contains("Expert"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 2].text += "\nAttacks have a chance to spawn bees and stars";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nAttacks have a chance to spawn bees and stars";
                    }
                }

                if (item.type == BuffedAccessories.upgradedAccessories.ItemType("SolarFlareGlove"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nEnable autoswing for melee weapons\nKilling an enemy enhances your melee abilities";
                        }
                        else if (line1.Name.Contains("Expert"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 2].text += "\nEnable autoswing for all melee weapons\nKilling an enemy enhances your melee abilities";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nEnable autoswing for all melee weapons\nKilling an enemy enhances your melee abilities";
                    }
                }

                if (item.type == BuffedAccessories.upgradedAccessories.ItemType("VortexScope"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nRanged attacks have a chance to duplicate projectiles" +
                        "\nIncreased ranged damage depending on how far away your target is\n15% not to consume ammo";
                        }
                        else if (line1.Name.Contains("Expert"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 2].text += "\nRanged attacks have a chance to duplicate projectiles" +
                        "\nIncreased ranged damage depending on how far away your target is\n15% not to consume ammo";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nRanged attacks have a chance to duplicate projectiles" +
                        "\nIncreased ranged damage depending on how far away your target is\n15% not to consume ammo";
                    }
                }

                if (item.type == BuffedAccessories.upgradedAccessories.ItemType("NebulaFlower"))
                {
                    double currentStacks;
                    if (OnHitProj.currentOnHitBoost < OnHitProj.depleteBoost)
                    {
                        currentStacks = 0;
                    }
                    else currentStacks = Math.Round((OnHitProj.currentOnHitBoost - OnHitProj.depleteBoost) * 100, 0, MidpointRounding.AwayFromZero);

                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "Constantly damaging enemies creates stacks that boosts magic damage and mana regeneration" +
                        "\nCurrent Stacks: " + currentStacks;
                        }
                        else if (line1.Name.Contains("Expert"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 2].text += "Constantly damaging enemies creates stacks that boosts magic damage and mana regeneration" +
                        "\nCurrent Stacks: " + currentStacks;
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "Constantly damaging enemies creates stacks that boosts magic damage and mana regeneration" +
                        "\nCurrent Stacks: " + currentStacks;
                    }
                }
            }

            if (BuffedAccessories.thorium != null)
            {
                if (item.type == BuffedAccessories.thorium.ItemType("SweetVengeance"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nAttacks have a chance to spawn bees and stars";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nAttacks have a chance to spawn bees and stars";
                    }
                }
            }

            if (BuffedAccessories.calamity != null)
            {
                if (item.type == BuffedAccessories.calamity.ItemType("PlagueHive"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nAttacks have a chance to spawn plague bees and bees";
                        }
                        else if (line1.Name.Contains("Expert"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 2].text += "\nAttacks have a chance to spawn plague bees and bees";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nAttacks have a chance to spawn plague bees and bees";
                    }
                }

                if (item.type == BuffedAccessories.calamity.ItemType("DeificAmulet"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nAttacks have a chance spawn stars from the sky";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nAttacks have a chance spawn stars from the sky";
                    }
                }

                if (item.type == BuffedAccessories.calamity.ItemType("RampartofDeities"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nAttacks have a chance spawn stars from the sky";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nAttacks have a chance spawn stars from the sky";
                    }
                }

                if (item.type == BuffedAccessories.calamity.ItemType("ElementalGauntlet"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nEnable autoswing for melee weapons\nKilling an enemy enhances your melee abilities";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nEnable autoswing for melee weapons\nKilling an enemy enhances your melee abilities";
                    }
                }

                if (item.type == BuffedAccessories.calamity.ItemType("YharimsInsignia"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nEnable autoswing for melee weapons\nKilling an enemy enhances your melee abilities";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nEnable autoswing for melee weapons\nKilling an enemy enhances your melee abilities";
                    }
                }

                if (item.type == BuffedAccessories.calamity.ItemType("DaedalusEmblem"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\n10% not to consume ammo\nRanged attacks have a chance to duplicate projectiles";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\n10% not to consume ammo\nRanged attacks have a chance to duplicate projectiles";
                    }
                }

                if (item.type == BuffedAccessories.calamity.ItemType("ElementalQuiver"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\n10% not to consume ammo\nRanged attacks have a chance to duplicate projectiles";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\n10% not to consume ammo\nRanged attacks have a chance to duplicate projectiles";
                    }
                }

                if (item.type == BuffedAccessories.calamity.ItemType("SigilofCalamitas"))
                {
                    double currentStacks;
                    if (OnHitProj.currentOnHitBoost < OnHitProj.depleteBoost)
                    {
                        currentStacks = 0;
                    }
                    else currentStacks = Math.Round((OnHitProj.currentOnHitBoost - OnHitProj.depleteBoost) * 100, 0, MidpointRounding.AwayFromZero);

                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nConstantly damaging enemies creates stacks that boosts magic damage and mana regeneration" +
                        "\nCurrent Stacks: " + currentStacks;
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nConstantly damaging enemies creates stacks that boosts magic damage and mana regeneration" +
                        "\nCurrent Stacks: " + currentStacks;
                    }
                }

                if (item.type == BuffedAccessories.calamity.ItemType("EtherealTalisman"))
                {
                    double currentStacks;
                    if (OnHitProj.currentOnHitBoost < OnHitProj.depleteBoost)
                    {
                        currentStacks = 0;
                    }
                    else currentStacks = Math.Round((OnHitProj.currentOnHitBoost - OnHitProj.depleteBoost) * 100, 0, MidpointRounding.AwayFromZero);

                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nConstantly damaging enemies creates stacks that boosts magic damage and mana regeneration" +
                        "\nCurrent Stacks: " + currentStacks;
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nConstantly damaging enemies creates stacks that boosts magic damage and mana regeneration" +
                        "\nCurrent Stacks: " + currentStacks;
                    }
                }
            }

            if (BuffedAccessories.elementsAwokened != null)
            {
                if (item.type == BuffedAccessories.elementsAwokened.ItemType("FrozenGauntlet"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nAttacks have a chance spawn stars from the sky\nEnable autoswing for all melee weapons\nKilling an enemy enhances your melee abilities";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nAttacks have a chance spawn stars from the sky\nEnable autoswing for all melee weapons\nKilling an enemy enhances your melee abilities";
                    }
                }

                if (item.type == BuffedAccessories.elementsAwokened.ItemType("SolarEmblem"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\n8% increased critical strike chance\n10% increased movement speed\nKilling an enemy enhances your melee abilities";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\n8% increased critical strike chance\n10% increased movement speed\nKilling an enemy enhances your melee abilities";
                    }
                }

                if (item.type == BuffedAccessories.elementsAwokened.ItemType("StardustEmblem"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\n+3 max minions\n+3 max sentries";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\n+3 max minions\n+3 max sentries";
                    }
                }

                if (item.type == BuffedAccessories.elementsAwokened.ItemType("VortexEmblem"))
                {
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\n10% not to consume ammo\nRanged attacks have a chance to duplicate projectiles";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\n10% not to consume ammo\nRanged attacks have a chance to duplicate projectiles";
                    }
                }

                if (item.type == BuffedAccessories.elementsAwokened.ItemType("NebulaEmblem"))
                {
                    double currentStacks;
                    if (OnHitProj.currentOnHitBoost < OnHitProj.depleteBoost)
                    {
                        currentStacks = 0;
                    }
                    else currentStacks = Math.Round((OnHitProj.currentOnHitBoost - OnHitProj.depleteBoost) * 100, 0, MidpointRounding.AwayFromZero);
                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "\nConstantly damaging enemies creates stacks that boosts magic damage\nCurrent Stacks: " + currentStacks +
                        "\n+100 mana\n17% reduced mana usage";
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "\nConstantly damaging enemies creates stacks that boosts magic damage\nCurrent Stacks: " + currentStacks +
                        "\n+100 mana\n17% reduced mana usage";
                    }
                }

                if (item.type == BuffedAccessories.elementsAwokened.ItemType("EtherealShell"))
                {
                    double currentStacks;
                    if (OnHitProj.currentOnHitBoost < OnHitProj.depleteBoost)
                    {
                        currentStacks = 0;
                    }
                    else currentStacks = Math.Round((OnHitProj.currentOnHitBoost - OnHitProj.depleteBoost) * 100, 0, MidpointRounding.AwayFromZero);

                    foreach (var line1 in tooltips.Where(line1 => tooltips.IndexOf(line1) == tooltips.Count - 1))
                    {
                        if (line1.Name.Contains("Prefix"))
                        {
                            tooltips[tooltips.IndexOf(line1) - 1].text += "Constantly damaging enemies creates stacks that boosts magic damage and mana regeneration" +
                        "\nCurrent Stacks: " + currentStacks;
                        }
                        else tooltips[tooltips.IndexOf(line1)].text += "Constantly damaging enemies creates stacks that boosts magic damage and mana regeneration" +
                        "\nCurrent Stacks: " + currentStacks;
                    }
                }
            }
        }
    }
}
