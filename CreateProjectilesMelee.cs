﻿using niolsBuffedAccessories.Configs;
using Terraria;
using Terraria.ModLoader;

namespace niolsBuffedAccessories.Buffed
{
    public class CreateProjectilesMelee : GlobalItem
    {
        public override void ModifyHitNPC(Item item, Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            if (AccessoryProperties.EquippedBee && ModContent.GetInstance<Config>().Bee && CreateProjectiles.SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
            {
                if (AccessoryProperties.EquippedHive && BuffedAccessories.Ran.Next(100) < 50)
                {
                    SpawnProjectiles.CreateBees(target, damage, true, player.GetSource_ItemUse(item));
                }
                else SpawnProjectiles.CreateBees(target, damage, false, player.GetSource_ItemUse(item));
            }

            if (AccessoryProperties.EquippedStar && ModContent.GetInstance<Config>().Star && CreateProjectiles.SpawnProjectile(Main.LocalPlayer.HeldItem.useTime))
            {
                SpawnProjectiles.CreateStars(target, damage, player.GetSource_ItemUse(item));
            }
        }
    }
}