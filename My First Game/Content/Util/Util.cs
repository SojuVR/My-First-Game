using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_First_Game.Content.Interaction.Action;
using My_First_Game.Content.Player;


namespace My_First_Game.Content.Util
{
    class Util
    {
        public static string InputAndRespond()
        {
            return Util.rl().ToLower();
        }
        public static void wl(string line)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(line);
        }

        public static void w(string line)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(line);
        }

        public static string rl()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            return Console.ReadLine();
        }

        public static int irl()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            int num = -1;
                while (num <= 0)
                {
                    try
                    {
                        num = Convert.ToInt32(Console.ReadLine());
                        return num;
                    }
                    catch (System.Exception)
                    {
                    Console.ForegroundColor = ConsoleColor.Red;

                        Random phrase = new Random();

                        int choosephrase = 0;

                        choosephrase = phrase.Next(1, 5);
                        switch (choosephrase)
                        {
                            case 1:
                                Console.WriteLine("Please type just a whole number.");
                                break;
                            case 2:
                                Console.WriteLine("I need just a whole number please.");
                                break;
                            case 3:
                                Console.WriteLine("Can you please use just a whole number?");
                                break;
                            case 4:
                                Console.WriteLine("I only want a whole number.");
                                break;
                        }
                    }
                }
                return num;
        }
    }
}
