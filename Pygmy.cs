using niolsBuffedAccessories;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class Pygmy : GlobalProjectile
{
    public override void OnHitNPC(Projectile proj, NPC target, int damage, float knockback, bool crit)
    {
        if ((AccessoryProperties.equippedStar && proj.type == ProjectileID.HallowStar) ||
            (AccessoryProperties.equippedHive && proj.type == ProjectileID.GiantBee) ||
            (AccessoryProperties.equippedBee && proj.type == ProjectileID.Bee) ||
            (AccessoryProperties.equippedPlagueHive && BuffedAccessories.calamity != null && proj.type != BuffedAccessories.calamity.ProjectileType("PlaguenadeBee")) ||
            ((proj.sentry || proj.minion) && AccessoryProperties.equippedPygmyNecklace))
        {
            proj.usesLocalNPCImmunity = true;
            proj.localNPCImmunity[target.whoAmI] = 10;
            target.immune[proj.owner] = 0;
        }
    }
}