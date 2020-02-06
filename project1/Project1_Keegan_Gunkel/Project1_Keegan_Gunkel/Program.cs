using System;

namespace Project1_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player joeBurrow = NewPlayer("Joe Burrow", "LSU", 26400100);
            Player tuaTagoVailoa = NewPlayer("Tua Tagovailoa", "Alabama", 20300100);
            Player justinHerbert = NewPlayer("Justin Herbert", "Oregon", 17420300);
            Player jordanLove = NewPlayer("Jordan Love", "Utah St.", 13100145);
            Player jakeFromm = NewPlayer("Jake Fromm", "Georgia", 10300000);
            //Running Backs list
            Player deandreSwift = NewPlayer("D'Andre Swift", "Georgia", 24500100);
            Player jonathanTaylor = NewPlayer("Jonathan Taylor", "Wisconsin", 19800200);
            Player jkDobbins = NewPlayer("J.K. Dobbins", "Ohio State", 18700800);
            Player zackMoss = NewPlayer("Zack Moss", "Utah", 15000000);
            Player camAtkers = NewPlayer("Cam Atkers", "Florida St.", 11600400);
            // Positions lsit
            string[] positions = { "Quarterbacks", "Running Backs", "Wide Recievers" };
            // Multi Dimensional Arrays for each player position
            String[,] quarterBacks = {
                { "\t"+joeBurrow.name.ToUpper(), "\t\t\t"+tuaTagoVailoa.name.ToUpper(), "\t\t\t"+justinHerbert.name.ToUpper(), "\t\t\t"+jordanLove.name.ToUpper(), "\t\t\t"+jakeFromm.name.ToUpper() },
                { "\t\t\t"+joeBurrow.school, "\t\t\t\t"+tuaTagoVailoa.school, "\t\t\t"+justinHerbert.school, "\t\t\t\t"+jordanLove.school, "\t\t\t"+jakeFromm.school},
                { "\t\t\t"+joeBurrow.price.ToString("c"),"\t\t\t"+tuaTagoVailoa.price.ToString("c"),"\t\t\t"+justinHerbert.price.ToString("c"),"\t\t\t"+jordanLove.price.ToString("c"), "\t\t\t"+jakeFromm.price.ToString("c")  }
            };
            String[,] runningBacks =  {
                {"\t"+deandreSwift.name.ToUpper(), "\t\t\t"+jonathanTaylor.name.ToUpper(), "\t\t\t"+jkDobbins.name.ToUpper(),"\t\t\t"+zackMoss.name.ToUpper(),"\t\t\t"+camAtkers.name.ToUpper() },
                {"\t\t\t"+deandreSwift.school, "\t\t\t\t"+jonathanTaylor.school, "\t\t\t"+jkDobbins.school,"\t\t\t"+zackMoss.school,"\t\t\t\t"+camAtkers.school },
                {"\t\t\t"+deandreSwift.price.ToString("c"), "\t\t\t"+jonathanTaylor.price.ToString("c"), "\t\t\t"+jkDobbins.price.ToString("c"),"\t\t\t"+zackMoss.price.ToString("c"),"\t\t\t"+camAtkers.price.ToString("c") }
            };
            String[] playerNames ={joeBurrow.name.ToUpper(), tuaTagoVailoa.name.ToUpper(),justinHerbert.name.ToUpper(),jordanLove.name.ToUpper(),jakeFromm.name.ToUpper(),deandreSwift.name.ToUpper(),jonathanTaylor.name.ToUpper(),
                                jkDobbins.name.ToUpper(),zackMoss.name.ToUpper(),camAtkers.name.ToUpper()};
            int[] playerPrices = { joeBurrow.price, tuaTagoVailoa.price, justinHerbert.price, jordanLove.price, jakeFromm.price, deandreSwift.price, jonathanTaylor.price, jkDobbins.price, zackMoss.price, camAtkers.price };
            int[] budgets = { 95000000, 0, 0, 0, 0, 0 };
            Console.WriteLine(playerNames[0]);
            string coachPick;
            string coachPick2;
            string coachPick3;
            string coachPick4;
            string coachPick5;
            //Welcome message
            welcomeMessage();
            DisplayQuarterbacks(quarterBacks, positions);
            DisplayRunningBacks(runningBacks, positions);

            while (true)
            {
                //Pick 1
                Console.WriteLine("Please enter a player");
                coachPick = Console.ReadLine();
                coachPick = coachPick.ToUpper();
                GetChosenPlayerAndPrice(playerNames, coachPick, playerPrices, budgets, 0, 1);
            //Decision1 and pick 2
            Decision1:
                Console.WriteLine("Would you like to pick another player? Y/N");
                string yesOrNoDecision = Console.ReadLine();
                if (yesOrNoDecision == "Y")
                {
                    Console.WriteLine("Who would you like to pick?");
                    coachPick2 = Console.ReadLine();
                    coachPick2 = coachPick2.ToUpper();
                    if (coachPick == coachPick2)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick2 = Console.ReadLine();
                    }
                    GetChosenPlayerAndPrice(playerNames, coachPick2, playerPrices, budgets, 1, 2);
                }
                else if (yesOrNoDecision == "y")
                {
                    Console.WriteLine("Who would you like to pick?");
                    coachPick2 = Console.ReadLine();
                    coachPick2 = coachPick2.ToUpper();
                    if (coachPick == coachPick2)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick2 = Console.ReadLine();
                    }
                    GetChosenPlayerAndPrice(playerNames, coachPick2, playerPrices, budgets, 1, 2);
                }
                else if (yesOrNoDecision == "N")
                {
                    break;
                }
                else if (yesOrNoDecision == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error please enter Y or N");
                    goto Decision1;
                }
            //Decision2 and Pick 3
            Decision2:
                Console.WriteLine("Would you like to pick another player? Y/N");
                yesOrNoDecision = Console.ReadLine();
                if (yesOrNoDecision == "Y")
                {
                    Console.WriteLine("Who would you like to pick?");
                    coachPick3 = Console.ReadLine();
                    coachPick3 = coachPick3.ToUpper();
                    if (coachPick3 == coachPick2)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick3 = Console.ReadLine();
                    }
                    else if (coachPick3 == coachPick)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick3 = Console.ReadLine();
                    }
                    GetChosenPlayerAndPrice(playerNames, coachPick3, playerPrices, budgets, 2, 3);
                }
                else if (yesOrNoDecision == "y")
                {
                    Console.WriteLine("Who would you like to pick?");
                    coachPick3 = Console.ReadLine();
                    coachPick3 = coachPick3.ToUpper();
                    if (coachPick3 == coachPick2)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick3 = Console.ReadLine();
                    }
                    else if (coachPick3 == coachPick)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick3 = Console.ReadLine();
                    }
                    GetChosenPlayerAndPrice(playerNames, coachPick3, playerPrices, budgets, 2, 3);
                }
                else if (yesOrNoDecision == "N")
                {
                    break;
                }
                else if (yesOrNoDecision == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error please enter Y or N");
                    goto Decision2;
                }
            //Decision3 and pick 4
            Decision3:
                Console.WriteLine("Would you like to pick another player? Y/N");
                yesOrNoDecision = Console.ReadLine();
                if (yesOrNoDecision == "Y")
                {
                    Console.WriteLine("Who would you like to pick?");
                    coachPick4 = Console.ReadLine();
                    coachPick4 = coachPick3.ToUpper();
                    if (coachPick4 == coachPick3)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick4 = Console.ReadLine();
                    }
                    else if (coachPick4 == coachPick2)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick4 = Console.ReadLine();
                    }
                    else if (coachPick4 == coachPick)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick4 = Console.ReadLine();
                    }
                    GetChosenPlayerAndPrice(playerNames, coachPick4, playerPrices, budgets, 3, 4);
                }
                else if (yesOrNoDecision == "y")
                {
                    Console.WriteLine("Who would you like to pick?");
                    coachPick4 = Console.ReadLine();
                    coachPick4 = coachPick3.ToUpper();
                    if (coachPick4 == coachPick3)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick4 = Console.ReadLine();
                    }
                    else if (coachPick4 == coachPick2)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick4 = Console.ReadLine();
                    }
                    else if (coachPick4 == coachPick)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick4 = Console.ReadLine();
                    }
                    GetChosenPlayerAndPrice(playerNames, coachPick4, playerPrices, budgets, 3, 4);
                }
                else if (yesOrNoDecision == "N")
                {
                    break;
                }
                else if (yesOrNoDecision == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error please enter Y or N");
                    goto Decision3;
                }
            //Decision 4 and pick 5
            Decision4:
                Console.WriteLine("Would you like to pick another player? Y/N");
                yesOrNoDecision = Console.ReadLine();
                if (yesOrNoDecision == "Y")
                {
                    Console.WriteLine("Who would you like to pick?");
                    coachPick5 = Console.ReadLine();
                    coachPick5 = coachPick5.ToUpper();
                    if (coachPick5 == coachPick4)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick5 = Console.ReadLine();
                    }
                    else if (coachPick5 == coachPick3)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick5 = Console.ReadLine();
                    }
                    else if (coachPick5 == coachPick2)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick5 = Console.ReadLine();
                    }
                    else if (coachPick5 == coachPick)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick5 = Console.ReadLine();
                    }
                    GetChosenPlayerAndPrice(playerNames, coachPick5, playerPrices, budgets, 4, 5);
                }
                else if (yesOrNoDecision == "y")
                {
                    Console.WriteLine("Who would you like to pick?");
                    coachPick5 = Console.ReadLine();
                    coachPick5 = coachPick5.ToUpper();
                    if (coachPick5 == coachPick4)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick5 = Console.ReadLine();
                    }
                    else if (coachPick5 == coachPick3)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick5 = Console.ReadLine();
                    }
                    else if (coachPick5 == coachPick2)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick5 = Console.ReadLine();
                    }
                    else if (coachPick5 == coachPick)
                    {
                        Console.WriteLine("Please enter a player you haven't picked yet.");
                        coachPick5 = Console.ReadLine();
                    }
                    GetChosenPlayerAndPrice(playerNames, coachPick5, playerPrices, budgets, 4, 5);
                }
                else if (yesOrNoDecision == "N")
                {
                    break;
                }
                else if (yesOrNoDecision == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error please enter Y or N");
                    goto Decision4;
                }
            }
        }
        // Gets what player the user entered and that player's price
        public static void GetChosenPlayerAndPrice(string[] names, string playerPick, int[] prices, int[] budgets, int budgetPos, int newBudgetPos)
        {
            playerPick = playerPick.ToUpper();
            for (var i = 0; i < names.GetLength(0); i++)
            {
                if (playerPick == names[i])
                {
                    Console.WriteLine("You picked " + names[i]);
                    Console.WriteLine("The cost " + prices[i].ToString("c"));
                    budgets[newBudgetPos] = budgets[budgetPos] - prices[i];
                    Console.WriteLine("You have " + budgets[newBudgetPos].ToString("c") + " left to spend");

                }
            }
        }


        //Gives attributes to the player object
        public static Player NewPlayer(string playerName, string playerSchool, int playerCost)
        {

            Player aPlayer = new Player();
            aPlayer.name = playerName;
            aPlayer.school = playerSchool;
            aPlayer.price = playerCost;
            aPlayer.bio = playerName + "\n" + "(" + playerSchool + ")" + "\n" + playerCost.ToString("c") + "\n";
            //Console.WriteLine(aPlayer.bio);
            return aPlayer;


        }
        //Welcome message method
        static void welcomeMessage()
        {
            Console.WriteLine("Welcome to the 2020 draft program!");
            Console.WriteLine("You can take up to 5 picks for the draft without exceeding your $95,000,000 budget.");
            Console.WriteLine("If you select any 3 players in the best, 2nd best, or 3rd best category under $65,000,000, you get a cost effective message");
            Console.WriteLine("Press any key to continue and go fullscreen after you enter the key.");
            Console.ReadKey();
            Console.Clear();

        }
        //Displays Quarter Backs
        public static void DisplayQuarterbacks(String[,] quarterbacks, string[] positions)
        {
            Console.WriteLine($"\t\t\t The best \t\t\t 2nd best \t\t\t 3rd best \t\t\t 4th best \t\t\t 5th best\n");
            Console.Write(positions[0] + "\t");
            for (var i = 0; i < quarterbacks.GetLength(0); i++)
            {
                for (var x = 0; x < quarterbacks.GetLength(1); x++)
                {
                    Console.Write($"{quarterbacks[i, x]} ");
                }
                Console.WriteLine("");
            }
        }
        //Displays Running Backs
        public static void DisplayRunningBacks(String[,] runningbacks, string[] positions)
        {
            Console.WriteLine("");
            Console.Write(positions[1] + "\t");
            for (var i = 0; i < runningbacks.GetLength(0); i++)
            {
                for (var x = 0; x < runningbacks.GetLength(1); x++)
                {
                    Console.Write($"{runningbacks[i, x]}");
                }
                Console.WriteLine("");
            }
        }
    }

    //Class "blueprint" for the palyer object
    class Player
    {
        public string name { get; set; }
        public string school { get; set; }
        public int price { get; set; }
        public string bio { get; set; }

    }
}
