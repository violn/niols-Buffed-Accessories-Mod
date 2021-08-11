using Terraria.DataStructures;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class CrossNecklace : ModPlayer
    {
        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            if (AccessoryProperties.equippedCrossNecklace && BuffedAccessories.ran.Next(100) < 6)
            {
                damage = Player.statLife - 1;
            }
            return base.PreHurt(pvp, quiet, ref damage, ref hitDirection, ref crit, ref customDamage, ref playSound, ref genGore, ref damageSource);
        }
    }
}