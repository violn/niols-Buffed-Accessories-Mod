using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class YoyoBag : GlobalItem
    {
        public override bool Shoot(Item item, Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (AccessoryProperties.YoyoDupe && YoyoProjectiles.YoyoProjectilesList.Contains(type))
            {
                SpawnProjectiles.CreateDuplicate(type, position, velocity.X, velocity.Y, damage, knockback, 2, player.GetSource_ItemUse(item));
            }

            return base.Shoot(item, player, source, position, velocity, type, damage, knockback);
        }
    }
}