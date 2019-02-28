using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;

namespace Arcanum
{

    public class ArcanumPlayer : ModPlayer
    {
        public bool AnemosHeld;

        public bool AquaHeld;

        public bool CryoHeld;

        public bool FosHeld;

        public bool GeoHeld;

        public bool HerbaHeld;

        public bool OmbraHeld;

        public bool PyroHeld;

        public bool Shadowflame;

        public bool GeoSet;

        public bool AnemosSet;

        public override void PostUpdateBuffs()
        {
            Item heldItem = player.HeldItem;
            WeaponTypes[] weaponTypes = Arcanum.Instance.WeaponTypes;
            foreach (WeaponTypes weaponTypes2 in weaponTypes)
            {
                if (weaponTypes2.IDs.Contains(heldItem.type) && weaponTypes2.name == "Anemos")
                {
                    AnemosHeld = true;
                }
                if (weaponTypes2.IDs.Contains(heldItem.type) && weaponTypes2.name == "Aqua")
                {
                    AquaHeld = true;
                }
                if (weaponTypes2.IDs.Contains(heldItem.type) && weaponTypes2.name == "Cryo")
                {
                    CryoHeld = true;
                }
                if (weaponTypes2.IDs.Contains(heldItem.type) && weaponTypes2.name == "Fos")
                {
                    FosHeld = true;
                }
                if (weaponTypes2.IDs.Contains(heldItem.type) && weaponTypes2.name == "Geo")
                {
                    GeoHeld = true;
                }
                if (weaponTypes2.IDs.Contains(heldItem.type) && weaponTypes2.name == "Herba")
                {
                    HerbaHeld = true;
                }
                if (weaponTypes2.IDs.Contains(heldItem.type) && weaponTypes2.name == "Ombra")
                {
                    OmbraHeld = true;
                }
                if (weaponTypes2.IDs.Contains(heldItem.type) && weaponTypes2.name == "Pyro")
                {
                    PyroHeld = true;
                }
            }
        }

        public override void ResetEffects()
        {
            AnemosHeld = false;
            AquaHeld = false;
            CryoHeld = false;
            FosHeld = false;
            GeoHeld = false;
            HerbaHeld = false;
            OmbraHeld = false;
            PyroHeld = false;
            Shadowflame = false;
        }

        public override void UpdateDead()
        {
            AnemosHeld = false;
            AquaHeld = false;
            CryoHeld = false;
            FosHeld = false;
            GeoHeld = false;
            HerbaHeld = false;
            OmbraHeld = false;
            PyroHeld = false;
            Shadowflame = false;
        }

        public override float UseTimeMultiplier(Item item)
        {
            if (GeoSet)
            {
                return 0.75f;
            }
            if (AnemosSet)
            {
                return 1.3f;
            }
            return 1f;
        }

        public override float MeleeSpeedMultiplier(Item item)
        {
            if (GeoSet)
            {
                return 1f;
            }
            if (AnemosSet)
            {
                return 1.3f;
            }
            return 1f;
        }

    }

}