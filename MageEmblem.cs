using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class MageEmblem : GlobalProjectile
    {
        public static int celestialRegen = 15;
        public static float currentOnHitBoost = 0f;

        public override void ModifyHitNPC(Projectile projectile, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (projectile.DamageType == DamageClass.Magic && AccessoryProperties.equippedSorcerorEmblem)
            {
                Timers.magicStacksDelay = 0;
                Timers.magicCounter = 0;
                float stacks_gained = Main.LocalPlayer.HeldItem.useTime / 2000f;
                currentOnHitBoost += stacks_gained + currentOnHitBoost > .2f ? .2f - currentOnHitBoost : stacks_gained;
                damage = (int)(damage * (1f + currentOnHitBoost));
                celestialRegen = AccessoryProperties.equippedCelestialEmblem && celestialRegen < 40 ? (int)(celestialRegen + currentOnHitBoost * 100) : celestialRegen;
            }
        }
    }
}