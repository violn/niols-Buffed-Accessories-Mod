using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class MageEmblem : GlobalProjectile
    {
        public static int CelestialRegen = 15;
        public static float CurrentOnHitBoost = 0f;

        public override void ModifyHitNPC(Projectile projectile, NPC target, ref NPC.HitModifiers modifiers)
        {
            if (projectile.DamageType == DamageClass.Magic && AccessoryProperties.MagicStacking)
            {
                Timers.MagicStacksDelay = 0;
                Timers.MagicCounter = 0;
                float stacks_gained = Main.LocalPlayer.HeldItem.useTime / 2000f;

                CurrentOnHitBoost = stacks_gained + CurrentOnHitBoost > .2f ?
                    .2f : stacks_gained + CurrentOnHitBoost;

                modifiers.SourceDamage *= (int)(1f + CurrentOnHitBoost);

                CelestialRegen = AccessoryProperties.MagicStacking && CelestialRegen < 40 ?
                    (int)(CelestialRegen + CurrentOnHitBoost * 100) : CelestialRegen;
            }
        }
    }
}