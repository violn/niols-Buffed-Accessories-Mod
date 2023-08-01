using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class NoAmmoConsumption : GlobalItem
    {
        public override bool CanConsumeAmmo(Item weapon, Item ammo, Player player)
        {
            int chance = 0;
            chance += AccessoryProperties.RangedDupe ? 10 : 0;
            chance += AccessoryProperties.Huntress ? 2 : 0;

            return BuffedAccessories.Ran.Next(100) > chance;
        }
    }
}