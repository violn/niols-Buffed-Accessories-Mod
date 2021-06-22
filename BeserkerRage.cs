using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffs
{
    public class BeserkerRage : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Beserker Rage");
            Description.SetDefault("Your melee abilities are increased.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.meleeCrit += 30;
            player.meleeDamage += .15f;
        }

        public override bool ReApply(Player player, int time, int buffIndex)
        {
            player.meleeCrit -= 30;
            player.meleeDamage -= .15f;
            player.meleeCrit += 30;
            player.meleeDamage += .15f;
            return false;
        }
    }
}
