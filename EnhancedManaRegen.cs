using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffs
{
    //Handles things related to buffs added through mods
    public class EnhancedManaRegen : ModBuff
    {
        //Set the default values for the buff
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Enhanced Mana Regeneration");
            Description.SetDefault("You're quickly regenerating mana.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
            canBeCleared = false;
        }

        //Set the effects of the buff
        public override void Update(Player player, ref int buffIndex)
        {
            player.manaRegenBonus += 80;
            player.manaRegenDelayBonus += 10;
        }
    }
}
