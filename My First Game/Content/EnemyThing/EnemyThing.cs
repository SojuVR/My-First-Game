using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_First_Game.Content;
using My_First_Game.Content.Player;

namespace My_First_Game.Content.EnemyThing
{
    public class EnemyThing
    {
        public static int enemyintellect()
        {
            Random numintellect = new Random();
            int EnemyIntellect = numintellect.Next(1, 11);
            if (Player.Player.PlayerIntellect >= 10)
            {
                EnemyIntellect = numintellect.Next(1, (Player.Player.PlayerIntellect + 3));
            }
            return EnemyIntellect;
        }
        public static int enemystealth()
        {
            Random numstealth = new Random();
            int EnemyStealth = numstealth.Next(1, 11);
            if (Player.Player.PlayerStealth >= 10)
            {
                EnemyStealth = numstealth.Next(1, (Player.Player.PlayerStealth + 3));
            }
            return EnemyStealth;
        }
        public static int enemyagility()
        {
            Random numagility = new Random();
            int EnemyAgility = numagility.Next(1, 11);
            if (Player.Player.PlayerAgility >= 10)
            {
                EnemyAgility = numagility.Next(1, (Player.Player.PlayerAgility + 3));
            }
            return EnemyAgility;
        }
        public static int enemyluck()
        {
            Random numluck = new Random();
            int EnemyLuck = numluck.Next(1, 11);
            if (Player.Player.PlayerLuck >= 10)
            {
                EnemyLuck = numluck.Next(1, (Player.Player.PlayerLuck + 3));
            }
            return EnemyLuck;
        }
    }
}
