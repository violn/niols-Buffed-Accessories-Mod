using Terraria;
using Terraria.ModLoader;

public class BeserkerRage : ModBuff
{
    /// <summary>
    /// Determines the strength of the beserker rage buff.
    /// Goes from 1 to 3 with 1 being the weakest and 3 being the strongest.
    /// The strength is determined by the cetain melee accessories.
    /// </summary>
    public static int beserkerRageStrength = 0;

    public override void SetDefaults()
    {
        DisplayName.SetDefault("Beserker Rage");
        Description.SetDefault("Your melee abilities are increased");
        Main.buffNoTimeDisplay[Type] = false;
        Main.debuff[Type] = false;
        canBeCleared = false;
    }

    public override void Update(Player player, ref int buffIndex)
    {
        switch (beserkerRageStrength)
        {
            case 1:
                player.meleeCrit += 75;
                player.meleeDamage += .30f;
                break;

            case 2:
                player.meleeCrit += 50;
                player.meleeDamage += .15f;
                break;

            case 3:
                player.meleeCrit += 25;
                player.meleeDamage += .8f;
                break;
        }
    }

    public override bool ReApply(Player player, int time, int buffIndex)
    {
        switch (beserkerRageStrength)
        {
            case 1:
                player.meleeCrit -= 75;
                player.meleeDamage -= .30f;

                player.meleeCrit += 75;
                player.meleeDamage += .30f;
                break;

            case 2:
                player.meleeCrit -= 50;
                player.meleeDamage -= .15f;

                player.meleeCrit += 50;
                player.meleeDamage += .15f;
                break;

            case 3:
                player.meleeCrit -= 25;
                player.meleeDamage -= .8f;

                player.meleeCrit += 25;
                player.meleeDamage += .8f;
                break;
        }

        return false;
    }
}
