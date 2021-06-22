using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

public class AutoSwing : GlobalItem
{
    public static List<int> addedAutoSwing = new List<int>();

    public override bool UseItem(Item item, Player player)
    {
        if (item.melee)
        {
            UseTime.itemUseTime = item.useTime;

            if (!item.autoReuse && AccessoryProperties.equippedMechGlove)
            {
                if (addedAutoSwing.Count == 0)
                {
                    addedAutoSwing.Add(item.type);
                    item.autoReuse = true;
                }

                if (!addedAutoSwing.Contains(item.type))
                {
                    addedAutoSwing.Add(item.type);
                    item.autoReuse = true;
                }
            }
        }

        return base.UseItem(item, player);
    }

    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        if (item.melee && !item.autoReuse && AccessoryProperties.equippedMechGlove)
        {
            if (addedAutoSwing.Count == 0)
            {
                addedAutoSwing.Add(item.type);
                item.autoReuse = true;
            }

            if (!addedAutoSwing.Contains(item.type))
            {
                addedAutoSwing.Add(item.type);
                item.autoReuse = true;
            }
        }

        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }

    public override void HoldItem(Item item, Player player)
    {
        if (!AccessoryProperties.equippedMechGlove && addedAutoSwing.Count > 0 && addedAutoSwing.Contains(item.type))
        {
            item.autoReuse = false;
            addedAutoSwing.Remove(item.type);
        }
    }
}
