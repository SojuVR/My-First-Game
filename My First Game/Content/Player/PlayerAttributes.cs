using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using My_First_Game.Content;

namespace My_First_Game.Content.Player
{
    class PlayerAttributes
    {
        public static int Strength { get; set; }
        public static int Intellect { get; set; }
        public static int Stealth { get; set; }
        public static int Agility { get; set; }
        public static int Luck { get; set; }

        public static int attributepoints = 15;
        public static int basestrength = 2;
        public static int baseintellect = 2;
        public static int basestealth = 2;
        public static int baseagility = 2;
        public static int baseluck = 2;
        public static int strength = 0;
        public static int intellect = 0;
        public static int stealth = 0;
        public static int agility = 0;
        public static int luck = 0;
        public static int strength2 = 0;
        public static int intellect2 = 0;
        public static int stealth2 = 0;
        public static int agility2 = 0;
        public static int luck2 = 0;
        public static int playerattributes()
        {
            Util.Util.wl("Choose your attributes between strength, intellect, stealth, and luck. All attributes start at a base of 2.");


            Util.Util.wl("You have " + attributepoints + " points available:");

            while (attributepoints > 0)
            {
                Util.Util.w("\nStrength: ");
                strength = Util.Util.irl();
                while (strength < 0 || strength > attributepoints)
                {
                    if (strength < 0)
                    {
                        Util.Util.wl("Please type a positive integer. You cannot remove points.");
                        strength = Util.Util.irl();
                    }
                    else if (strength > attributepoints)
                    {
                        Util.Util.wl("You only have " + attributepoints + " points. Try again.");
                        strength = Util.Util.irl();
                    }
                }
                attributepoints = attributepoints - strength;
                if (attributepoints >= 1)
                {
                    Util.Util.wl("You have " + attributepoints + " points remaining.");
                }
                else if (attributepoints < 1)
                {
                    Util.Util.wl("You are out of points.\n");

                    Strength = (strength + basestrength);
                    Intellect = (intellect + baseintellect);
                    Stealth = (stealth + basestealth);
                    Agility = (agility + baseagility);
                    Luck = (luck + baseluck);

                    Util.Util.wl("Your Attributes are:");
                    Util.Util.wl("Strength: " + Strength);
                    Util.Util.wl("Intellect: " + Intellect);
                    Util.Util.wl("Stealth: " + Stealth);
                    Util.Util.wl("Agility: " + Agility);
                    Util.Util.wl("Luck: " + Luck);

                    Util.Util.wl("\nAre you satisfied with your selection? Selecting no will restart your attribute selection.\nYes/No");
                    string AttributeFinish = Util.Util.rl().ToLower();
                    while (AttributeFinish != "yes" && AttributeFinish != "no")
                    {
                        Util.Util.wl("\nPlease type yes or no.");
                        AttributeFinish = Util.Util.rl().ToLower();
                    }
                    if (AttributeFinish == "no")
                    {
                        Util.Util.wl("Restarting Attribute Selection.");
                        attributepoints = 15;
                        basestrength = 2;
                        baseintellect = 2;
                        basestealth = 2;
                        baseagility = 2;
                        baseluck = 2;
                        strength = 0;
                        intellect = 0;
                        stealth = 0;
                        agility = 0;
                        luck = 0;
                        continue;
                    }
                    else if (AttributeFinish == "yes")
                    {
                        break;
                    }
                }

                Util.Util.w("\nIntellect: ");
                intellect = Util.Util.irl();
                while (intellect < 0 || intellect > attributepoints)
                {
                    if (intellect < 0)
                    {
                        Util.Util.wl("Please type a positive integer. You cannot remove points.");
                        intellect = Util.Util.irl();
                    }
                    else if (intellect > attributepoints)
                    {
                        Util.Util.wl("You only have " + attributepoints + " points. Try again.");
                        intellect = Util.Util.irl();
                    }
                }
                attributepoints = attributepoints - intellect;
                if (attributepoints >= 1)
                {
                    Util.Util.wl("You have " + attributepoints + " points remaining.");
                }
                else if (attributepoints < 1)
                {
                    Util.Util.wl("You are out of points.\n");

                    Strength = (strength + basestrength);
                    Intellect = (intellect + baseintellect);
                    Stealth = (stealth + basestealth);
                    Agility = (agility + baseagility);
                    Luck = (luck + baseluck);

                    Util.Util.wl("Your Attributes are:");
                    Util.Util.wl("Strength: " + Strength);
                    Util.Util.wl("Intellect: " + Intellect);
                    Util.Util.wl("Stealth: " + Stealth);
                    Util.Util.wl("Agility: " + Agility);
                    Util.Util.wl("Luck: " + Luck);

                    Util.Util.wl("\nAre you satisfied with your selection? Selecting no will restart your attribute selection.\nYes/No");
                    string AttributeFinish = Util.Util.rl().ToLower();
                    while (AttributeFinish != "yes" && AttributeFinish != "no")
                    {
                        Util.Util.wl("\nPlease type yes or no.");
                        AttributeFinish = Util.Util.rl().ToLower();
                    }
                    if (AttributeFinish == "no")
                    {
                        Util.Util.wl("Restarting Attribute Selection.");
                        attributepoints = 15;
                        basestrength = 2;
                        baseintellect = 2;
                        basestealth = 2;
                        baseagility = 2;
                        baseluck = 2;
                        strength = 0;
                        intellect = 0;
                        stealth = 0;
                        agility = 0;
                        luck = 0;
                        continue;
                    }
                    else if (AttributeFinish == "yes")
                    {
                        break;
                    }
                }

                Util.Util.w("\nStealth: ");
                stealth = Util.Util.irl();
                while (stealth < 0 || stealth > attributepoints)
                {
                    if (stealth < 0)
                    {
                        Util.Util.wl("Please type a positive integer. You cannot remove points.");
                        stealth = Util.Util.irl();
                    }
                    else if (stealth > attributepoints)
                    {
                        Util.Util.wl("You only have " + attributepoints + " points. Try again.");
                        stealth = Util.Util.irl();
                    }
                }
                attributepoints = attributepoints - stealth;
                if (attributepoints >= 1)
                {
                    Util.Util.wl("You have " + attributepoints + " points remaining.");
                }
                else if (attributepoints < 1)
                {
                    Util.Util.wl("You are out of points.\n");

                    Strength = (strength + basestrength);
                    Intellect = (intellect + baseintellect);
                    Stealth = (stealth + basestealth);
                    Agility = (agility + baseagility);
                    Luck = (luck + baseluck);

                    Util.Util.wl("Your Attributes are:");
                    Util.Util.wl("Strength: " + Strength);
                    Util.Util.wl("Intellect: " + Intellect);
                    Util.Util.wl("Stealth: " + Stealth);
                    Util.Util.wl("Agility: " + Agility);
                    Util.Util.wl("Luck: " + Luck);

                    Util.Util.wl("\nAre you satisfied with your selection? Selecting no will restart your attribute selection.\nYes/No");
                    string AttributeFinish = Util.Util.rl().ToLower();
                    while (AttributeFinish != "yes" && AttributeFinish != "no")
                    {
                        Util.Util.wl("\nPlease type yes or no.");
                        AttributeFinish = Util.Util.rl().ToLower();
                    }
                    if (AttributeFinish == "no")
                    {
                        Util.Util.wl("Restarting Attribute Selection.");
                        attributepoints = 15;
                        basestrength = 2;
                        baseintellect = 2;
                        basestealth = 2;
                        baseagility = 2;
                        baseluck = 2;
                        strength = 0;
                        intellect = 0;
                        stealth = 0;
                        agility = 0;
                        luck = 0;
                        continue;
                    }
                    else if (AttributeFinish == "yes")
                    {
                        break;
                    }
                }

                Util.Util.w("\nAgility: ");
                agility = Util.Util.irl();
                while (agility < 0 || agility > attributepoints)
                {
                    if (agility < 0)
                    {
                        Util.Util.wl("Please type a positive integer. You cannot remove points.");
                        agility = Util.Util.irl();
                    }
                    else if (agility > attributepoints)
                    {
                        Util.Util.wl("You only have " + attributepoints + " points. Try again.");
                        agility = Util.Util.irl();
                    }
                }
                attributepoints = attributepoints - agility;
                if (attributepoints >= 1)
                {
                    Util.Util.wl("You have " + attributepoints + " points remaining.");
                }
                else if (attributepoints < 1)
                {
                    Util.Util.wl("You are out of points.\n");

                    Strength = (strength + basestrength);
                    Intellect = (intellect + baseintellect);
                    Stealth = (stealth + basestealth);
                    Agility = (agility + baseagility);
                    Luck = (luck + baseluck);

                    Util.Util.wl("Your Attributes are:");
                    Util.Util.wl("Strength: " + Strength);
                    Util.Util.wl("Intellect: " + Intellect);
                    Util.Util.wl("Stealth: " + Stealth);
                    Util.Util.wl("Agility: " + Agility);
                    Util.Util.wl("Luck: " + Luck);

                    Util.Util.wl("\nAre you satisfied with your selection? Selecting no will restart your attribute selection.\nYes/No");
                    string AttributeFinish = Util.Util.rl().ToLower();
                    while (AttributeFinish != "yes" && AttributeFinish != "no")
                    {
                        Util.Util.wl("\nPlease type yes or no.");
                        AttributeFinish = Util.Util.rl().ToLower();
                    }
                    if (AttributeFinish == "no")
                    {
                        Util.Util.wl("Restarting Attribute Selection.");
                        attributepoints = 15;
                        basestrength = 2;
                        baseintellect = 2;
                        basestealth = 2;
                        baseagility = 2;
                        baseluck = 2;
                        strength = 0;
                        intellect = 0;
                        stealth = 0;
                        agility = 0;
                        luck = 0;
                        continue;
                    }
                    else if (AttributeFinish == "yes")
                    {
                        break;
                    }
                }

                Util.Util.w("\nLuck: ");
                luck = Util.Util.irl();
                while (luck < 0 || luck > attributepoints)
                {
                    if (luck < 0)
                    {
                        Util.Util.wl("Please type a positive integer. You cannot remove points.");
                        luck = Util.Util.irl();
                    }
                    else if (luck > attributepoints)
                    {
                        Util.Util.wl("You only have " + attributepoints + " points. Try again.");
                        luck = Util.Util.irl();
                    }
                }
                attributepoints = attributepoints - luck;
                if (attributepoints >= 1)
                {
                    Util.Util.wl("You have " + attributepoints + " points remaining.");
                }
                else if (attributepoints < 1)
                {
                    Util.Util.wl("You are out of points.\n");

                    Strength = (strength + basestrength);
                    Intellect = (intellect + baseintellect);
                    Stealth = (stealth + basestealth);
                    Agility = (agility + baseagility);
                    Luck = (luck + baseluck);

                    Util.Util.wl("Your Attributes are:");
                    Util.Util.wl("Strength: " + Strength);
                    Util.Util.wl("Intellect: " + Intellect);
                    Util.Util.wl("Stealth: " + Stealth);
                    Util.Util.wl("Agility: " + Agility);
                    Util.Util.wl("Luck: " + Luck);

                    Util.Util.wl("\nAre you satisfied with your selection? Selecting no will restart your attribute selection.\nYes/No");
                    string AttributeFinish = Util.Util.rl().ToLower();
                    while (AttributeFinish != "yes" && AttributeFinish != "no")
                    {
                        Util.Util.wl("\nPlease type yes or no.");
                        AttributeFinish = Util.Util.rl().ToLower();
                    }
                    if (AttributeFinish == "no")
                    {
                        Util.Util.wl("Restarting Attribute Selection.");
                        attributepoints = 15;
                        basestrength = 2;
                        baseintellect = 2;
                        basestealth = 2;
                        baseagility = 2;
                        baseluck = 2;
                        strength = 0;
                        intellect = 0;
                        stealth = 0;
                        agility = 0;
                        luck = 0;
                        continue;
                    }
                    else if (AttributeFinish == "yes")
                    {
                        break;
                    }
                }

                if (attributepoints > 0)
                {
                    Util.Util.wl("\nYou still have " + attributepoints + " points remaining. Would you like to use them? This is the last opportunity.\nYes/No");
                    string AttributeResponse = Util.Util.rl().ToLower();
                    while (AttributeResponse != "yes" && AttributeResponse != "no")
                    {
                        Util.Util.wl("\nPlease type yes or no.");
                        AttributeResponse = Util.Util.rl().ToLower();
                    }
                    if (AttributeResponse == "no")
                    {
                        break;
                    }
                    else if (AttributeResponse == "yes")
                    {
                        Util.Util.wl("Let's go again!");

                        Util.Util.w("\nStrength: ");
                        strength2 = Util.Util.irl();
                        while (strength2 < 0 || strength2 > attributepoints)
                        {
                            if (strength2 < 0)
                            {
                                Util.Util.wl("Please type a positive integer. You cannot remove points.");
                                strength2 = Util.Util.irl();
                            }
                            else if (strength2 > attributepoints)
                            {
                                Util.Util.wl("You only have " + attributepoints + " points. Try again.");
                                strength2 = Util.Util.irl();
                            }
                        }
                        strength = strength2 + strength;
                        attributepoints = attributepoints - strength2;
                        if (attributepoints >= 1)
                        {
                            Util.Util.wl("You have " + attributepoints + " points remaining.");
                        }
                        else if (attributepoints < 1)
                        {
                            Util.Util.wl("You are out of points.\n");

                            Strength = (strength + basestrength);
                            Intellect = (intellect + baseintellect);
                            Stealth = (stealth + basestealth);
                            Agility = (agility + baseagility);
                            Luck = (luck + baseluck);

                            Util.Util.wl("Your Attributes are:");
                            Util.Util.wl("Strength: " + Strength);
                            Util.Util.wl("Intellect: " + Intellect);
                            Util.Util.wl("Stealth: " + Stealth);
                            Util.Util.wl("Agility: " + Agility);
                            Util.Util.wl("Luck: " + Luck);

                            Util.Util.wl("\nAre you satisfied with your selection? Selecting no will restart your attribute selection.\nYes/No");
                            string AttributeFinish = Util.Util.rl().ToLower();
                            while (AttributeFinish != "yes" && AttributeFinish != "no")
                            {
                                Util.Util.wl("\nPlease type yes or no.");
                                AttributeFinish = Util.Util.rl().ToLower();
                            }
                            if (AttributeFinish == "no")
                            {
                                Util.Util.wl("Restarting Attribute Selection.");
                                attributepoints = 15;
                                basestrength = 2;
                                baseintellect = 2;
                                basestealth = 2;
                                baseagility = 2;
                                baseluck = 2;
                                strength = 0;
                                intellect = 0;
                                stealth = 0;
                                agility = 0;
                                luck = 0;
                                strength2 = 0;
                                intellect2 = 0;
                                stealth2 = 0;
                                agility2 = 0;
                                luck2 = 0;
                                continue;
                            }
                            else if (AttributeFinish == "yes")
                            {
                                break;
                            }
                        }

                        Util.Util.w("\nIntellect: ");
                        intellect2 = Util.Util.irl();
                        while (intellect2 < 0 || intellect2 > attributepoints)
                        {
                            if (strength < 0)
                            {
                                Util.Util.wl("Please type a positive integer. You cannot remove points.");
                                intellect2 = Util.Util.irl();
                            }
                            else if (intellect2 > attributepoints)
                            {
                                Util.Util.wl("You only have " + attributepoints + " points. Try again.");
                                intellect2 = Util.Util.irl();
                            }
                        }
                        intellect = intellect2 + intellect;
                        attributepoints = attributepoints - intellect2;
                        if (attributepoints >= 1)
                        {
                            Util.Util.wl("You have " + attributepoints + " points remaining.");
                        }
                        else if (attributepoints < 1)
                        {
                            Util.Util.wl("You are out of points.\n");

                            Strength = (strength + basestrength);
                            Intellect = (intellect + baseintellect);
                            Stealth = (stealth + basestealth);
                            Agility = (agility + baseagility);
                            Luck = (luck + baseluck);

                            Util.Util.wl("Your Attributes are:");
                            Util.Util.wl("Strength: " + Strength);
                            Util.Util.wl("Intellect: " + Intellect);
                            Util.Util.wl("Stealth: " + Stealth);
                            Util.Util.wl("Agility: " + Agility);
                            Util.Util.wl("Luck: " + Luck);

                            Util.Util.wl("\nAre you satisfied with your selection? Selecting no will restart your attribute selection.\nYes/No");
                            string AttributeFinish = Util.Util.rl().ToLower();
                            while (AttributeFinish != "yes" && AttributeFinish != "no")
                            {
                                Util.Util.wl("\nPlease type yes or no.");
                                AttributeFinish = Util.Util.rl().ToLower();
                            }
                            if (AttributeFinish == "no")
                            {
                                Util.Util.wl("Restarting Attribute Selection.");
                                attributepoints = 15;
                                basestrength = 2;
                                baseintellect = 2;
                                basestealth = 2;
                                baseagility = 2;
                                baseluck = 2;
                                strength = 0;
                                intellect = 0;
                                stealth = 0;
                                agility = 0;
                                luck = 0;
                                strength2 = 0;
                                intellect2 = 0;
                                stealth2 = 0;
                                agility2 = 0;
                                luck2 = 0;
                                continue;
                            }
                            else if (AttributeFinish == "yes")
                            {
                                break;
                            }
                        }

                        Util.Util.w("\nStealth: ");
                        stealth2 = Util.Util.irl();
                        while (stealth2 < 0 || stealth2 > attributepoints)
                        {
                            if (stealth2 < 0)
                            {
                                Util.Util.wl("Please type a positive integer. You cannot remove points.");
                                stealth2 = Util.Util.irl();
                            }
                            else if (stealth2 > attributepoints)
                            {
                                Util.Util.wl("You only have " + attributepoints + " points. Try again.");
                                stealth2 = Util.Util.irl();
                            }
                        }
                        stealth = stealth2 + stealth;
                        attributepoints = attributepoints - stealth2;
                        if (attributepoints >= 1)
                        {
                            Util.Util.wl("You have " + attributepoints + " points remaining.");
                        }
                        else if (attributepoints < 1)
                        {
                            Util.Util.wl("You are out of points.\n");

                            Strength = (strength + basestrength);
                            Intellect = (intellect + baseintellect);
                            Stealth = (stealth + basestealth);
                            Agility = (agility + baseagility);
                            Luck = (luck + baseluck);

                            Util.Util.wl("Your Attributes are:");
                            Util.Util.wl("Strength: " + Strength);
                            Util.Util.wl("Intellect: " + Intellect);
                            Util.Util.wl("Stealth: " + Stealth);
                            Util.Util.wl("Agility: " + Agility);
                            Util.Util.wl("Luck: " + Luck);

                            Util.Util.wl("\nAre you satisfied with your selection? Selecting no will restart your attribute selection.\nYes/No");
                            string AttributeFinish = Util.Util.rl().ToLower();
                            while (AttributeFinish != "yes" && AttributeFinish != "no")
                            {
                                Util.Util.wl("\nPlease type yes or no.");
                                AttributeFinish = Util.Util.rl().ToLower();
                            }
                            if (AttributeFinish == "no")
                            {
                                Util.Util.wl("Restarting Attribute Selection.");
                                attributepoints = 15;
                                basestrength = 2;
                                baseintellect = 2;
                                basestealth = 2;
                                baseagility = 2;
                                baseluck = 2;
                                strength = 0;
                                intellect = 0;
                                stealth = 0;
                                agility = 0;
                                luck = 0;
                                strength2 = 0;
                                intellect2 = 0;
                                stealth2 = 0;
                                agility2 = 0;
                                luck2 = 0;
                                continue;
                            }
                            else if (AttributeFinish == "yes")
                            {
                                break;
                            }
                        }

                        Util.Util.w("\nAgility: ");
                        agility2 = Util.Util.irl();
                        while (agility2 < 0 || agility2 > attributepoints)
                        {
                            if (agility2 < 0)
                            {
                                Util.Util.wl("Please type a positive integer. You cannot remove points.");
                                agility2 = Util.Util.irl();
                            }
                            else if (agility2 > attributepoints)
                            {
                                Util.Util.wl("You only have " + attributepoints + " points. Try again.");
                                agility2 = Util.Util.irl();
                            }
                        }
                        agility = agility2 + agility;
                        attributepoints = attributepoints - agility2;
                        if (attributepoints >= 1)
                        {
                            Util.Util.wl("You have " + attributepoints + " points remaining.");
                        }
                        else if (attributepoints < 1)
                        {
                            Util.Util.wl("You are out of points.\n");

                            Strength = (strength + basestrength);
                            Intellect = (intellect + baseintellect);
                            Stealth = (stealth + basestealth);
                            Luck = (luck + baseluck);

                            Util.Util.wl("Your Attributes are:");
                            Util.Util.wl("Strength: " + Strength);
                            Util.Util.wl("Intellect: " + Intellect);
                            Util.Util.wl("Stealth: " + Stealth);
                            Util.Util.wl("Luck: " + Luck);

                            Util.Util.wl("\nAre you satisfied with your selection? Selecting no will restart your attribute selection.\nYes/No");
                            string AttributeFinish = Util.Util.rl().ToLower();
                            while (AttributeFinish != "yes" && AttributeFinish != "no")
                            {
                                Util.Util.wl("\nPlease type yes or no.");
                                AttributeFinish = Util.Util.rl().ToLower();
                            }
                            if (AttributeFinish == "no")
                            {
                                Util.Util.wl("Restarting Attribute Selection.");
                                attributepoints = 15;
                                basestrength = 2;
                                baseintellect = 2;
                                basestealth = 2;
                                baseluck = 2;
                                strength = 0;
                                intellect = 0;
                                stealth = 0;
                                luck = 0;
                                strength2 = 0;
                                intellect2 = 0;
                                stealth2 = 0;
                                agility2 = 0;
                                luck2 = 0;
                                continue;
                            }
                            else if (AttributeFinish == "yes")
                            {
                                break;
                            }
                        }

                        Util.Util.w("\nLuck: ");
                        luck2 = Util.Util.irl();
                        while (luck2 < 0 || luck2 > attributepoints)
                        {
                            if (luck2 < 0)
                            {
                                Util.Util.wl("Please type a positive integer. You cannot remove points.");
                                luck2 = Util.Util.irl();
                            }
                            else if (luck2 > attributepoints)
                            {
                                Util.Util.wl("You only have " + attributepoints + " points. Try again.");
                                luck2 = Util.Util.irl();
                            }
                            if (attributepoints >= 1)
                            {
                                Strength = (strength + basestrength);
                                Intellect = (intellect + baseintellect);
                                Stealth = (stealth + basestealth);
                                Luck = (luck + baseluck);

                                Util.Util.wl("Your Attributes are:");
                                Util.Util.wl("Strength: " + Strength);
                                Util.Util.wl("Intellect: " + Intellect);
                                Util.Util.wl("Stealth: " + Stealth);
                                Util.Util.wl("Agility: " + Agility);
                                Util.Util.wl("Luck: " + Luck);

                                Util.Util.wl("\nYou still have " + attributepoints + " points remaining. Would you like to continue? If you choose no, the attributes selection will restart.\n Yes/No");
                                string AttributeFinish = Util.Util.rl().ToLower();
                                while (AttributeFinish != "yes" && AttributeFinish != "no")
                                {
                                    Util.Util.wl("\nPlease type yes or no.");
                                    AttributeFinish = Util.Util.rl().ToLower();
                                }
                                if (AttributeFinish == "no")
                                {
                                    Util.Util.wl("Restarting Attribute Selection.");
                                    attributepoints = 15;
                                    basestrength = 2;
                                    baseintellect = 2;
                                    basestealth = 2;
                                    baseluck = 2;
                                    strength = 0;
                                    intellect = 0;
                                    stealth = 0;
                                    agility = 0;
                                    luck = 0;
                                    strength2 = 0;
                                    intellect2 = 0;
                                    stealth2 = 0;
                                    agility2 = 0;
                                    luck2 = 0;
                                    continue;
                                }
                                else if (AttributeFinish == "yes")
                                {
                                    break;
                                }
                            }
                            else if (attributepoints < 1)
                            {
                                Util.Util.wl("You are out of points.\n");

                                Strength = (strength + basestrength);
                                Intellect = (intellect + baseintellect);
                                Stealth = (stealth + basestealth);
                                Luck = (luck + baseluck);

                                Util.Util.wl("Your Attributes are:");
                                Util.Util.wl("Strength: " + Strength);
                                Util.Util.wl("Intellect: " + Intellect);
                                Util.Util.wl("Stealth: " + Stealth);
                                Util.Util.wl("Agility: " + Agility);
                                Util.Util.wl("Luck: " + Luck);

                                Util.Util.wl("\nAre you satisfied with your selection? Selecting no will restart your attribute selection.\nYes/No");
                                string AttributeFinish = Util.Util.rl().ToLower();
                                while (AttributeFinish != "yes" && AttributeFinish != "no")
                                {
                                    Util.Util.wl("\nPlease type yes or no.");
                                    AttributeFinish = Util.Util.rl().ToLower();
                                }
                                if (AttributeFinish == "no")
                                {
                                    Util.Util.wl("Restarting Attribute Selection.");
                                    attributepoints = 15;
                                    basestrength = 2;
                                    baseintellect = 2;
                                    basestealth = 2;
                                    baseluck = 2;
                                    strength = 0;
                                    intellect = 0;
                                    stealth = 0;
                                    agility = 0;
                                    luck = 0;
                                    strength2 = 0;
                                    intellect2 = 0;
                                    stealth2 = 0;
                                    agility2 = 0;
                                    luck2 = 0;
                                    continue;
                                }
                                else if (AttributeFinish == "yes")
                                {
                                    break;
                                }
                            }
                        }
                        luck = luck2 + luck;
                        attributepoints = attributepoints - luck2;
                    }
                    break;
                }
                else
                {
                    break;
                }

            }
            Strength = (strength + basestrength);
            Intellect = (intellect + baseintellect);
            Stealth = (stealth + basestealth);
            Agility = (agility + baseagility);
            Luck = (luck + baseluck);

            Util.Util.wl("\nYour Final Attributes are:");
            Util.Util.wl("Strength: " + Strength);
            Util.Util.wl("Intellect: " + Intellect);
            Util.Util.wl("Stealth: " + Stealth);
            Util.Util.wl("Agility: " + Agility);
            Util.Util.wl("Luck: " + Luck);

            return Strength;
            return Intellect;
            return Stealth;
            return Luck;
        }
    }
}
