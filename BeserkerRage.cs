using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffs
{
    public class BeserkerRage : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Beserker Rage");
            Description.SetDefault("Your melee abilities are increased.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
            CanBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetDamage(DamageClass.Melee) += .15f;
            player.GetCritChance(DamageClass.Melee) += 30;
        }
    }
}