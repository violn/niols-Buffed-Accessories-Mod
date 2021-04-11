using System;
using Terraria.DataStructures;
using Terraria.ModLoader;

//Gives a chance of death prevention when the cross necklace is equipped.
public class PreventDeath : ModPlayer
{
    public static Random ran = new Random();

    public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
    {
        if (damage > player.statLife && AccessoryProperties.EquippedCrossNecklace && ran.Next(100) < 10)
        {
            damage = player.statLife - 1;
        }

        return base.PreHurt(pvp, quiet, ref damage, ref hitDirection, ref crit, ref customDamage, ref playSound, ref genGore, ref damageSource);
    }
}