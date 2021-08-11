using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class CreateProjectilesMelee : GlobalItem
    {
        public override void ModifyHitNPC(Item item, Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            if (AccessoryProperties.equippedBee && CreateProjectiles.SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
            {
                if (AccessoryProperties.equippedHive && BuffedAccessories.ran.Next(1, 100) < 50)
                {
                    SpawnProjectiles.CreateBees(target, damage, true, player.GetProjectileSource_Item(item));
                }
                else SpawnProjectiles.CreateBees(target, damage, false, player.GetProjectileSource_Item(item));
            }

            if (AccessoryProperties.equippedStar && CreateProjectiles.SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
            {
                SpawnProjectiles.CreateStars(target, damage, player.GetProjectileSource_Item(item));
            }
        }
    }
}