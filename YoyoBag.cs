﻿using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class YoyoBag : GlobalItem
    {
        public override bool Shoot(Item item, Player player, ProjectileSource_Item_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            if (AccessoryProperties.equippedYoyoBag && YoyoProjectiles.yoyoProjectiles.Contains(type))
            {
                SpawnProjectiles.CreateDuplicate(type, position, velocity.X, velocity.Y, damage, knockback, 2, player.GetProjectileSource_Item(item));
            }

            return base.Shoot(item, player, source, position, velocity, type, damage, knockback);
        }
    }
}