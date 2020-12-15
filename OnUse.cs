using References;
using Terraria;
using Terraria.ModLoader;

public class OnUse : GlobalItem
{
    public override bool UseItem(Item item, Player player)
    {
        if (item.damage > 0)
        {
            Reference.itemUsed = item;
        }

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