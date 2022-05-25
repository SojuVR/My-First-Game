using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_First_Game.Content;

namespace My_First_Game.Content.Player
{
    public class Player
    {

        public static string Naming()
        {
            Util.Util.wl("\nWhat is your name?");
            string playername = Util.Util.rl();
            return playername;
        }
        public static void ReadAttributes()
        {
            Util.Util.wl("\nYour Attributes are:");
            Util.Util.wl("Strength: " + PlayerStrength);
            Util.Util.wl("Intellect: " + PlayerIntellect);
            Util.Util.wl("Stealth: " + PlayerStealth);
            Util.Util.wl("Agility: " + PlayerAgility);
            Util.Util.wl("Luck: " + PlayerLuck);
        }

        public static string playername
        {
            get
            {
                return Naming();
            }
            set
            {
                playername = value;
            }
        }
        public static string PlayerName = playername;
        public static int PlayerStrength
        {
            get
            {
                return PlayerAttributes.Strength;
            }
            set
            {
                PlayerStrength = value;
            }
        }
        public static int PlayerIntellect
        {
            get
            {
                return PlayerAttributes.Intellect;
            }
            set
            {
                PlayerIntellect = value;
            }
        }
        public static int PlayerStealth
        {
            get
            {
                return PlayerAttributes.Stealth;
            }
            set
            {
                PlayerStealth = value;
            }
        }
        public static int PlayerAgility
        {
            get
            {
                return PlayerAttributes.Agility;
            }
            set
            {
                PlayerAgility = value;
            }
        }
        public static int PlayerLuck
        {
            get
            {
                return PlayerAttributes.Luck;
            }
            set
            {
                PlayerLuck = value;
            }
        }

    }
}
