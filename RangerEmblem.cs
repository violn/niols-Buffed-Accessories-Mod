using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class RangerEmblem : GlobalItem
    {
        public override void ModifyShootStats(Item item, Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (AccessoryProperties.RangedDupe && item.DamageType == DamageClass.Ranged && CreateProjectiles.SpawnProjectile(item.useTime))
            {
                SpawnProjectiles.CreateDuplicate(type, position, velocity.X, velocity.Y, damage, knockback, 1, player.GetSource_ItemUse(item));
            }
        }
    }
}