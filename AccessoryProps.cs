using References;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class AccessoryProps : GlobalItem
    {
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            if (Reference.beeItems.Contains(item.type))
            {
                Reference.equippedBee = true;
            }

            if (Reference.starItems.Contains(item.type))
            {
                Reference.equippedStar = true;
            }

            if (Reference.hiveItems.Contains(item.type))
            {
                Reference.equippedHive = true;
            }

            if (item.type == ItemID.RangerEmblem)
            {
                Reference.equippedRangerE = true;
            }

            if (item.type == ItemID.RifleScope)
            {
                player.rangedCrit += 5;
                Reference.equippedRScope = true;
            }

            if (item.type == ItemID.SniperScope)
            {
                Reference.equippedSScope = true;
            }

            if (item.type == ItemID.SorcererEmblem)
            {
                player.statManaMax2 += 50;
                player.manaCost *= .75f;
                Reference.equippedSorcE = true;
            }

            if (item.type == ItemID.CelestialEmblem)
            {
                player.manaRegenBonus += Reference.celeRegen;
                player.manaRegenDelayBonus += 10;
                player.statManaMax2 += 100;
                player.manaCost *= .72f;
                Reference.equippedCeleE = true;
            }

            if (item.type == ItemID.MagicCuffs)
            {
                player.manaRegenBonus += 33;
                player.manaRegenDelayBonus = 10;
            }

            if (item.type == ItemID.CelestialCuffs)
            {
                player.manaRegenBonus += 38;
                player.manaRegenDelayBonus = 10;
            }

            if (item.type == ItemID.SummonerEmblem)
            {
                player.maxMinions += 2;
                player.maxTurrets += 2;
            }

            if (item.type == ItemID.WarriorEmblem)
            {
                player.maxRunSpeed += 0.10f;
                player.moveSpeed += 0.10f;
                player.meleeCrit += 8;
                Reference.equippedWarE = true;
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
                Reference.equippedYoyoBag = true;
            }

            if (Reference.upa != null)
            {
                if (item.type == Reference.upa.ItemType("Vengeance"))
                {
                    Reference.equippedBee = true;
                    Reference.equippedStar = true;
                }

                if (item.type == Reference.upa.ItemType("SolarFlareGlove"))
                {
                    Reference.equippedFGaunt = true;
                }

                if (item.type == Reference.upa.ItemType("VortexScope"))
                {
                    Reference.equippedSScope = true;
                }

                if (item.type == Reference.upa.ItemType("NebulaFlower"))
                {
                    Reference.equippedCeleE = true;
                }
            }

            if (Reference.thor != null)
            {
                if (item.type == Reference.thor.ItemType("SweetVengeance"))
                {
                    Reference.equippedStar = true;
                    Reference.equippedBee = true;
                }
            }

            if (Reference.cal != null)
            {
                if (item.type == Reference.cal.ItemType("PlagueHive"))
                {
                    Reference.equippedHive = true;
                    Reference.equippedBee = true;
                    Reference.equippedPlague = true;
                }

                if (item.type == Reference.cal.ItemType("DeificAmulet"))
                {
                    Reference.equippedStar = true;
                }

                if (item.type == Reference.cal.ItemType("RampartofDeities"))
                {
                    Reference.equippedStar = true;
                }

                if (item.type == Reference.cal.ItemType("ElementalGauntlet"))
                {
                    Reference.equippedFGaunt = true;
                }

                if (item.type == Reference.cal.ItemType("YharimsInsignia"))
                {
                    Reference.equippedFGaunt = true;
                }

                if (item.type == Reference.cal.ItemType("DaedalusEmblem"))
                {
                    Reference.equippedRangerE = true;
                }

                if (item.type == Reference.cal.ItemType("ElementalQuiver"))
                {
                    Reference.equippedRangerE = true;
                }

                if (item.type == Reference.cal.ItemType("SigilofCalamitas"))
                {
                    Reference.equippedCeleE = true;
                }

                if (item.type == Reference.cal.ItemType("EtherealTalisman"))
                {
                    Reference.equippedCeleE = true;
                }

                if (item.type == ItemID.MechanicalGlove)
                {
                    player.maxRunSpeed += 0.17f;
                    player.moveSpeed += 0.17f;
                    player.meleeCrit += 12;
                    Reference.equippedMechGlove = true;
                }

                if (item.type == ItemID.FireGauntlet)
                {
                    player.maxRunSpeed += 0.20f;
                    player.moveSpeed += 0.20f;
                    player.meleeCrit += 16;
                    Reference.equippedFGaunt = true;
                }
            }
            else
            {
                if (item.type == ItemID.MechanicalGlove)
                {
                    player.maxRunSpeed += 0.17f;
                    player.moveSpeed += 0.17f;
                    player.meleeCrit += 12;
                    Reference.equippedMechGlove = true;
                }

                if (item.type == ItemID.FireGauntlet)
                {
                    player.maxRunSpeed += 0.20f;
                    player.meleeDamage += 0.04f;
                    player.meleeSpeed += 0.04f;
                    player.moveSpeed += 0.20f;
                    player.meleeCrit += 16;
                    Reference.equippedFGaunt = true;
                }
            }

            if (Reference.ea != null)
            {
                if (item.type == Reference.ea.ItemType("ElementalArcanum"))
                {
                    Reference.equippedCeleE = true;
                    Reference.equippedFGaunt = true;
                    Reference.equippedStar = true;
                }

                if (item.type == Reference.ea.ItemType("FrozenGauntlet"))
                {
                    Reference.equippedFGaunt = true;
                    Reference.equippedStar = true;
                }

                if (item.type == Reference.ea.ItemType("SolarEmblem"))
                {
                    Reference.equippedFGaunt = true;
                }

                if (item.type == Reference.ea.ItemType("StardustEmblem"))
                {
                    player.maxMinions += 3;
                    player.maxTurrets += 3;
                }

                if (item.type == Reference.ea.ItemType("VortexEmblem"))
                {
                    Reference.equippedRangerE = true;
                }

                if (item.type == Reference.ea.ItemType("NebulaEmblem"))
                {
                    player.manaRegenBonus += Reference.celeRegen;
                    player.manaRegenDelayBonus += 10;
                    player.statManaMax2 += 100;
                    player.manaCost *= .72f;
                    Reference.equippedCeleE = true;
                }

                if (item.type == Reference.ea.ItemType("EtherealShell"))
                {
                    Reference.equippedCeleE = true;
                }
            }

            Reference.counter++;

            Reference.counter2++;

            Reference.counter3++;

            if (Reference.counter % 56 == 0 && Reference.depleteBoost < .31)
            {
                Reference.depleteBoost += .01;
                Reference.counter = 0;
            }

            if (Reference.counter2 % 277 == 0)
            {
                Reference.counter2 = 0;
                Reference.secondsPassed++;
            }

            if (Reference.counter3 % 277 == 0)
            {
                Reference.counter3 = 0;
                Reference.secondsPassed2++;
            }

            if (Reference.secondsPassed > 0)
            {
                if (Reference.secondsPassed > 0)
                {
                    Reference.beesSpawned = 0;
                }

                if (Reference.secondsPassed > 10)
                {
                    Reference.secondsPassed = 0;
                }
            }

            if (Reference.secondsPassed2 > 0)
            {
                if (Reference.secondsPassed2 > 2)
                {
                    Reference.starsSpawned = 0;
                }

                if (Reference.secondsPassed2 > 10)
                {
                    Reference.secondsPassed2 = 0;
                }
            }
        }
    }
}