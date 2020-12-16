using References;
using Terraria;
using Terraria.ModLoader;

//Handles things that happened when an item is used
public class OnUse : GlobalItem
{

    //Terraria hook ran when an item is used
    public override bool UseItem(Item item, Player player)
    {
        //Sets the item used to be used later
        if (item.damage > 0)
        {
            Reference.itemUsed = item;
        }
        
        //Allows melee weapons to autoswing when mech glove or fire gauntlet is equipped
        if (item.melee && (Reference.equippedMechGlove || Reference.equippedFGaunt))
        {
            if (!item.autoReuse)
            {
                item.autoReuse = true;
                if (!Reference.addedAutoSwing.Contains(item))
                {
                    Reference.addedAutoSwing.Add(item);
                }

                if (Reference.addedAutoSwing.Count > 2)
                {
                    int count = 0;
                    foreach (Item weapon in Reference.addedAutoSwing)
                    {
                        if (count == 0)
                        {
                            weapon.autoReuse = false;
                            count++;
                        }
                    }

                    Reference.addedAutoSwing.RemoveAt(0);
                }
            }
        }
        else if (Reference.addedAutoSwing.Count > 0)
        {
            int count = 0;
            foreach (Item weapon in Reference.addedAutoSwing)
            {
                if (count != 0)
                {
                    Reference.addedAutoSwing.RemoveAt(count);
                    count++;
                }
                weapon.autoReuse = false;
            }
            Reference.addedAutoSwing.RemoveAt(0);
        }

        return base.UseItem(item, player);
    }
}
