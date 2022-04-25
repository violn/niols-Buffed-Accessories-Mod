using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class Shackle : GlobalItem
    {
        public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage)
        {
            damage.Flat += AccessoryProperties.EquippedShackle && item.damage > 0 ? 1f : 0f;
            damage.Flat += AccessoryProperties.EquippedMagicCuffs && item.damage > 0 && item.DamageType == DamageClass.Magic ? 3f : 0f;
            damage.Flat += AccessoryProperties.EquippedCelestialCuffs && item.damage > 0 && item.DamageType == DamageClass.Magic ? 5f : 0f;
        }
    }
}