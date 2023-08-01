using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class CrossNecklace : ModPlayer
    {
        public override bool FreeDodge(Player.HurtInfo info)
        {
            if (AccessoryProperties.DeathPrevention && BuffedAccessories.Ran.Next(100) < 80 && info.Damage > Player.statLife)
            {
                return true;
            }

            return base.FreeDodge(info);
        }
    }
}