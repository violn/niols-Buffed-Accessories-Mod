using Microsoft.Xna.Framework;
using niolsBuffedAccessories.Buffed;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class ScopeShoot : GlobalItem
    {
        public override bool Shoot(Item item, Player player, ProjectileSource_Item_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Scopes.playerPosition = item.DamageType == DamageClass.Ranged && AccessoryProperties.equippedRifleScope ? player.position : Scopes.playerPosition;
            return base.Shoot(item, player, source, position, velocity, type, damage, knockback);
        }
    }
}