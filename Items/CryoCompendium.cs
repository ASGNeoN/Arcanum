//using Arcanum.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Arcanum.Items
{
    public class CryoCompendium : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cryo Compendium");
            Tooltip.SetDefault("Read it to see what spells are " + "[c/00B0B0:Cryo] based");
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
          //  Main.NewText("List of all [c/00B0B0:Cryo] based vanilla prehardmode spells: " + string.Format("[i:{0}][i:{1}][i:{2}]", ItemID.SapphireStaff, ItemID.WaterBolt, ItemID.AquaScepter));
            if (Main.hardMode == true)
            {
                Main.NewText("List of all [c/00B0B0:Cryo] based vanilla hardmode spells: " + string.Format("[i:{0}][i:{1}][i:{2}][i:{3}]", ItemID.IceRod, ItemID.FrostStaff, ItemID.FlowerofFrost, ItemID.BlizzardStaff));
            }

            return true;
        }
    }
}