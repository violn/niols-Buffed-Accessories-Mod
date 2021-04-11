using Microsoft.Xna.Framework;
using System.Collections;
using Terraria;
using Terraria.ModLoader;

//Give melee wepons autoswing with mech glove and fire gaunt
public class AutoSwing : GlobalItem
{
    /// <summary>
    /// A list of weapons that have gotten autoswing.
    /// </summary>
    public static ArrayList addedAutoSwing = new ArrayList();

    //Adds and remove auto swing for non projectile melee weapons
    public override bool UseItem(Item item, Player player)
    {
        if (item.melee)
        {
            OnHitProj.itemUseTime = item.useTime;
        }

        if (item.melee && !item.autoReuse)
        {
            if (addedAutoSwing.Count == 0)
            {
                addedAutoSwing.Add(item.type);
                item.autoReuse = true;
            }

            if ((AccessoryProperties.equippedFireGauntlet || AccessoryProperties.equippedMechGlove) && !addedAutoSwing.Contains(item.type))
            {
                addedAutoSwing.Add(item.type);
                item.autoReuse = true;
            }
        }

        return base.UseItem(item, player);
    }

    //Add and remove auto swing for projectile melee weapons
    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        if (item.melee && !item.autoReuse)
        {
            if (addedAutoSwing.Count == 0)
            {
                addedAutoSwing.Add(item.type);
                item.autoReuse = true;
            }

            if ((AccessoryProperties.equippedFireGauntlet || AccessoryProperties.equippedMechGlove) && !addedAutoSwing.Contains(item.type))
            {
                addedAutoSwing.Add(item.type);
                item.autoReuse = true;
            }
        }

        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }

    //Removes autoswing from originally non-autoswing weapons
    public override void HoldItem(Item item, Player player)
    {
        if (!AccessoryProperties.equippedFireGauntlet && !AccessoryProperties.equippedMechGlove && addedAutoSwing.Count > 0)
        {
            if (addedAutoSwing.Contains(item.type))
            {
                item.autoReuse = false;
                addedAutoSwing.Remove(item.type);
            }
        }
    }
}
