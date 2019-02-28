//using Arcanum.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.Localization;

namespace Arcanum.Items
{
    public class FosCompendium : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fos Compendium");
            Tooltip.SetDefault("Read it to see what spells are " + "[c/F0F000:Fos] based");
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
            Main.NewText("List of all [c/F0F000:Fos] based vanilla prehardmode spells: " + string.Format("[i:{0}][i:{1}][i:{2}]", ItemID.TopazStaff, ItemID.SpaceGun, ItemID.MagicMissile));
            if (Main.hardMode == true)
            {
                Main.NewText("List of all [c/F0F000:Fos] based vanilla hardmode spells: " + string.Format("[i:{0}][i:{1}][i:{2}][i:{3}][i:{4}][i:{5}][i:{6}][i:{7}][i:{8}][i:{9}][i:{10}][i:{11}][i:{12}][i:{13}][i:{14}][i:{15}]", ItemID.LaserRifle, ItemID.CrystalSerpent, ItemID.MedusaHead, ItemID.CrystalStorm, ItemID.MagicDagger, ItemID.CrystalVileShard, ItemID.SkyFracture, ItemID.RainbowRod, ItemID.SpectreStaff, ItemID.MagnetSphere, ItemID.RainbowGun, ItemID.HeatRay, ItemID.ChargedBlasterCannon, ItemID.LaserMachinegun, ItemID.LunarFlareBook, ItemID.LastPrism ));
            }
            return true;
        }
    }
}