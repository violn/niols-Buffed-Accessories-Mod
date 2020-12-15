using References;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

//Handles the buffs given to the player
public class BuffPlayer : GlobalNPC
{
    //Hook that handles actions when the player is hurt
    public override void OnHitPlayer(NPC npc, Player player, int damage, bool crit)
    {
        //Adds the honey buff when a bee accessory is equipped
        if (Reference.equippedBee)
        {
            player.AddBuff(BuffID.Honey, 480, true);
        }

        //Adds the enhanced mana regeneration buff when a star item is equipped
        if (Reference.equippedStar)
        {
            player.AddBuff(ModContent.BuffType<niolsBuffedAccessories.Buffs.EnhancedManaRegen>(), 480, true);
        }
    }
}
