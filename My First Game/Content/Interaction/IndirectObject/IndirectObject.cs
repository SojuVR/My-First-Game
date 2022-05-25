using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Game.Content.Interaction.IndirectObject
{
    public class IndirectObject
    {
        public static object Hammer
        {
            get
            {
                return HammerDam();
            }
            set
            {
                Hammer = value;
            }
        }

        public static int HammerDam()
        {
            int Hammerdam = 10;
            return Hammerdam;
        }

        public static object Sledgehammer
        {
            get
            {
                return SledgehammerDam();
            }
            set
            {
                Sledgehammer = value;
            }
        }

        public static int SledgehammerDam()
        {
            int Sledgehammerdam = 10;
            return Sledgehammerdam;
        }
    }
}
