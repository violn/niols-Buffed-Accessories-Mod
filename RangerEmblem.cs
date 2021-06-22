using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

public class RangerEmblem : GlobalItem
{
    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        if (AccessoryProperties.equippedRangerEmblem && item.ranged && CreateProjectiles.SpawnProjectile(item.useTime))
        {
            SpawnProjectiles.CreateDuplicate(type, position, speedX, speedY, damage, knockBack, 1);
        }

        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }
}