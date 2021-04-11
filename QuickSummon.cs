using Microsoft.Xna.Framework;
using System.Collections;
using Terraria;
using Terraria.ModLoader;

//Allows the player to quickly summon summons.
public class QuickSummon : GlobalItem
{
    public static ArrayList AddedSummon = new ArrayList();
    public override void OnConsumeMana(Item item, Player player, int manaConsumed)
    {
        if ((item.summon || item.sentry) && !item.autoReuse && ToggleSummon.QuickSummonEnabled)
        {
            if (AddedSummon.Count == 0)
            {
                AddedSummon.Add(item.type);
                item.useTime /= 3;
                item.autoReuse = true;
            }

            if (!AddedSummon.Contains(item.type))
            {
                AddedSummon.Add(item.type);
                item.useTime /= 3;
                item.autoReuse = true;
            }
        }
    }
    public override bool UseItem(Item item, Player player)
    {
        if ((item.summon || item.sentry) && !item.autoReuse && ToggleSummon.QuickSummonEnabled)
        {
            if (AddedSummon.Count == 0)
            {
                AddedSummon.Add(item.type);
                item.useTime /= 3;
                item.autoReuse = true;
            }

            if (!AddedSummon.Contains(item.type))
            {
                AddedSummon.Add(item.type);
                item.useTime /= 3;
                item.autoReuse = true;
            }
        }

        return base.UseItem(item, player);
    }

    public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        if ((item.summon || item.sentry) && !item.autoReuse && ToggleSummon.QuickSummonEnabled)
        {
            if (AddedSummon.Count == 0)
            {
                AddedSummon.Add(item.type);
                item.useTime /= 3;
                item.autoReuse = true;
            }
            if (!AddedSummon.Contains(item.type))
            {
                AddedSummon.Add(item.type);
                item.useTime /= 3;
                item.autoReuse = true;
            }
        }

        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }

    //Removes weapons that were given quick summon.
    public override void UpdateInventory(Item item, Player player)
    {
        if (!ToggleSummon.QuickSummonEnabled && AddedSummon != null)
        {
            if (AddedSummon.Contains(item.type))
            {
                AddedSummon.Remove(item.type);
                item.useTime *= 3;
                item.autoReuse = false;
            }
        }
    }
}