using Terraria.DataStructures;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class CrossNecklace : ModPlayer
    {
        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource, ref int cooldownCounter)
        {
            if (AccessoryProperties.DeathPrevention && BuffedAccessories.Ran.Next(100) < 5 && damage > Player.statLife)
            {
                if (Player.statLife == 1)
                {
                    return false;
                }

                damage = Player.statLife - 1;
            }

            return base.PreHurt(pvp, quiet, ref damage, ref hitDirection, ref crit, ref customDamage, ref playSound, ref genGore, ref damageSource, ref cooldownCounter);
        }
    }
}