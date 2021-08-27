using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class Shackle : GlobalItem
    {
        public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage, ref float flat)
        {
            if (AccessoryProperties.equippedShackle && item.damage > 0)
            {
                flat += 1f;
            }

            if (AccessoryProperties.equippedMagicCuffs && item.damage > 0 && item.DamageType == DamageClass.Magic)
            {
                flat += 3f;
            }

            if (AccessoryProperties.equippedCelestialCuffs && item.damage > 0 && item.DamageType == DamageClass.Magic)
            {
                flat += 5f;
            }
        }
    }
}