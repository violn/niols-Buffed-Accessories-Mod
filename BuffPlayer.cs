using niolsBuffedAccessories.Buffs;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class BuffPlayerHurt : GlobalNPC
    {
        public override void OnHitPlayer(NPC npc, Player target, Player.HurtInfo hurtInfo)
        {
            if (AccessoryProperties.Band)
            {
                target.AddBuff(ModContent.BuffType<EnhancedManaRegen>(), 480);
            }

        }
    }

    public class BuffBRProj : ModPlayer
    {
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref NPC.HitModifiers modifiers)
        {
            if (AccessoryProperties.BeserkerRage && proj.DamageType == DamageClass.Melee && target.life < proj.damage)
            {
                Player.AddBuff(ModContent.BuffType<BeserkerRage>(), 340);
            }
        }
    }

    public class BuffBRMelee : GlobalItem
    {
        public override void OnHitNPC(Item item, Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            if (AccessoryProperties.BeserkerRage && target.life < damageDone)
            {
                player.AddBuff(ModContent.BuffType<BeserkerRage>(), 340, true);
            }
        }
    }
}