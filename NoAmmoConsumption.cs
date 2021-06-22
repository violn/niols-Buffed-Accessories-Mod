using niolsBuffedAccessories;
using Terraria;
using Terraria.ModLoader;

public class NoAmmoConsumption : GlobalItem
{
    public override bool ConsumeAmmo(Item item, Player player)
    {
        int chance = 0;
        if (item.ranged)
        {
            chance += AccessoryProperties.equippedRangerEmblem ? 10 : 0;
            chance += AccessoryProperties.equippedSniperScope ? 15 : 0;
            chance += AccessoryProperties.equippedOOABuckler ? 2 : 0;
        }
        return BuffedAccessories.ran.Next(1, 100) < chance;
    }
}