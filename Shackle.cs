using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class Shackle : GlobalItem
    {
        public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage, ref float flat)
        {
            flat += AccessoryProperties.equippedShackle && item.damage > 0 ? 1f : 0f;
            flat += AccessoryProperties.equippedMagicCuffs && item.damage > 0 && item.DamageType == DamageClass.Magic ? 3f : 0f;
            flat += AccessoryProperties.equippedCelestialCuffs && item.damage > 0 && item.DamageType == DamageClass.Magic ? 5f : 0f;
        }
    }
}