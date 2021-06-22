using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

public class MageEmblem : GlobalProjectile
{
    public static int celestialRegen = 15;
    public static float currentOnHitBoost = 0f;

    public override void ModifyHitNPC(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
    {
        if (proj.magic && (AccessoryProperties.equippedCelestialEmblem || AccessoryProperties.equippedSorcerorEmblem))
        {
            Timers.magicStacksDelay = 0;
            Timers.magicCounter = 0;
            float stacks_gained = ItemUsedMage.useTime / 2000f;
            currentOnHitBoost += stacks_gained + currentOnHitBoost > .3f ? .3f - currentOnHitBoost : stacks_gained;
            damage *= AccessoryProperties.equippedCelestialEmblem ? (int)(1f + currentOnHitBoost) : (int)(1f + currentOnHitBoost / 2f);
            celestialRegen = AccessoryProperties.equippedCelestialEmblem && celestialRegen < 60 ? (int)(celestialRegen + (currentOnHitBoost * 200)) : celestialRegen;
        }
    }
}

public class ItemUsedMage : GlobalItem
{
    public static int useTime = 20;

    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        if (item.magic && (AccessoryProperties.equippedCelestialEmblem || AccessoryProperties.equippedSorcerorEmblem))
        {
            useTime = item.useTime;
        }
        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }
}