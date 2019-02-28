using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Arcanum;
using System.Collections.Generic;
using Terraria.ID;

namespace Arcanum
{
	class Arcanum : Mod
	{
		public static Arcanum Instance { get; private set; }

		public WeaponTypes[] WeaponTypes { get; private set; }

		public Arcanum()
		{
			Instance = this;
		}

		public override void Unload()
		{
			Instance = null;
		}

		public override void PostAddRecipes()
		{
			List<WeaponTypes> list = new List<WeaponTypes>();

			#region Anemos
			List<int> anemosItems = new List<int>
			{
				//ItemType<EDiamondStaff>(),
				//ItemType<RainStaff>(),
				ItemID.BlizzardStaff,
				ItemID.RazorbladeTyphoon,
				ItemID.MagicalHarp,
				ItemID.SkyFracture,
				ItemID.BookStaff,
				ItemID.DiamondStaff,
				ItemID.NimbusRod,
				ItemID.CrimsonRod
			};
			list.Add(new WeaponTypes("Anemos", Color.LightBlue, anemosItems.ToArray()));
			#endregion

			#region Aqua
			List<int> aquaItems = new List<int>
			{
				ItemID.AquaScepter,
				ItemID.BubbleGun,
				ItemID.NimbusRod,
				ItemID.SapphireStaff,
				ItemID.WaterBolt,
				ItemID.RazorbladeTyphoon
			};
			Mod thorium = ModLoader.GetMod("ThoriumMod");
			if (thorium != null)
				aquaItems.Add(thorium.ItemType("Blizzard"));
			list.Add(new WeaponTypes("Aqua", new Color(0, 128, 255), aquaItems.ToArray()));
			#endregion

			#region Cryo
			list.Add(new WeaponTypes("Cryo", Color.Cyan, new int[]
			{
				ItemID.FrostStaff,
				ItemID.BlizzardStaff,
				ItemID.FlowerofFrost,
				ItemID.IceRod,
			}));
			#endregion

			#region Fos
			List<int> fosItems = new List<int>
			{
				//ItemType<ETopazStaff>(),
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
			list.Add(new WeaponTypes("Fos", Color.Yellow, fosItems.ToArray()));
			#endregion

			#region Geo
			List<int> geoItems = new List<int>
			{
				//ItemType<BoulderStaff>(),
				ItemID.AmberStaff,
				ItemID.MeteorStaff,
				ItemID.StaffofEarth
			};
			//  array9[0] = this.get_mod().ItemType("BoulderStaff");
			list.Add(new WeaponTypes("Geo", new Color(146, 88, 46), geoItems.ToArray()));
			#endregion

			#region Herba
			List<int> herbaItems = new List<int>
			{
				//ItemType<EEmeraldStaff>(),
				//ItemType<PetalStaff>(),
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
			Mod neon = ModLoader.GetMod("NeoNGhost");
			if (neon != null)
			{
				herbaItems.Add(neon.ItemType("CarrotStaff"));
				herbaItems.Add(neon.ItemType("AgateStaff"));
			}
			list.Add(new WeaponTypes("Herba", Color.Green, herbaItems.ToArray()));

			#endregion

			#region Ombra
			int[] ombraItems = new int[]
			{
				//ItemType<EAmethystStaff>(),
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
			list.Add(new WeaponTypes("Ombra", Color.Purple, ombraItems));
			#endregion

			#region Pyro
			int[] pyroItems = new int[]
			{
				//ItemType<ERubyStaff>(),
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
			list.Add(new WeaponTypes("Pyro", Color.Red, pyroItems));
			#endregion

			WeaponTypes = list.ToArray();
		}
	}
}
