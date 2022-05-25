// See https://aka.ms/new-console-template for more information
using My_First_Game.Content;
using My_First_Game.Content.Util;
using My_First_Game.Content.Player;
using My_First_Game.Content.EnemyThing;
using My_First_Game.Content.Encounter;

Util.wl("The Backrooms\n");

Util.wl("Hello, " + Player.PlayerName + ", let's learn a little bit more about you.\n");

PlayerAttributes.playerattributes();

Util.wl(Player.PlayerName + " is running with a strength of " + Player.PlayerStrength + ".");

Player.ReadAttributes();

Encounter.StealthEncounter();

while (Util.InputAndRespond() != "exit game")
{
    Util.InputAndRespond();
    if (Util.InputAndRespond() == "exit game")
    {
        Environment.Exit(0);
    }
}