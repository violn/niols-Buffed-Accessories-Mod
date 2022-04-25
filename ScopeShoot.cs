using Microsoft.Xna.Framework;
using niolsBuffedAccessories.Buffed;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class ScopeShoot : GlobalItem
    {
        public override void ModifyShootStats(Item item, Player player, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            Scopes.playerPosition = item.DamageType == DamageClass.Ranged && AccessoryProperties.EquippedRifleScope ? player.position : Scopes.playerPosition;
            base.ModifyShootStats(item, player, ref position, ref velocity, ref type, ref damage, ref knockback);
        }
    }
}