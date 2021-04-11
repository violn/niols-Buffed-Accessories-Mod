using Microsoft.Xna.Framework;
using niolsBuffedAccessories;
using System;
using System.Collections;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class ProjectileHandler : GlobalProjectile
{
    public static readonly Random rand = new Random();
    public static ArrayList YoyoProj = new ArrayList();
    public static int BeesSpawned = 0;
    public static int StarsSpawned = 0;

    //Gets a list of yoyo projectiles.
    public override void SetDefaults(Projectile proj)
    {
        bool dupe = false;
        if (YoyoProj.Count > 0)
        {
            foreach (Projectile yoyo in YoyoProj)
            {
                if (yoyo.type == proj.type)
                {
                    dupe = true;
                }
            }
        }

        if (proj.aiStyle == 99 && !BuffedAccessories.countweightBlackList.Contains(proj.type) && !dupe)
        {
            YoyoProj.Add(proj);
        }
    }

    //Removes the immunity frames of enemies when hit by bees.
    public override void OnHitNPC(Projectile proj, NPC target, int damage, float knockback, bool crit)
    {
        if ((proj.sentry || proj.minion) && AccessoryProperties.equippedPygmyNecklace)
        {
            proj.usesLocalNPCImmunity = true;
            proj.localNPCImmunity[target.whoAmI] = 10;
            target.immune[proj.owner] = 0;
        }

        if ((AccessoryProperties.equippedStar && proj.type == ProjectileID.HallowStar) ||
            (AccessoryProperties.equippedHive && proj.type == ProjectileID.GiantBee) ||
            (AccessoryProperties.equippedBee && proj.type == ProjectileID.Bee) ||
            (AccessoryProperties.equippedPlagueHive && BuffedAccessories.calamity != null &&
            proj.type != BuffedAccessories.calamity.ProjectileType("PlaguenadeBee")))
        {
            proj.usesLocalNPCImmunity = true;
            proj.localNPCImmunity[target.whoAmI] = 10;
            target.immune[proj.owner] = 0;
        }
    }

    /// <summary>
    /// Creates regular bees.
    /// Bee count is capped at 25 so they don't stop stuff from spawning.
    /// </summary>
    /// <param name="target">The target hit.</param>
    /// <param name="damage">The damage of the bee creation source.</param>
    public static void CreateWeakBees(NPC target, int damage)
    {
        if (BeesSpawned <= 25)
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

            BeesSpawned++;
            Counter.SecondsPassed = 0;
        }
    }

    /// <summary>
    /// Creates strong bees.
    /// Bee count is capped at 25 so they don't stop stuff from spawning.
    /// </summary>
    /// <param name="target">The target hit.</param>
    /// <param name="damage">The damage of the bee creation source.</param>
    public static void CreateStrongBees(NPC target, int damage)
    {
        if (BeesSpawned <= 25)
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

            BeesSpawned++;
            Counter.SecondsPassed = 0;
        }
    }

    /// <summary>
    /// Creates plague bees from the Calamity mod.
    /// Bee count capped at 25 so they don't stop stuff from spawning.
    /// </summary>
    /// <param name="target">The target hit.</param>
    /// <param name="damage">The damage of the bee creation source.</param>
    public static void CreatePlagueBees(NPC target, int damage)
    {
        if (BeesSpawned <= 25)
        {
            Projectile.NewProjectile(
            target.position.X + rand.Next(-10, 10),
            target.position.Y + rand.Next(-10, -5),
            rand.Next(-15, 15),
            rand.Next(-15, -2),
            BuffedAccessories.calamity.ProjectileType("PlaguenadeBee"),
            (int)(damage * .80 + 1),
            .5f,
            Main.myPlayer,
            0f,
            0f);

            BeesSpawned++;
            Counter.SecondsPassed = 0;
        }
    }

    /// <summary>
    /// Creates stars.
    /// Number of stars created is capped at 35 so they don't stop stuff from spawning.
    /// </summary>
    /// <param name="target">The target hit.</param>
    /// <param name="damage">The damage of the bee creation source</param>
    public static void CreateStars(NPC target, int damage)
    {
        Player player = Main.LocalPlayer;
        float targetXOffSet = rand.Next(-350, 350);
        float xVelocity = targetXOffSet * -1 / 35;

        if (StarsSpawned <= 35)
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

            StarsSpawned++;
            Counter.SecondsPassed2 = 0;
        }
    }

    /// <summary>
    /// Creates a duplicate of a projectile.
    /// </summary>
    /// <param name="type">The original projectile's ID.</param>
    /// <param name="position">The position it should spawn from.</param>
    /// <param name="speedX">The horizontal speed of the original projectile.</param>
    /// <param name="speedY">The vertical speed of the original projectile.</param>
    /// <param name="damage">The damage of the original projectile.</param>
    /// <param name="knockBack">The knockback of the original projectile.</param>
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
