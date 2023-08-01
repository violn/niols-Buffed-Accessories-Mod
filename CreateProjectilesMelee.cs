using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class CreateProjectilesMelee : GlobalItem
    {
        public override void ModifyHitNPC(Item item, Player player, NPC target, ref NPC.HitModifiers modifiers)
        {
            if (AccessoryProperties.SpawnBees && CreateProjectiles.SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
            {
                if (AccessoryProperties.StrongBees && BuffedAccessories.Ran.Next(100) < 50)
                {
                    SpawnProjectiles.CreateBees(target, item.damage, true, player.GetSource_ItemUse(item));
                }
                else SpawnProjectiles.CreateBees(target, item.damage, false, player.GetSource_ItemUse(item));
            }

            if (AccessoryProperties.SpawnStars && CreateProjectiles.SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
            {
                SpawnProjectiles.CreateStars(target, item.damage, player.GetSource_ItemUse(item));
            }
        }
    }
}