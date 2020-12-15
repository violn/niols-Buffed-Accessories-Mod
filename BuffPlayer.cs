using References;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class BuffPlayer : GlobalNPC
{
    public override void OnHitPlayer(NPC npc, Player player, int damage, bool crit)
    {
        if (Reference.equippedBee)
        {
            player.AddBuff(BuffID.Honey, 480, true);
        }
        if (Reference.equippedStar)
        {
            player.AddBuff(ModContent.BuffType<niolsBuffedAccessories.Buffs.EnhancedManaRegen>(), 480, true);
        }
    }
}