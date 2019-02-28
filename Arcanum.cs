using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Arcanum;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
namespace Arcanum
{
    class Arcanum : Mod
    {

        public Arcanum()
        {

    }
        public static WeaponTypes[] weaponTypes;
        Mod NeoNGhost = ModLoader.GetMod("NeoNGhost");
        public override void PostAddRecipes()
        {
            WeaponTypes[] array = new WeaponTypes[9];

            #region Anemos
            WeaponTypes[] array2 = array;
            Color lightBlue = Color.LightBlue;
            int[] array3 = new int[10]
            {
            0,
            0,
            ItemID.BlizzardStaff,
            ItemID.RazorbladeTyphoon,
            ItemID.MagicalHarp,
            ItemID.SkyFracture,
            ItemID.BookStaff,
            ItemID.DiamondStaff,
            ItemID.NimbusRod,
            ItemID.CrimsonRod
            };
            //    array3[0] = this.get_mod().ItemType("EDiamondStaff");
            //  array3[1] = this.get_mod().ItemType("RainStaff");
            array2[0] = new WeaponTypes("Anemos", lightBlue, array3);
            #endregion

            #region Aqua
            WeaponTypes[] array4 = array;
            Color colors = new Color(0, 128, 255);
            int[] array5 = new int[6]
            {
            ItemID.AquaScepter,
            ItemID.BubbleGun,
            ItemID.NimbusRod,
            ItemID.SapphireStaff,
            ItemID.WaterBolt,
            ItemID.RazorbladeTyphoon
            };
            // array5[0] = ModLoader.GetMod("ThoriumMod").ItemType("Blizzard");
            array4[1] = new WeaponTypes("Aqua", colors, array5);
            #endregion

            #region Cryo
            array[2] = new WeaponTypes("Cryo", Color.Cyan, new int[4]
            {
            ItemID.FrostStaff,
            ItemID.BlizzardStaff,
            ItemID.FlowerofFrost,
            ItemID.IceRod,
            });
            WeaponTypes[] array6 = array;
            #endregion

            #region Fos
            Color yellow = Color.Yellow;
            int[] array7 = new int[20]
            {
            0,
            ItemID.SpaceGun,
            ItemID.LaserRifle,
            ItemID.ChargedBlasterCannon,
            ItemID.CrystalSerpent,
            ItemID.CrystalStorm,
            ItemID.HeatRay,
            ItemID.LaserMachinegun,
            ItemID.LastPrism,
            ItemID.LunarFlareBook,
            ItemID.MagicDagger,
            ItemID.MagicMissile,
            ItemID.MagnetSphere,
            ItemID.MedusaHead,
            ItemID.RainbowRod,
            ItemID.RainbowGun,
            ItemID.SkyFracture,
            ItemID.TopazStaff,
            ItemID.CrystalVileShard,
            ItemID.SpectreStaff
            };
            //  array7[0] = this.get_mod().ItemType("ETopazStaff");
            array6[3] = new WeaponTypes("Fos", yellow, array7);
            #endregion

            #region Geo
            WeaponTypes[] array8 = array;
            Color colors2 = new Color(146, 88, 46);
            int[] array9 = new int[4]
            {
            0,
            ItemID.AmberStaff,
            ItemID.MeteorStaff,
            ItemID.StaffofEarth
            };
            //  array9[0] = this.get_mod().ItemType("BoulderStaff");
            array8[4] = new WeaponTypes("Geo", colors2, array9);
            #endregion

            #region Herba
            WeaponTypes[] array10 = array;
            Color green = Color.Green;
            int[] array11 = new int[12]
            {
            0,
            0,
            ItemID.LeafBlower,
            ItemID.EmeraldStaff,
            ItemID.NettleBurst,
            ItemID.Razorpine,
            ItemID.ToxicFlask,
            ItemID.Vilethorn,
            ItemID.BeeGun,
            ItemID.WaspGun,
            ItemID.VenomStaff,
            ItemID.PoisonStaff
            };
            //    array11[0] = this.get_mod().ItemType("EEmeraldStaff");
            //    array11[1] = this.get_mod().ItemType("PetalStaff");
            array10[5] = new WeaponTypes("Herba", green, array11);

            if (NeoNGhost != null)
            {
                WeaponTypes[] array16 = array;
                int[] array17 = new int[2]
                {
                       0,
                       0,
                };
                array17[0] = ModLoader.GetMod("NeoNGhost").ItemType("CarrotStaff");
                array17[1] = ModLoader.GetMod("NeoNGhost").ItemType("AgateStaff");

                array16[8] = new WeaponTypes("Herba", green, array17);
            }
            #endregion

            #region Ombra
            WeaponTypes[] array12 = array;
            Color purple = Color.Purple;
            int[] array13 = new int[17]
            {
            0,
            ItemID.AmethystStaff,
            ItemID.BatScepter,
            ItemID.BookofSkulls,
            ItemID.ClingerStaff,
            ItemID.CrimsonRod,
            ItemID.CursedFlames,
            ItemID.DemonScythe,
            ItemID.GoldenShower,
            ItemID.SoulDrain,
            ItemID.NebulaArcanum,
            ItemID.NebulaBlaze,
            ItemID.ShadowbeamStaff,
            ItemID.ShadowFlameHexDoll,
            ItemID.SpectreStaff,
            ItemID.SpiritFlame,
            ItemID.UnholyTrident
            };
            //   array13[0] = this.get_mod().ItemType("EAmethystStaff");
            array12[6] = new WeaponTypes("Ombra", purple, array13);
            #endregion

            #region Pyro
            WeaponTypes[] array14 = array;
            Color red = Color.Red;
            int[] array15 = new int[11]
            {
            0,
            ItemID.ApprenticeStaffT3,
            ItemID.ClingerStaff,
            ItemID.HeatRay,
            ItemID.CursedFlames,
            ItemID.Flamelash,
            ItemID.FlowerofFire,
            ItemID.InfernoFork,
            ItemID.MeteorStaff,
            ItemID.RubyStaff,
            ItemID.WandofSparking
            };
            //     array15[0] = this.get_mod().ItemType("ERubyStaff");
            array14[7] = new WeaponTypes("Pyro", red, array15);
            weaponTypes = array;
            #endregion

        }

        public override void Unload()
        {
            weaponTypes = null;
        }
    }
}
