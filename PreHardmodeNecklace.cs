using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

//Adds the Pygmy Necklace to the preharmode Witch Doctor.
public class PreHardmodeNecklace : GlobalNPC
{
    public override void SetupShop(int type, Chest shop, ref int nextSlot)
    {
        if(type == NPCID.WitchDoctor)
        {
            shop.item[nextSlot].SetDefaults(ItemID.PygmyNecklace);
        }
    }
}
