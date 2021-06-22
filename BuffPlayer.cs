using niolsBuffedAccessories.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class BuffPlayerHurt : GlobalNPC
{
    public override void OnHitPlayer(NPC npc, Player player, int damage, bool crit)
    {
        if (AccessoryProperties.equippedBee)
        {
            player.AddBuff(BuffID.Honey, 480, true);
        }

        if (AccessoryProperties.equippedStar)
        {
            player.AddBuff(ModContent.BuffType<EnhancedManaRegen>(), 480, true);
        }
    }
}

public class BuffPlayerBeserkerRageProj : ModPlayer
{
    public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
    {
        if (AccessoryProperties.equippedWarriorEmblem && proj.melee && target.life < damage)
        {
            player.AddBuff(ModContent.BuffType<BeserkerRage>(), 340, true);
        }
    }
}

public class BuffPlayerBeserkerRageMelee : GlobalItem
{
    public override void ModifyHitNPC(Item item, Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
    {
        if (AccessoryProperties.equippedWarriorEmblem && target.life < damage)
        {
            player.AddBuff(ModContent.BuffType<BeserkerRage>(), 340, true);
        }
    }
}
