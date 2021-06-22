using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

public class PygmyPreHardmode : GlobalNPC
{
    public override void SetupShop(int type, Chest shop, ref int nextSlot)
    {
        if (type == NPCID.WitchDoctor)
        {
            shop.item[nextSlot].SetDefaults(ItemID.PygmyNecklace);
            nextSlot++;
        }
    }
}
