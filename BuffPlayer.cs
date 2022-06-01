using niolsBuffedAccessories.Buffs;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class BuffPlayerHurt : GlobalNPC
    {
        public override void OnHitPlayer(NPC npc, Player player, int damage, bool crit)
        {
            if (AccessoryProperties.SpawnStars)
            {
                player.AddBuff(ModContent.BuffType<EnhancedManaRegen>(), 480);
            }
        }
    }

    public class BuffBRProj : ModPlayer
    {
        public override void ModifyHitNPCWithProj(Projectile proj, NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection)
        {
            if (AccessoryProperties.BeserkerRage && proj.DamageType == DamageClass.Melee && target.life < damage)
            {
                Player.AddBuff(ModContent.BuffType<BeserkerRage>(), 340);
            }
        }
    }

    public class BuffBRMelee : GlobalItem
    {
        public override void ModifyHitNPC(Item item, Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            if (AccessoryProperties.BeserkerRage && target.life < damage)
            {
                player.AddBuff(ModContent.BuffType<BeserkerRage>(), 340, true);
            }
        }
    }
}