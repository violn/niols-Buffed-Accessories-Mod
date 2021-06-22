using Microsoft.Xna.Framework;
using niolsBuffedAccessories;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class SpawnProjectiles : GlobalProjectile
{
    public static int BeesSpawned = 0;
    public static int StarsSpawned = 0;

    public static void CreateWeakBees(NPC target, int damage)
    {
        if (BeesSpawned <= 25)
        {
            Projectile.NewProjectile(
            target.position.X + BuffedAccessories.ran.Next(-10, 10),
            target.position.Y + BuffedAccessories.ran.Next(-10, -5),
            BuffedAccessories.ran.Next(-15, 15),
            BuffedAccessories.ran.Next(-15, -2),
            ProjectileID.Bee,
            (int)(damage * .225f + 1f),
            0f,
            Main.myPlayer,
            0f,
            0f);

            BeesSpawned++;
            Timers.beeTimer = 0;
        }
    }

    public static void CreateStrongBees(NPC target, int damage)
    {
        if (BeesSpawned <= 25)
        {
            Projectile.NewProjectile(
            target.position.X + BuffedAccessories.ran.Next(-10, 10),
            target.position.Y + BuffedAccessories.ran.Next(-10, -5),
            BuffedAccessories.ran.Next(-15, 15),
            BuffedAccessories.ran.Next(-15, -2),
            ProjectileID.GiantBee,
            (int)(damage * .325f + 1f),
            .5f,
            Main.myPlayer,
            0f,
            0f);

            BeesSpawned++;
            Timers.beeTimer = 0;
        }
    }

    public static void CreatePlagueBees(NPC target, int damage)
    {
        if (BeesSpawned <= 25)
        {
            Projectile.NewProjectile(
            target.position.X + BuffedAccessories.ran.Next(-10, 10),
            target.position.Y + BuffedAccessories.ran.Next(-10, -5),
            BuffedAccessories.ran.Next(-15, 15),
            BuffedAccessories.ran.Next(-15, -2),
            BuffedAccessories.calamity.ProjectileType("PlaguenadeBee"),
            (int)(damage * .40f + 1f),
            .5f,
            Main.myPlayer,
            0f,
            0f);

            BeesSpawned++;
            Timers.beeTimer = 0;
        }
    }

    public static void CreateStars(NPC target, int damage)
    {
        Player player = Main.LocalPlayer;
        float targetXOffSet = BuffedAccessories.ran.Next(-350, 350);
        float xVelocity = targetXOffSet * (-1f / 35f);

        if (StarsSpawned <= 35)
        {
            Projectile.NewProjectile(
            target.position.X + targetXOffSet,
            player.position.Y - 700f,
            xVelocity,
            20f,
            ProjectileID.HallowStar,
            (int)(damage * .80f + 1f),
            1f,
            Main.myPlayer,
            0f,
            0f);

            StarsSpawned++;
            Timers.starTimer = 0;
        }
    }

    public static void CreateDuplicate(int type, Vector2 position, float speedX, float speedY, int damage, float knockBack, int amount)
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

            Projectile.NewProjectile(
            position.X,
            position.Y,
            speedX + projOffestSpeedX,
            speedY + projOffsetSpeedY,
            type,
            (int)(damage * .75f),
            knockBack,
            Main.myPlayer,
            0f,
            0f);
        }
    }
}
