using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

public class UseTime : GlobalItem
{
    public static int itemUseTime = 20;

    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        itemUseTime = item.useTime;
        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }
}