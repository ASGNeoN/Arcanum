using Terraria.ModLoader;
using Microsoft.Xna.Framework;
namespace Arcanum
{
    public class WeaponTypes
    {
        public string name;

        public Color color;

        public int[] IDs;

        public WeaponTypes(string names, Color colors, int[] IDss)
        {
            name = names;
            color = colors;
            IDs = IDss;
        }
    }
}