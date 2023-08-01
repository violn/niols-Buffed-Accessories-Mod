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
                double current_stacks = Math.Round(MageEmblem.CurrentOnHitBoost * 100, 0);

                switch (item.type)
                {
                    case ItemID.HoneyComb:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text += ModContent.GetInstance<Config>().SpawnBees ? "\nAttacks have a chance to spawn bees when hitting an enemy" : "";
                        }
                        break;

                    case ItemID.HoneyBalloon:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1"
                                          select l)
                        {
                            l.Text += ModContent.GetInstance<Config>().SpawnBees ? "\nAttacks have a chance to spawn bees when hitting an enemy" : "";
                        }
                        break;

                    case ItemID.BalloonHorseshoeHoney:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1"
                                          select l)
                        {
                            l.Text += ModContent.GetInstance<Config>().SpawnBees ? "\nAttacks have a chance to spawn bees when hitting an enemy" : "";
                        }
                        break;

                    case ItemID.StingerNecklace:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1"
                                          select l)
                        {
                            l.Text += ModContent.GetInstance<Config>().SpawnBees ? "\nAttacks have a chance to spawn bees when hitting an enemy" : "";
                        }
                        break;

                    case ItemID.SweetheartNecklace:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text += ModContent.GetInstance<Config>().SpawnBees ? "\nAttacks have a chance to spawn bees when hitting an enemy" : "";
                        }
                        break;

                    case ItemID.BeeCloak:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text += (ModContent.GetInstance<Config>().SpawnBees ? "\nAttacks have a chance to spawn bees when hitting an enemy" : "") +
                                (ModContent.GetInstance<Config>().SpawnStars ? "\nAttacks have a chance to spawn stars from the sky" : "");
                        }
                        break;

                    case ItemID.StarCloak:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text += ModContent.GetInstance<Config>().SpawnStars ? "\nAttacks have a chance to spawn stars from the sky when hitting an enemy" : "";
                        }
                        break;

                    case ItemID.ManaCloak:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text += ModContent.GetInstance<Config>().SpawnStars ? "\nAttacks have a chance to spawn stars from the sky when hitting an enemy" : "";
                        }
                        break;

                    case ItemID.StarVeil:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text += (ModContent.GetInstance<Config>().SpawnStars ? "\nAttacks have a chance to spawn stars from the sky when hitting an enemy" : "") +
                                (ModContent.GetInstance<Config>().DeathPrevention ? "\nGain a chance to prevent death" : "");
                        }
                        break;


                    case ItemID.CrossNecklace:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text += ModContent.GetInstance<Config>().DeathPrevention ? "\nGain a chance to prevent death" : "";
                        }
                        break;

                    case ItemID.SorcererEmblem:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text +=
                                $"\n15% reduced mana usage\n+50 maximum mana" +
                                $"{(ModContent.GetInstance<Config>().MagicStacking ? $"\nDealing magic damage applies a magic stack that boosts magic damage\nCurrent stacks: {current_stacks}" : "")}";
                        }
                        break;

                    case ItemID.CelestialEmblem:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1"
                                          select l)
                        {
                            l.Text += $"\n+100 maximum mana\n17% reduced mana usage" +
                                $"{(ModContent.GetInstance<Config>().MagicStacking ? $"\nDealing magic damage applies a magic stack that boosts magic damage and mana regeneration\nCurrent stacks: {current_stacks}" : "")}";
                        }
                        break;

                    case ItemID.RangerEmblem:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text += $"\n10% chance not to consume ammo" +
                                $"{(ModContent.GetInstance<Config>().RangedDupe ? "\nRanged projectiles have a chance to duplicate" : "")}";
                        }
                        break;

                    case ItemID.RifleScope:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip0" select l)
                        {
                            l.Text += ModContent.GetInstance<Config>().ScopeIncrease ? "\nIncreased ranged damage based on distance" : "";
                        }
                        break;

                    case ItemID.SniperScope:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip1" select l)
                        {
                            l.Text += $"\n15% chance not to consume ammo" +
                                $"{(ModContent.GetInstance<Config>().RangedDupe ? "\nRanged projectiles have a chance to duplicate" : "")}" +
                                $"{(ModContent.GetInstance<Config>().ScopeIncrease ? "\nIncreased ranged damage based on distance" : "")}";
                        }
                        break;

                    case ItemID.ReconScope:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip1" select l)
                        {
                            l.Text += $"\n15% chance not to consume ammo" +
                                $"{(ModContent.GetInstance<Config>().RangedDupe ? "\nRanged projectiles have a chance to duplicate" : "")}" +
                                $"{(ModContent.GetInstance<Config>().ScopeIncrease ? "\nIncreased ranged damage based on distance" : "")}";
                        }
                        break;

                    case ItemID.BandofStarpower:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip0" select l)
                        {
                            l.Text += "\nEnhances mana regeneration when hit";
                        }
                        break;

                    case ItemID.ManaRegenerationBand:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip1" select l)
                        {
                            l.Text += "\nEnhances mana regeneration when hit";
                        }
                        break;

                    case ItemID.MagicCuffs:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip1" select l)
                        {
                            l.Text += "\nIncreased mana regeneration\n+3 magic damage\nEnhances mana regeneration when hit";
                        }
                        break;

                    case ItemID.CelestialCuffs:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip2" select l)
                        {
                            l.Text += "\nIncreased mana regeneration\n+5 magic damage\nEnhances mana regeneration when hit";
                        }
                        break;

                    case ItemID.WarriorEmblem:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip0" select l)
                        {
                            l.Text += $"\n8% increased melee critical strike chance\n10% increased movement speed" +
                                $"{(ModContent.GetInstance<Config>().BeserkerRage ? "\nKilling an enemy with a melee attack enhances your melee abilities" : "")}";
                        }
                        break;

                    case ItemID.PygmyNecklace:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip0" select l)
                        {
                            l.Text += ModContent.GetInstance<Config>().SummonImmunity ? "\nPrevents immunity frames creation of minions" : "";
                        }
                        break;

                    case ItemID.Shackle:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Defense" select l)
                        {
                            l.Text += "\n+1 damage";
                        }
                        break;

                    case ItemID.SummonerEmblem:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip0" select l)
                        {
                            l.Text += "\n+2 maximum minions and sentries";
                        }
                        break;

                    case ItemID.MonkBelt:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text = "+1 maximum minions and sentries";
                        }

                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1"
                                          select l)
                        {
                            l.Text = "10% increased minion damage\n4% increased melee speed and damage\n4% increased melee critical strike chance\n5% increased movement speed";
                        }
                        break;

                    case ItemID.SquireShield:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text = "+1 maximum minions and sentries";
                        }

                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1"
                                          select l)
                        {
                            l.Text = "10% increased minion damage\n2% increased melee damage\n4% increased melee critical strike chance\n5% increased movement speed\nIncreased health regeneration";
                        }
                        break;

                    case ItemID.ApprenticeScarf:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text = "+1 maximum minions and sentries";
                        }

                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1"
                                          select l)
                        {
                            l.Text = "10% increased minion damage\n4% increased magic damage and critical strike chance\n3% reduced mana usage\n4% increased movement speed";
                        }
                        break;

                    case ItemID.HuntressBuckler:
                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip0"
                                          select l)
                        {
                            l.Text = "+1 maximum minions and sentries";
                        }

                        foreach (var l in from TooltipLine l in tooltips
                                          where l.Name == "Tooltip1"
                                          select l)
                        {
                            l.Text = "10% increased minion damage\n4% increased ranged damage\n4% ranged critical strike chance\n4% increased movement speed\n2% chance not to consume ammo";
                        }
                        break;

                    case ItemID.MechanicalGlove:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip1" select l)
                        {
                            l.Text += $"\n12% increased melee damage, speed, and critical strike chance\n17% increased movement speed" +
                                $"{(ModContent.GetInstance<Config>().BeserkerRage ? "\nKilling an enemy with a melee attack enhances your melee abilities" : "")}";
                        }
                        break;

                    case ItemID.FireGauntlet:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip1" select l)
                        {
                            l.Text += $"\n15% increased melee damage, speed, and critical strike chance\n20% increased movement speed" +
                                $"{(ModContent.GetInstance<Config>().BeserkerRage ? "\nKilling an enemy with a melee attack enhances your melee abilities" : "")}";
                        }
                        break;

                    case ItemID.ArcaneFlower:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip0" select l)
                        {
                            l.Text += "\n10% increased magic damage\n5% increased magic crit chance";
                        }
                        break;


                    case ItemID.StalkersQuiver:
                        foreach (var l in from TooltipLine l in tooltips where l.Name == "Tooltip0" select l)
                        {
                            l.Text += "\n10% increased arrow crit chance";
                        }
                        break;
                }
            }
        }
    }
}