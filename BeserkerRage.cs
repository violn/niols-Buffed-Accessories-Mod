using References;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffs
{
    public class BeserkerRage : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Beserker Rage");
            Description.SetDefault("Your melee abilities are increased");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (Reference.buffCheck1 == 1)
            {
                player.meleeCrit += 75;
                player.meleeDamage += .30f;
            }
            else if (Reference.buffCheck2 == 1)
            {
                player.meleeCrit += 50;
                player.meleeDamage += .15f;
            }
            else if (Reference.buffCheck3 == 1)
            {
                player.meleeCrit += 25;
                player.meleeDamage += .8f;
            }
        }

        public override bool ReApply(Player player, int time, int buffIndex)
        {
            if (Reference.buffCheck1 == 1)
            {
                player.meleeCrit -= 75;
                player.meleeDamage -= .30f;

                player.meleeCrit += 75;
                player.meleeDamage += .30f;
            }
            else if (Reference.buffCheck2 == 1)
            {
                player.meleeCrit -= 50;
                player.meleeDamage -= .15f;

                player.meleeCrit += 50;
                player.meleeDamage += .15f;
            }
            else if (Reference.buffCheck3 == 1)
            {
                player.meleeCrit -= 25;
                player.meleeDamage -= .8f;

                player.meleeCrit += 25;
                player.meleeDamage += .8f;
            }

            return false;
        }
    }
}