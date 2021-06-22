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
            double current_stacks = Math.Round(MageEmblem.currentOnHitBoost * 100, 0, MidpointRounding.AwayFromZero);

            if (item.type == BuffedAccessories.calamity.ItemType("PlagueHive"))
            {
                tooltips[tooltips.Count - 2].text += "\nAttacks have a chance to spawn plague bees";
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("SolarEmblem"))
            {
                tooltips[tooltips.Count - 1].text += "\n12% increased movement speed\n10% increased melee critical strike chance";
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("NebulaEmblem"))
            {
                tooltips[tooltips.Count - 1].text += "\n20% reduced mana usage\n+120 maximum mana";
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("StardustEmblem"))
            {
                tooltips[tooltips.Count - 1].text += "\n+3 maximum minions and sentries";
            }

            if (item.type == BuffedAccessories.elementsAwokened.ItemType("SufferWithMe"))
            {
                tooltips[tooltips.Count - 2].text += "\n+35 damage";
            }

            if (AssignItems.buffedItems.ContainsKey(item.type))
            {
                string identifiers = AssignItems.buffedItems[item.type];

                if (identifiers.Contains("rangeremblem"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += item.type != ItemID.RangerEmblem ?
                    "\nRanged projectiles have a chance to duplicate" :
                    "\n10% chance not to consume ammo\nRanged projectiles have a chance to duplicate";
                }

                if (identifiers.Contains("warrioremblem"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += item.type != ItemID.WarriorEmblem ?
                       "\nKilling an enemy enhances your melee abilities" :
                       "\n8% increased melee critical strike chance\n10% increased movement speed\nKilling an enemy enhances your melee abilities";
                }

                if (identifiers.Contains("sniperscope"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += "\n15% chance not to consume ammo";
                }

                if (identifiers.Contains("magiccuffs"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += "\nIncreases mana regeneration\n+3 magic damage";
                }

                if (identifiers.Contains("celestialcuffs"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += "\nIncreases mana regeneration\n+5 magic damage";
                }

                if (identifiers.Contains("shackle"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += "\n+1 damage";
                }

                if (identifiers.Contains("bee"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += "\nAttacks have a chance to spawn bees";
                }

                if (identifiers.Contains("star"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += "\nAttacks have a chance to spawn stars from the sky";
                }

                if (identifiers.Contains("mechglove"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += "\nEnables autoswing for all melee weapons";
                }

                if (identifiers.Contains("riflescope"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += "\nIncreased ranged damage based on distance";
                }

                if (identifiers.Contains("pygmynecklace"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += "\nPrevents immunity frames creation of minions";
                }

                if (identifiers.Contains("crossnecklace"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += "\nGives a chance to prevent death";
                }

                if (identifiers.Contains("sorcereremblem"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += item.type != ItemID.SorcererEmblem ?
                        $"\nDealing magic damage applies a magic stack that boosts magic damage\nCurrent stacks: {current_stacks}" :
                        $"\n15% reduced mana usage\n+50 maximum mana\nDealing magic damage applies a magic stack that boosts magic damage\nCurrent stacks: {current_stacks}";
                }

                if (identifiers.Contains("celestialemblem"))
                {
                    tooltips[!item.expert ? tooltips.Count - 1 : tooltips.Count - 2].text += item.type != ItemID.CelestialEmblem ?
                        $"\nDealing magic damage applies a magic stack that boosts magic damage and mana regeneration\nCurrent stacks: {current_stacks}" :
                        $"\n\n+100 maximum mana\n17% reduced mana usage\nDealing magic damage applies a magic stack that boosts magic damage and mana regeneration\nCurrent stacks: {current_stacks}";
                }
            }

            switch (item.type)
            {
                case ItemID.SummonerEmblem:
                    tooltips[tooltips.Count - 1].text += "\n+2 maximum minions and sentries";
                    break;

                case ItemID.MonkBelt:
                    foreach (var l in from TooltipLine l in tooltips
                                      where l.Name == "Tooltip0"
                                      select l)
                    {
                        l.text = "+1 maximum minions and sentries";
                    }

                    foreach (var l in from TooltipLine l in tooltips
                                      where l.Name == "Tooltip1"
                                      select l)
                    {
                        l.text = "10% increased minion damage\n4% increased melee speed and damage\n4% increased melee critical strike chance\n5% increased movement speed";
                    }
                    break;

                case ItemID.SquireShield:
                    foreach (var l in from TooltipLine l in tooltips
                                      where l.Name == "Tooltip0"
                                      select l)
                    {
                        l.text = "+1 maximum minions and sentries";
                    }

                    foreach (var l in from TooltipLine l in tooltips
                                      where l.Name == "Tooltip1"
                                      select l)
                    {
                        l.text = "10% increased minion damage\n2% increased melee damage\n4% increased melee critical strike chance\n5% increased movement speed\nIncreased health regeneration";
                    }
                    break;

                case ItemID.ApprenticeScarf:
                    foreach (var l in from TooltipLine l in tooltips
                                      where l.Name == "Tooltip0"
                                      select l)
                    {
                        l.text = "+1 maximum minions and sentries";
                    }

                    foreach (var l in from TooltipLine l in tooltips
                                      where l.Name == "Tooltip1"
                                      select l)
                    {
                        l.text = "10% increased minion damage\n4% increased magic damage and critical strike chance\n3% reduced mana usage\n4% increased movement speed";
                    }
                    break;

                case ItemID.HuntressBuckler:
                    foreach (var l in from TooltipLine l in tooltips
                                      where l.Name == "Tooltip0"
                                      select l)
                    {
                        l.text = "+1 maximum minions and sentries";
                    }

                    foreach (var l in from TooltipLine l in tooltips
                                      where l.Name == "Tooltip1"
                                      select l)
                    {
                        l.text = "10% increased minion damage\n4% increased ranged damage\n4% ranged critical strike chance\n4% increased movement speed\n2% chance not to consume ammo";
                    }
                    break;

                case ItemID.MechanicalGlove:
                    foreach (var l in from TooltipLine l in tooltips
                                      where l.Name == "Tooltip1"
                                      select l)
                    {
                        l.text += BuffedAccessories.calamity != null ?
                        "\n12% increased melee critical strike chance\n17% increased movement speed" :
                        "\n12% increased melee damage, speed, and critical strike chance\n17% increased movement speed";
                    }
                    break;

                case ItemID.FireGauntlet:
                    foreach (var l in from TooltipLine l in tooltips
                                      where l.Name == "Tooltip1"
                                      select l)
                    {
                        l.text += BuffedAccessories.calamity != null ?
                        "\n15% increased melee critical strike chance\n20% increased movement speed" :
                        "15% increased melee damage, speed, and critical strike chance\n20% increased movement speed";
                    }
                    break;

                case ItemID.ShinyStone:
                    foreach (var l in from TooltipLine l in tooltips
                                      where l.Name == "Tooltip0"
                                      select l)
                    {
                        l.text = "Greatly increases life regen and increases defense when not moving";
                    }
                    break;
            }
        }
    }
}
