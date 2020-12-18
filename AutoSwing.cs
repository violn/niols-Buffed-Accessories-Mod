using Microsoft.Xna.Framework;
using References;
using Terraria;
using Terraria.ModLoader;

//Give melee wepons autoswing with mech glove and fire gaunt
public class AutoSwing : GlobalItem
{
    //Add and remove auto swing for non projectile melee weapons
    public override bool UseItem(Item item, Player player)
    {
        if (item.melee && !item.autoReuse)
        {
            if (!Reference.addedAutoSwing.Contains(item.type))
            {
                Reference.addedAutoSwing.Add(item.type);
            }

            if (Reference.equippedFGaunt || Reference.equippedMechGlove)
            {
                item.autoReuse = true;
            }
        }

        if (!Reference.equippedFGaunt && !Reference.equippedMechGlove && Reference.addedAutoSwing.Contains(item.type))
        {
            item.autoReuse = false;
        }

        return base.UseItem(item, player);
    }

    //Add and remove auto swing for projectile melee weapons
    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        if (item.melee && !item.autoReuse)
        {
            if (!Reference.addedAutoSwing.Contains(item.type))
            {
                Reference.addedAutoSwing.Add(item.type);
            }

            if (Reference.equippedFGaunt || Reference.equippedMechGlove)
            {
                item.autoReuse = true;
            }
        }

        if (!Reference.equippedFGaunt && !Reference.equippedMechGlove && Reference.addedAutoSwing.Contains(item.type))
        {
            item.autoReuse = false;
        }

        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }
}