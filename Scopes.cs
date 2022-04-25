using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class Scopes : GlobalProjectile
    {
        private static Vector2 targetPosition = new(0f, 0f);
        public static Vector2 playerPosition = new(0f, 0f);

        public override void ModifyHitNPC(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (proj.DamageType == DamageClass.Ranged && (AccessoryProperties.EquippedRifleScope))
            {
                targetPosition = new Vector2(target.position.X, target.position.Y);
                damage = CalculateRangedDamage(damage);
            }
        }

        private static int CalculateRangedDamage(int damage)
        {
            float distance = GetDistance() > 0f ? GetDistance() : 0f;
            float damage_multiplier = (float)(Math.Pow(distance / 1600f, 3f / 2f) > .4f ? .4f : Math.Pow(distance / 1600f, 3f / 2f));
            return (int)(damage * (1f + damage_multiplier));
        }

        private static float GetDistance() => (float)Math.Sqrt(Math.Pow(targetPosition.X - playerPosition.X, 2) + Math.Pow(targetPosition.Y - playerPosition.Y, 2)) - 100f;
    }
}