using Terraria;
using Terraria.GameInput;
using Terraria.ModLoader;

//Toggles quick summon when hotkey is pressed.
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