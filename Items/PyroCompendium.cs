//using Arcanum.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Arcanum.Items
{
    public class PyroCompendium : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pyro Compendium");
            Tooltip.SetDefault("Read it to see what spells are " + "[c/F00000:Pyro] based");
        }

        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item29;
            item.useAnimation = 20;
            item.useTime = 20;
            item.useStyle = 5;
            item.maxStack = 1;
            item.consumable = false;
            item.width = 20;
            item.height = 22;
            item.value = Item.sellPrice(0, 1, 0, 0);
            item.rare = 3;
        }

        public override bool UseItem(Player player)
        {
            Main.NewText("List of all [c/F00000:Pyro] based vanilla prehardmode spells: " + string.Format("[i:{0}][i:{1}][i:{2}][i:{3}]", ItemID.WandofSparking, ItemID.RubyStaff, ItemID.Flamelash, ItemID.FlowerofFire));
            if (Main.hardMode == true)
            {
                Main.NewText("List of all [c/F00000:Pyro] based vanilla hardmode spells: " + string.Format("[i:{0}][i:{1}][i:{2}][i:{3}][i:{4}][i:{5}]", ItemID.MeteorStaff, ItemID.SoulDrain, ItemID.CursedFlames, ItemID.ClingerStaff, ItemID.InfernoFork, ItemID.ApprenticeStaffT3));
            }
            return true;
        }
    }
}