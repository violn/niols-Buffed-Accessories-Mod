using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffs
{
    public class EnhancedManaRegen : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enhanced Mana Regeneration");
            Description.SetDefault("You're quickly regenerating mana.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
            CanBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.manaRegenBonus += 80;
            player.manaRegenDelayBonus += 10;
        }
    }
}
