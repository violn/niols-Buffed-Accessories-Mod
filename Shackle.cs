using Terraria;
using Terraria.ModLoader;

public class StaticDamageIncrease : GlobalItem
{
    public override void ModifyWeaponDamage(Item item, Player player, ref float add, ref float mult, ref float flat)
    {
        if (AccessoryProperties.equippedSufferWithMe && item.damage > 0)
        {
            flat += 35f;
        }

        if (AccessoryProperties.equippedShackle && item.damage > 0)
        {
            flat += 1f;
        }

        if (AccessoryProperties.equippedCelestialCuffs && item.damage > 0 && item.magic)
        {
            flat += 5f;
        }

        if (AccessoryProperties.equippedMagicCuffs && item.damage > 0 && item.magic)
        {
            flat += 3f;
        }
    }
}
