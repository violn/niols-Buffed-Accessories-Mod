using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;

public class Scopes : GlobalProjectile
{
    private static Vector2 targetPosition = new Vector2(0f, 0f);
    public static Vector2 playerPosition = new Vector2(0f, 0f);

    public override void ModifyHitNPC(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
    {
        if (proj.ranged && (AccessoryProperties.equippedRifleScope || AccessoryProperties.equippedSniperScope))
        {
            targetPosition = new Vector2(target.position.X, target.position.Y);
            damage = CalculateRangedDamage(damage);
        }
    }

    private static int CalculateRangedDamage(int damage)
    {
        float distance = GetDistance() > 0f ? GetDistance() : 0f;
        float damage_multiplier = (float)(Math.Pow(distance / 1600f, 3f / 2f) > .5f ? .5f : Math.Pow(distance / 1600f, 3f / 2f));
        damage_multiplier *= AccessoryProperties.equippedRifleScope && !AccessoryProperties.equippedSniperScope ? .5f : 1f;
        return (int)(damage * (1f + damage_multiplier));
    }

    private static float GetDistance() => ((float)Math.Sqrt(Math.Pow(targetPosition.X - playerPosition.X, 2) + Math.Pow(targetPosition.Y - playerPosition.Y, 2))) - 100f;
}

public class ScopeShoot : GlobalItem
{
    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        Scopes.playerPosition = item.ranged && (AccessoryProperties.equippedRifleScope || AccessoryProperties.equippedSniperScope) ? player.position : Scopes.playerPosition;
        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }
}