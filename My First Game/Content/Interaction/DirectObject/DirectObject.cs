using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Game.Content.Interaction.DirectObject
{
    public class DirectObject
    {
        public static object Door1
        {
            get
            {
                return Door1Health();
            }
            set
            {
                Door1 = value;
            }
        }

        public static object Door1Health()
        {
            int DoorHealth = 10;
            return DoorHealth;
        }
    }
}
