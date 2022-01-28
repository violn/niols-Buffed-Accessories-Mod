using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class NoAmmoConsumption : GlobalItem
    {
        public override bool CanConsumeAmmo(Item item, Player player)
        {
            int chance = 0;
            chance += AccessoryProperties.equippedRangerEmblem ? 10 : 0;
            chance += AccessoryProperties.equippedBuckler ? 2 : 0;

            return BuffedAccessories.ran.Next(101) > chance;
        }
    }
}