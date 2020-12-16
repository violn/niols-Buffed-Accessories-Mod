using Microsoft.Xna.Framework;
using References;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    //Handles projectile relate stuff
    public class ProjectileHandler : GlobalProjectile
    {
        public static readonly Random rand = new Random();
        
        //Hook that sets the default values of projectiles
        //This is used more to collect yoyo prjectiles
        public override void SetDefaults (Projectile proj)
        {
            bool dupe = false;
            if(Reference.yoyoProj.Count > 0)
            {
                foreach(Projectile yoyo in Reference.yoyoProj)
                {
                    if(yoyo.type == proj.type)
                    {
                        dupe = true;
                    }
                }
            }

            if(proj.aiStyle == 99 && !Reference.countweightBlackList.Contains(proj.type) && !dupe)
            {
                Reference.yoyoProj.Add(proj);
            }
        }

        public override void OnHitNPC(Projectile proj, NPC target, int damage, float knockback, bool crit)
        {
            if ((Reference.equippedStar && proj.type == ProjectileID.HallowStar) ||
                (Reference.equippedHive && proj.type == ProjectileID.GiantBee) ||
                (Reference.equippedBee && proj.type == ProjectileID.Bee) ||
                (Reference.equippedPlague && Reference.cal != null &&
                proj.type != Reference.cal.ProjectileType("PlaguenadeBee")))
            {
                proj.usesLocalNPCImmunity = true;
                proj.localNPCImmunity[target.whoAmI] = 10;
                target.immune[proj.owner] = 0;
            }
        }

        //Creates regular bees when called
        public static void CreateWeakBees(NPC target, int damage)
        {
            if (Reference.beesSpawned < 25)
            {
                Projectile.NewProjectile(
                target.position.X + rand.Next(-10, 10),
                target.position.Y + rand.Next(-10, -5),
                rand.Next(-15, 15),
                rand.Next(-15, -2),
                ProjectileID.Bee,
                (int)(damage * .45 + 1),
                0f,
                Main.myPlayer,
                0f,
                0f);

                Reference.beesSpawned++;
                Reference.secondsPassed = 0;
            }
        }
        
        //Creates stronge bees when called
        public static void CreateStrongBees(NPC target, int damage)
        {
            if (Reference.beesSpawned < 25)
            {
                Projectile.NewProjectile(
                target.position.X + rand.Next(-10, 10),
                target.position.Y + rand.Next(-10, -5),
                rand.Next(-15, 15),
                rand.Next(-15, -2),
                ProjectileID.GiantBee,
                (int)(damage * .65 + 1),
                .5f,
                Main.myPlayer,
                0f,
                0f);

                Reference.beesSpawned++;
                Reference.secondsPassed = 0;
            }
        }

        //Creates plague bees when called
        public static void CreatePlagueBees(NPC target, int damage)
        {
            if (Reference.beesSpawned < 25)
            {
                Projectile.NewProjectile(
                target.position.X + rand.Next(-10, 10),
                target.position.Y + rand.Next(-10, -5),
                rand.Next(-15, 15),
                rand.Next(-15, -2),
                Reference.cal.ProjectileType("PlaguenadeBee"),
                (int)(damage * .80 + 1),
                .5f,
                Main.myPlayer,
                0f,
                0f);

                Reference.beesSpawned++;
                Reference.secondsPassed = 0;
            }
        }

        //Creates stars that spawns from the sky
        public static void CreateStars(NPC target, int damage)
        {
            Player player = Main.LocalPlayer;
            float targetXOffSet = rand.Next(-350, 350);
            float xVelocity = targetXOffSet * -1 / 35;

            if (Reference.starsSpawned < 34)
            {
                Projectile.NewProjectile(
                target.position.X + targetXOffSet,
                player.position.Y - 700f,
                xVelocity,
                20f,
                ProjectileID.HallowStar,
                (int)(damage * .80 + 1),
                1f,
                Main.myPlayer,
                0f,
                0f);

                Reference.starsSpawned++;
                Reference.secondsPassed2 = 0;
            }
        }

        //Creates a clone of the projectile shot
        public static void CreateDuplicate(int type, Vector2 position, float speedX, float speedY, int damage, float knockBack)
        {
            float projOffsetSpeedY = 0;
            float projOffestSpeedX = 0;
            while (projOffsetSpeedY == 0 && projOffestSpeedX == 0)
            {
                projOffsetSpeedY = rand.Next(-1, 1);
                projOffestSpeedX = rand.Next(-1, 1);
            }

            Projectile.NewProjectile(
            position.X,
            position.Y,
            speedX + projOffestSpeedX,
            speedY + projOffsetSpeedY,
            type,
            damage,
            knockBack,
            Main.myPlayer,
            0f,
            0f);
        }
    }
}
