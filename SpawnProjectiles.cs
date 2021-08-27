using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace niolsBuffedAccessories
{
    public class SpawnProjectiles : GlobalProjectile
    {
        public static int beesSpawned = 0;
        public static int starsSpawned = 0;
        public static void CreateBees(NPC target, int damage, bool strong, IProjectileSource source)
        {
            if (beesSpawned <= 25)
            {
                Projectile.NewProjectileDirect
                    (source,
                    new(target.position.X + BuffedAccessories.ran.Next(-10, 10), target.position.Y + BuffedAccessories.ran.Next(-10, -5)),
                    new(BuffedAccessories.ran.Next(-15, 15), BuffedAccessories.ran.Next(-15, -2)),
                    strong ? ProjectileID.GiantBee : ProjectileID.Bee,
                    (int)((damage * (strong ? .325f : .225f)) + 1f),
                    strong ? .5f : 0f,
                    Main.myPlayer).usesLocalNPCImmunity = true;

                beesSpawned++;
                Timers.beeTimer = 0;
            }
        }

        public static void CreateStars(NPC target, int damage, IProjectileSource source)
        {
            Player player = Main.LocalPlayer;
            float targetXOffSet = BuffedAccessories.ran.Next(-350, 350);
            float xVelocity = targetXOffSet * (-1f / 35f);
            if (starsSpawned <= 35)
            {
                Projectile.NewProjectileDirect
                    (source,
                    new(target.position.X + targetXOffSet, player.position.Y - 700f),
                    new(xVelocity, 20f),
                    ProjectileID.StarCannonStar,
                    (int)((damage * .80f) + 1f),
                    1f,
                    Main.myPlayer).usesLocalNPCImmunity = true;
                starsSpawned++;
                Timers.starTimer = 0;
            }
        }

        public static void CreateDuplicate(int type, Vector2 position, float speedX, float speedY, int damage, float knockBack, int amount, IProjectileSource source)
        {
            for (int x = 0; x < amount; x++)
            {
                float projOffsetSpeedY = 0;
                float projOffestSpeedX = 0;
                while (projOffsetSpeedY == 0 && projOffestSpeedX == 0)
                {
                    projOffsetSpeedY = BuffedAccessories.ran.Next(-1, 1);
                    projOffestSpeedX = BuffedAccessories.ran.Next(-1, 1);
                }

                Projectile.NewProjectileDirect
                    (source,
                    new(position.X, position.Y),
                    new(speedX + projOffestSpeedX, speedY + projOffsetSpeedY),
                    type,
                    (int)((damage * .75f) + 1f),
                    knockBack,
                    Main.myPlayer).usesLocalNPCImmunity = true;
            }
        }
    }
}