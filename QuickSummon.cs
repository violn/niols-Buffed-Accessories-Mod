using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;

public class QuickSummon : GlobalItem
{
    public static List<int> AddedSummon = new List<int>();

    public override void OnConsumeMana(Item item, Player player, int manaConsumed)
    {
        if ((item.summon || item.sentry) && !item.autoReuse && ToggleSummon.QuickSummonEnabled)
        {
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
            if (!AddedSummon.Contains(item.type))
            {
                AddedSummon.Add(item.type);
                item.useTime /= 3;
                item.autoReuse = true;
            }
        }

        return base.Shoot(item, player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
    }

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

public class ToggleSummon : ModPlayer
{
    public static bool QuickSummonEnabled = false;
    public static ModHotKey toggleQuickSummon;

    public override void ProcessTriggers(TriggersSet triggersSet)
    {
        if (toggleQuickSummon.JustPressed)
        {
            if (!QuickSummonEnabled)
            {
                QuickSummonEnabled = true;
                Main.NewText("Quick summon enabled");
            }
            else
            {
                QuickSummonEnabled = false;
                Main.NewText("Quick summon disabled");
            }
        }
    }
}
