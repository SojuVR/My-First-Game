using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_First_Game.Content.Encounter
{
    public class Encounter
    {
        public static void StealthEncounter()
        {
            Util.Util.wl("\nIt's near. If it could smell or see, it definitely would've caught you by now. No time to think. How will you get away?");
            Util.Util.rl();
            EnemyThing.EnemyThing.enemystealth();
            if (Player.Player.PlayerStealth >= EnemyThing.EnemyThing.enemystealth())
            {
                Util.Util.wl("You managed to sneak by.");
            }
            else
            {
                Util.Util.wl("It's too late.");
            }
        }
    }
}
