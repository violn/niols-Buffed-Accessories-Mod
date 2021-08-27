using niolsBuffedAccessories.Buffed;
using niolsBuffedAccessories.Configs;
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
            if (ModContent.GetInstance<Config>().AllBuffs)
            {
                double current_stacks = Math.Round(MageEmblem.currentOnHitBoost * 100, 0, MidpointRounding.AwayFromZero);

                switch (item.type)
                {
                    case ItemID.HoneyComb:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Bee
                                          select l)
                        {
                            l.text += "\nAttacks have a chance to spawn bees";
                        }
                        break;

                    case ItemID.HoneyBalloon:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1" && ModContent.GetInstance<Config>().Bee
                                          select l)
                        {
                            l.text += "\nAttacks have a chance to spawn bees";
                        }
                        break;

                    case ItemID.BalloonHorseshoeHoney:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1" && ModContent.GetInstance<Config>().Bee
                                          select l)
                        {
                            l.text += "\nAttacks have a chance to spawn bees";
                        }
                        break;

                    case ItemID.StingerNecklace:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1" && ModContent.GetInstance<Config>().Bee
                                          select l)
                        {
                            l.text += "\nAttacks have a chance to spawn bees";
                        }
                        break;

                    case ItemID.SweetheartNecklace:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Bee
                                          select l)
                        {
                            l.text += "\nAttacks have a chance to spawn bees";
                        }
                        break;

                    case ItemID.BeeCloak:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.text += (ModContent.GetInstance<Config>().Bee ? "\nAttacks have a chance to spawn bees" : "") + (ModContent.GetInstance<Config>().Star ? "\nAttacks have a chance to spawn stars from the sky" : "");
                        }
                        break;

                    case ItemID.StarCloak:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Star
                                          select l)
                        {
                            l.text += "\nAttacks have a chance to spawn stars from the sky";
                        }
                        break;

                    case ItemID.ManaCloak:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Star
                                          select l)
                        {
                            l.text += "\nAttacks have a chance to spawn stars from the sky";
                        }
                        break;

                    case ItemID.StarVeil:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.text += (ModContent.GetInstance<Config>().Star ? "\nAttacks have a chance to spawn stars from the sky" : "") + (ModContent.GetInstance<Config>().Cross ? "\nGain a chance to prevent death" : "");
                        }
                        break;


                    case ItemID.CrossNecklace:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Cross
                                          select l)
                        {
                            l.text += "\nGain a chance to prevent death";
                        }
                        break;

                    case ItemID.SorcererEmblem:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Sorceror
                                          select l)
                        {
                            l.text += $"\n15% reduced mana usage\n+50 maximum mana\nDealing magic damage applies a magic stack that boosts magic damage\nCurrent stacks: {current_stacks}";
                        }
                        break;

                    case ItemID.CelestialEmblem:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1" && ModContent.GetInstance<Config>().CelestialEmblem
                                          select l)
                        {
                            l.text += $"\n+100 maximum mana\n17% reduced mana usage\nDealing magic damage applies a magic stack that boosts magic damage and mana regeneration\nCurrent stacks: {current_stacks}";
                        }
                        break;

                    case ItemID.RangerEmblem:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Ranger
                                          select l)
                        {
                            l.text += "\n10% chance not to consume ammo\nRanged projectiles have a chance to duplicate";
                        }
                        break;

                    case ItemID.RifleScope:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Rifle
                                          select l)
                        {
                            l.text += "\nIncreased ranged damage based on distance";
                        }
                        break;

                    case ItemID.SniperScope:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Sniper
                                          select l)
                        {
                            l.text += "\n15% chance not to consume ammo\nRanged projectiles have a chance to duplicate\nIncreased ranged damage based on distance";
                        }
                        break;

                    case ItemID.MagicCuffs:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1" && ModContent.GetInstance<Config>().Magic
                                          select l)
                        {
                            l.text += "\nIncreased mana regeneration\n+3 magic damage";
                        }
                        break;

                    case ItemID.CelestialCuffs:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip2" && ModContent.GetInstance<Config>().CelestialCuffs
                                          select l)
                        {
                            l.text += "\nIncreased mana regeneration\n+5 magic damage";
                        }
                        break;

                    case ItemID.WarriorEmblem:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Warrior
                                          select l)
                        {
                            l.text += "\n8% increased melee critical strike chance\n10% increased movement speed\nKilling an enemy enhances your melee abilities";
                        }
                        break;

                    case ItemID.PygmyNecklace:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Pygmy
                                          select l)
                        {
                            l.text += "\nPrevents immunity frames creation of minions";
                        }
                        break;

                    case ItemID.Shackle:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Defense" && ModContent.GetInstance<Config>().Shackle
                                          select l)
                        {
                            l.text += "\n+1 damage";
                        }
                        break;

                    case ItemID.SummonerEmblem:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Summon
                                          select l)
                        {
                            l.text += "\n+2 maximum minions and sentries";
                        }
                        break;

                    case ItemID.MonkBelt:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Belt
                                          select l)
                        {
                            l.text = "+1 maximum minions and sentries";
                        }

                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1" && ModContent.GetInstance<Config>().Belt
                                          select l)
                        {
                            l.text = "10% increased minion damage\n4% increased melee speed and damage\n4% increased melee critical strike chance\n5% increased movement speed";
                        }
                        break;

                    case ItemID.SquireShield:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Shield
                                          select l)
                        {
                            l.text = "+1 maximum minions and sentries";
                        }

                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1" && ModContent.GetInstance<Config>().Shield
                                          select l)
                        {
                            l.text = "10% increased minion damage\n2% increased melee damage\n4% increased melee critical strike chance\n5% increased movement speed\nIncreased health regeneration";
                        }
                        break;

                    case ItemID.ApprenticeScarf:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Scarf
                                          select l)
                        {
                            l.text = "+1 maximum minions and sentries";
                        }

                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1" && ModContent.GetInstance<Config>().Scarf
                                          select l)
                        {
                            l.text = "10% increased minion damage\n4% increased magic damage and critical strike chance\n3% reduced mana usage\n4% increased movement speed";
                        }
                        break;

                    case ItemID.HuntressBuckler:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0" && ModContent.GetInstance<Config>().Buckler
                                          select l)
                        {
                            l.text = "+1 maximum minions and sentries";
                        }

                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1" && ModContent.GetInstance<Config>().Buckler
                                          select l)
                        {
                            l.text = "10% increased minion damage\n4% increased ranged damage\n4% ranged critical strike chance\n4% increased movement speed\n2% chance not to consume ammo";
                        }
                        break;

                    case ItemID.MechanicalGlove:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1" && ModContent.GetInstance<Config>().Glove
                                          select l)
                        {
                            l.text += "\n12% increased melee damage, speed, and critical strike chance\n17% increased movement speed";
                        }
                        break;

                    case ItemID.FireGauntlet:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1" && ModContent.GetInstance<Config>().Gauntlet
                                          select l)
                        {
                            l.text += "\n15% increased melee damage, speed, and critical strike chance\n20% increased movement speed";
                        }
                        break;
                }
            }
        }
    }
}