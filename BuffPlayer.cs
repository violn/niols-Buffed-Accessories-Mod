using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using niolsBuffedAccessories.Buffs;

public class BuffPlayerHurt : GlobalNPC
{
    public override void OnHitPlayer(NPC npc, Player player, int damage, bool crit)
    {
        //Gives the player the honeybuff on taking damage.
        if (AccessoryProperties.equippedBee)
        {
            player.AddBuff(BuffID.Honey, 480, true);
        }

        //Gives the player the enhanced mana regen on taking damage.
        if (AccessoryProperties.equippedStar)
        {
            player.AddBuff(ModContent.BuffType<EnhancedManaRegen>(), 480, true);
        }
    }
}

public class BuffPlayerDamageProj: ModPlayer
{
    public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
    {
        //Gives Beserker Rage buff when killing an NPC with a melee projectile.
        if (AccessoryProperties.equippedFireGauntlet)
        {
            BeserkerRage.beserkerRageStrength = 3;
        }
        else if (AccessoryProperties.equippedMechGlove)
        {
            BeserkerRage.beserkerRageStrength = 2;
        }
        else if (AccessoryProperties.equippedWarriorEmblem)
        {
            BeserkerRage.beserkerRageStrength = 1;
        }

        if ((AccessoryProperties.equippedMechGlove ||
            AccessoryProperties.equippedFireGauntlet ||
            AccessoryProperties.equippedWarriorEmblem) &&
            proj.melee &&
            target.life < damage)
        {
            player.AddBuff(ModContent.BuffType<BeserkerRage>(), 340, true);
        }
    }
}

public class BuffPlayerDamageMelee : GlobalItem
{
    //Gives Beserker Rage buff when killing an NPC with a melee attack.
    public override void ModifyHitNPC(Item item, Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
    {
        if (AccessoryProperties.equippedFireGauntlet)
        {
            BeserkerRage.beserkerRageStrength = 3;
        }
        else if (AccessoryProperties.equippedMechGlove)
        {
            BeserkerRage.beserkerRageStrength = 2;
        }
        else if (AccessoryProperties.equippedWarriorEmblem)
        {
            BeserkerRage.beserkerRageStrength = 1;
        }

        if ((AccessoryProperties.equippedMechGlove ||
            AccessoryProperties.equippedFireGauntlet ||
            AccessoryProperties.equippedWarriorEmblem) &&
            target.life < damage)
        {
            player.AddBuff(ModContent.BuffType<BeserkerRage>(), 340, true);
        }
    }
}
