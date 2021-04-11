using Terraria.ModLoader;
using Terraria;
using System.Collections;

//Adds flat damage when wearing a shackle or cuffs.
public class IncreaseItemStats : GlobalItem
{
    public static bool shackleBoostCheck = false;
    public static bool shackleBoostCheck2 = false;
    public static bool shackleBoostCheck3 = false;
    public static ArrayList moddedDamage = new ArrayList();
    public static ArrayList moddedDamage2 = new ArrayList();
    public static ArrayList moddedDamage3 = new ArrayList();

    public override void ModifyWeaponDamage(Item item, Player player, ref float add, ref float mult, ref float flat)
    {
        if (AccessoryProperties.equippedCCuffs && !shackleBoostCheck3)
        {
            for(int x = 0; x < player.inventory.Length; x++)
            {
                if(player.inventory[x].damage > 0 && player.inventory[x].magic)
                {
                    if(shackleBoostCheck2)
                    {
                        player.inventory[x].damage -= 3;
                    }

                    player.inventory[x].damage += 5;
                    shackleBoostCheck3 = true;
                    moddedDamage3.Add(player.inventory[x]);
                }
            }
        }

        else if (AccessoryProperties.equippedMCuffs && (!shackleBoostCheck2 && !shackleBoostCheck3))
        {
            for (int x = 0; x < player.inventory.Length; x++)
            {
                if (player.inventory[x].damage > 0 && player.inventory[x].magic)
                {
                    player.inventory[x].damage += 3;
                    shackleBoostCheck2 = true;
                    moddedDamage2.Add(player.inventory[x]);
                }
            }
        }

        if (AccessoryProperties.equippedShackle && !shackleBoostCheck)
        {
            for (int x = 0; x < player.inventory.Length; x++)
            {
                if (player.inventory[x].damage > 0)
                {
                    player.inventory[x].damage += 1;
                    shackleBoostCheck = true;
                    moddedDamage.Add(player.inventory[x]);
                }
            }
        }
    }
}