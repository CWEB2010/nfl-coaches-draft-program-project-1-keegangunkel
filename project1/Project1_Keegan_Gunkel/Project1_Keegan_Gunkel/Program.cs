using System;

namespace Project1_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Quarterbacks
            Player joeBurrow = NewPlayer("Joe Burrow", "LSU", 26400100);
            Player tuaTagoVailoa = NewPlayer("Tua Tagovailoa", "Alabama", 20300100);
            Player justinHerbert = NewPlayer("Justin Herbert", "Oregon", 17420300);
            Player jordanLove = NewPlayer("Jordan Love", "Utah St.", 13100145);
            Player jakeFromm = NewPlayer("Jake Fromm", "Georgia", 10300000);
            //Running backs
            Player deandreSwift = NewPlayer("D'Andre Swift", "Georgia", 24500100);
            Player jonathanTaylor = NewPlayer("Jonathan Taylor", "Wisconsin", 19800200);
            Player jkDobbins = NewPlayer("J.K. Dobbins", "Ohio State", 18700800);
            Player zackMoss = NewPlayer("Zack Moss", "Utah", 15000000);
            Player camAtkers = NewPlayer("Cam Atkers", "Florida St.", 11600400);
            //Wide recievers
            Player ceeDeeLamb = NewPlayer("CeeDee Lamb", "Oklahoma", 23400000);
            Player jerryJeudy = NewPlayer("Jerry Jeudy", "Alabama", 21900300);
            Player teeHiggins = NewPlayer("Tee Higgins", "Clemson", 19300230);
            Player henryRuggsIII = NewPlayer("Henry Ruggs III", "Alabama", 13400230);
            Player tylerJohnson = NewPlayer("Tyler Johnson", "Minnesota", 10000000);
            //Defensive linemen
            Player chaseYoung = NewPlayer("Chase Young", "Ohio St.", 26200300);
            Player derrickBrown = NewPlayer("Derrick Brown", "Auburn", 22000000);
            Player ajEpenesa = NewPlayer("A.J. Epenesa", "Iowa", 16000000);
            Player javonKinlaw = NewPlayer("Javon Kinlaw", "So. Carolina", 18000000);
            Player yeturGrossMatos = NewPlayer("Yetur Gross-Matos", "Penn St.", 13000000);
            //Defensive backs
            Player jeffOkudah = NewPlayer("Jeff Okudah", "Ohio St.", 24000000);
            Player grantDelpit = NewPlayer("Grant Delpit", "LSU", 22500249);
            Player kristianFulton = NewPlayer("Kristian Fulton", "LSU", 20000100);
            Player xavierMckinney = NewPlayer("Xavier Mckinney", "Alabama", 16000200);
            Player cjHenderson = NewPlayer("CJ Henderson", "Florida", 11899999);
            // Tight Ends 
            Player coleKmet = NewPlayer("Cole Kmet", "Notre Dame", 27800900);
            Player brycenHopkins = NewPlayer("Brycen Hopkins", "Purdue", 21000800);
            Player hunterBryant = NewPlayer("Hunter Bryant", "Washington", 17499233);
            Player jaredPinkney = NewPlayer("Jared Pinkney", "Vanderbilt", 27900200);
            Player jacobBreeland = NewPlayer("Jacob Breeland", "Oregon", 14900333);
            // Line-Backer's
            Player isaiahSimmons = NewPlayer("Isaiah Simmons", "Clemson", 22900300);
            Player kennethMurray = NewPlayer("Kenneth Murray", "Oklahoma", 19000590);
            Player zackBaun = NewPlayer("Zack Baun", "Wisconsin", 18000222);
            Player akeemDavisGaither = NewPlayer("Akeem Davis-Gaither", "App. St.", 12999999);
            Player troyDye = NewPlayer("Troy Dye", "Oregon", 10000100);
            // Offensive Tackles
            Player jedrickWillsJr = NewPlayer("Jedrick Wills Jr.", "Alabama", 23000000);
            Player andrewThomas = NewPlayer("Andrew Thomas", "Georgia", 20000000);
            Player tristanWirfs = NewPlayer("Tristan Wirds", "Iowa", 19400000);
            Player tylerBiadasz = NewPlayer("Tyler Biadasz", "Wisconsin", 16200700);
            Player mekhiBecton = NewPlayer("Mekhi Becton", "Louisville", 15900000);

            // Positions list
            string[] positions = { "Quarterbacks", "Running Backs", "Wide Recievers", "Defensive Linemen", "Defensive Backs", "Tight Ends", "Line-Backer's", "Offensive Tackles"};
            // Cost-effective players
            string[] costEffectivePlayers = {joeBurrow.name.ToUpper(),tuaTagoVailoa.name.ToUpper(),justinHerbert.name.ToUpper(),deandreSwift.name.ToUpper(),jonathanTaylor.name.ToUpper(),jkDobbins.name.ToUpper(),ceeDeeLamb.name.ToUpper(), jerryJeudy.name.ToUpper(),teeHiggins.name.ToUpper(),chaseYoung.name.ToUpper(),
                                             derrickBrown.name.ToUpper(),ajEpenesa.name.ToUpper(),jeffOkudah.name.ToUpper(),grantDelpit.name.ToUpper(),kristianFulton.name.ToUpper(),coleKmet.name.ToUpper(),brycenHopkins.name.ToUpper(),hunterBryant.name.ToUpper(),isaiahSimmons.name.ToUpper(),kennethMurray.name.ToUpper(),zackBaun.name.ToUpper()
                                              ,jedrickWillsJr.name.ToUpper(),andrewThomas.name.ToUpper(),tristanWirfs.name.ToUpper()};
            // Multi-Dimensional arrays for each player position
            String[,] quarterBacks = {
                { "\t"+joeBurrow.name.ToUpper(), "\t\t\t"+tuaTagoVailoa.name.ToUpper(), "\t\t\t"+justinHerbert.name.ToUpper(), "\t\t\t"+jordanLove.name.ToUpper(), "\t\t\t"+jakeFromm.name.ToUpper() },
                { "\t\t\t"+joeBurrow.school.ToUpper(), "\t\t\t\t"+tuaTagoVailoa.school.ToUpper(), "\t\t\t"+justinHerbert.school.ToUpper(), "\t\t\t\t"+jordanLove.school.ToUpper(), "\t\t\t"+jakeFromm.school.ToUpper()},
                { "\t\t\t"+joeBurrow.price.ToString("c"),"\t\t\t"+tuaTagoVailoa.price.ToString("c"),"\t\t\t"+justinHerbert.price.ToString("c"),"\t\t\t"+jordanLove.price.ToString("c"), "\t\t\t"+jakeFromm.price.ToString("c")  }
            };
            String[,] runningBacks =  {
                {"\t"+deandreSwift.name.ToUpper(), "\t\t\t"+jonathanTaylor.name.ToUpper(), "\t\t"+jkDobbins.name.ToUpper(),"\t\t\t"+zackMoss.name.ToUpper(),"\t\t\t"+camAtkers.name.ToUpper() },
                {"\t\t\t"+deandreSwift.school.ToUpper(), "\t\t\t"+jonathanTaylor.school.ToUpper(), "\t\t\t"+jkDobbins.school.ToUpper(),"\t\t\t"+zackMoss.school.ToUpper(),"\t\t\t\t"+camAtkers.school.ToUpper() },
                {"\t\t\t"+deandreSwift.price.ToString("c"), "\t\t\t"+jonathanTaylor.price.ToString("c"), "\t\t\t"+jkDobbins.price.ToString("c"),"\t\t\t"+zackMoss.price.ToString("c"),"\t\t\t"+camAtkers.price.ToString("c") }
            };
            String[,] wideRecievers = {
                {"\t"+ceeDeeLamb.name.ToUpper(),"\t\t\t"+jerryJeudy.name.ToUpper(),"\t\t\t"+teeHiggins.name.ToUpper(),"\t\t\t"+henryRuggsIII.name.ToUpper(),"\t\t\t"+tylerJohnson.name.ToUpper() },
                {"\t\t\t"+ceeDeeLamb.school.ToUpper(),"\t\t\t"+jerryJeudy.school.ToUpper(),"\t\t\t"+teeHiggins.school.ToUpper(),"\t\t\t"+henryRuggsIII.school.ToUpper(),"\t\t\t\t"+tylerJohnson.school.ToUpper() },
                {"\t\t\t"+ceeDeeLamb.price.ToString("c"),"\t\t\t"+jerryJeudy.price.ToString("c"),"\t\t\t"+teeHiggins.price.ToString("c"),"\t\t\t"+henryRuggsIII.price.ToString("c"),"\t\t\t"+tylerJohnson.price.ToString("c") }
            };
            String[,] defensiveLinemen = {
                { chaseYoung.name.ToUpper(),"\t\t\t" + derrickBrown.name.ToUpper(),"\t\t\t" + ajEpenesa.name.ToUpper(), "\t\t\t" + javonKinlaw.name.ToUpper(),"\t\t\t" + yeturGrossMatos.name.ToUpper()},
                {"\t\t\t"+chaseYoung.school.ToUpper(),"\t\t\t"+derrickBrown.school.ToUpper(),"\t\t\t\t"+ajEpenesa.school.ToUpper(),"\t\t\t\t"+javonKinlaw.school.ToUpper(),"\t\t\t"+yeturGrossMatos.school.ToUpper()},
                {"\t\t\t"+ chaseYoung.price.ToString("c"),"\t\t\t"+ derrickBrown.price.ToString("c"),"\t\t\t"+ ajEpenesa.price.ToString("c"),"\t\t\t"+ javonKinlaw.price.ToString("c"),"\t\t\t"+ yeturGrossMatos.price.ToString("c"), }
            };
            String[,] defensiveBacks = {
                {"\t"+jeffOkudah.name.ToUpper(),"\t\t\t"+grantDelpit.name.ToUpper(),"\t\t\t"+kristianFulton.name.ToUpper()+"\t","\t\t"+xavierMckinney.name.ToUpper(), "\t\t\t"+cjHenderson.name.ToUpper() },
                {"\t\t\t"+jeffOkudah.school.ToUpper(),"\t\t\t"+grantDelpit.school.ToUpper(),"\t\t\t\t"+kristianFulton.school.ToUpper(),"\t\t\t\t"+xavierMckinney.school.ToUpper(), "\t\t\t\t"+cjHenderson.school.ToUpper()},
                {"\t\t\t"+jeffOkudah.price.ToString("c"), "\t\t\t"+grantDelpit.price.ToString("c"), "\t\t\t"+kristianFulton.price.ToString("c"), "\t\t\t"+xavierMckinney.price.ToString("c"),"\t\t\t"+cjHenderson.price.ToString("c")}
            };
            String[,] tightEnds = {
                {"\t"+coleKmet.name.ToUpper(), "\t\t\t"+brycenHopkins.name.ToUpper(), "\t\t\t"+hunterBryant.name.ToUpper(),"\t\t\t"+jaredPinkney.name.ToUpper(),"\t\t\t"+jacobBreeland.name.ToUpper() },
                {"\t\t\t"+coleKmet.school.ToUpper(),"\t\t\t"+brycenHopkins.school.ToUpper(), "\t\t\t\t"+hunterBryant.school.ToUpper(),"\t\t\t"+jaredPinkney.school.ToUpper(),"\t\t\t"+jacobBreeland.school.ToUpper()},
                {"\t\t\t"+coleKmet.price.ToString("c"),"\t\t\t"+brycenHopkins.price.ToString("c"),"\t\t\t"+hunterBryant.price.ToString("c"),"\t\t\t"+jaredPinkney.price.ToString("c"),"\t\t\t"+jacobBreeland.price.ToString("c") }
            };
            String[,] lineBackers = {
                {"\t"+isaiahSimmons.name.ToUpper(), "\t\t\t"+kennethMurray.name.ToUpper(),"\t\t\t"+zackBaun.name.ToUpper(),"\t\t\t"+akeemDavisGaither.name.ToUpper(),"\t\t"+troyDye.name.ToUpper()},
                {"\t\t\t"+isaiahSimmons.school.ToUpper(),"\t\t\t"+kennethMurray.school.ToUpper(),"\t\t\t"+zackBaun.school.ToUpper(),"\t\t\t"+akeemDavisGaither.school.ToUpper(),"\t\t\t"+troyDye.school.ToUpper()},
                {"\t\t\t"+isaiahSimmons.price.ToString("c"), "\t\t\t"+kennethMurray.price.ToString("c"),"\t\t\t"+zackBaun.price.ToString("c"),"\t\t\t"+akeemDavisGaither.price.ToString("c"),"\t\t\t"+troyDye.price.ToString("c")}
            };
            String[,] offensiveTackles = {
                {jedrickWillsJr.name.ToUpper(),"\t\t"+andrewThomas.name.ToUpper(),"\t\t\t"+tristanWirfs.name.ToUpper(),"\t\t\t"+tylerBiadasz.name.ToUpper(),"\t\t\t"+mekhiBecton.name.ToUpper()},
                {"\t\t\t"+jedrickWillsJr.school.ToUpper(),"\t\t\t"+andrewThomas.school.ToUpper(), "\t\t\t"+tristanWirfs.school.ToUpper(),"\t\t\t\t"+tylerBiadasz.school.ToUpper(),"\t\t\t"+mekhiBecton.school.ToUpper()},
                {"\t\t\t"+jedrickWillsJr.price.ToString("c"),"\t\t\t"+andrewThomas.price.ToString("c"),"\t\t\t"+tristanWirfs.price.ToString("c"),"\t\t\t"+tylerBiadasz.price.ToString("c"),"\t\t\t"+mekhiBecton.price.ToString("c") }
            };
            // Player names array to know what player the user picked
            String[] playerNames ={joeBurrow.name.ToUpper(), tuaTagoVailoa.name.ToUpper(),justinHerbert.name.ToUpper(),jordanLove.name.ToUpper(),jakeFromm.name.ToUpper(),deandreSwift.name.ToUpper(),jonathanTaylor.name.ToUpper(),
                                jkDobbins.name.ToUpper(),zackMoss.name.ToUpper(),camAtkers.name.ToUpper(),ceeDeeLamb.name.ToUpper(),jerryJeudy.name.ToUpper(),teeHiggins.name.ToUpper(),henryRuggsIII.name.ToUpper(),tylerJohnson.name.ToUpper(),
                                chaseYoung.name.ToUpper(),derrickBrown.name.ToUpper(),ajEpenesa.name.ToUpper(),javonKinlaw.name.ToUpper(),yeturGrossMatos.name.ToUpper(), jeffOkudah.name.ToUpper(),grantDelpit.name.ToUpper(),
                                kristianFulton.name.ToUpper(),xavierMckinney.name.ToUpper(), cjHenderson.name.ToUpper(),coleKmet.name.ToUpper(), brycenHopkins.name.ToUpper(),hunterBryant.name.ToUpper(),jaredPinkney.name.ToUpper(),jacobBreeland.name.ToUpper(),
                                isaiahSimmons.name.ToUpper(),kennethMurray.name.ToUpper(),zackBaun.name.ToUpper(),akeemDavisGaither.name.ToUpper(), troyDye.name.ToUpper(),jedrickWillsJr.name.ToUpper(),andrewThomas.name.ToUpper(),tristanWirfs.name.ToUpper(),
                                tylerBiadasz.name.ToUpper(),mekhiBecton.name.ToUpper()
            };
            // Player prices array to get the price of the chosen player
            int[] playerPrices = { joeBurrow.price, tuaTagoVailoa.price, justinHerbert.price, jordanLove.price, jakeFromm.price, deandreSwift.price, jonathanTaylor.price, jkDobbins.price, zackMoss.price, camAtkers.price, ceeDeeLamb.price,
                                    jerryJeudy.price,teeHiggins.price,henryRuggsIII.price,tylerJohnson.price, chaseYoung.price, derrickBrown.price, ajEpenesa.price, javonKinlaw.price, yeturGrossMatos.price, jeffOkudah.price, grantDelpit.price,
                                    kristianFulton.price, xavierMckinney.price, cjHenderson.price, coleKmet.price, brycenHopkins.price, hunterBryant.price,jaredPinkney.price,jacobBreeland.price, isaiahSimmons.price,kennethMurray.price,zackBaun.price,
                                    akeemDavisGaither.price,troyDye.price,jedrickWillsJr.price,andrewThomas.price,tristanWirfs.price,tylerBiadasz.price,mekhiBecton.price
            };
            // Budget array so the budget gets updated everytime the user enters a player
            int[] budgets = { 95000000, 0, 0, 0, 0, 0 };
            int costEffectivePlayersPicked = 0;
            string coachPick;
            string coachPick2;
            string coachPick3;
            string coachPick4;
            string coachPick5;
            //Welcome message
            welcomeMessage();
            Console.WriteLine("\t\t\t The best \t\t\t 2nd best \t\t\t 3rd best \t\t\t 4th best \t\t\t 5th best\n");
            DisplayRowOfPlayers(quarterBacks, positions,0);
            DisplayRowOfPlayers(runningBacks, positions, 1);
            DisplayRowOfPlayers(wideRecievers, positions, 2);
            DisplayRowOfPlayers(defensiveLinemen, positions, 3);
            DisplayRowOfPlayers(defensiveBacks, positions, 4);
            DisplayRowOfPlayers(tightEnds, positions, 5);
            DisplayRowOfPlayers(lineBackers, positions, 6);
            DisplayRowOfPlayers(offensiveTackles, positions, 7);

            while (true)
            {
                //Pick 1
                Console.WriteLine("Please enter the player you would like to draft.");
                coachPick = Console.ReadLine();
                coachPick = coachPick.ToUpper();
                GetChosenPlayerAndPrice(playerNames, coachPick, playerPrices, budgets, 0, 1);
                // Finds out if player picked is cost effective
                for (var i = 0; i < costEffectivePlayers.GetLength(0); i++)
                {
                    if (coachPick == costEffectivePlayers[i])
                    {
                        costEffectivePlayersPicked++;
                    }
                }
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
                    // Finds out if player picked was cost effective
                    for (var i = 0; i < costEffectivePlayers.GetLength(0); i++)
                    {
                        if (coachPick2 == costEffectivePlayers[i])
                        {
                            costEffectivePlayersPicked++;
                        }
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
                    // Finds out if player picked was cost effective
                    for (var i = 0; i < costEffectivePlayers.GetLength(0); i++)
                    {
                        if (coachPick2 == costEffectivePlayers[i])
                        {
                            costEffectivePlayersPicked++;
                        }
                    }
                    GetChosenPlayerAndPrice(playerNames, coachPick2, playerPrices, budgets, 1, 2);
                }
                else if (yesOrNoDecision == "N")
                {
                    EndMessage(budgets, 1);
                    break;
                }
                else if (yesOrNoDecision == "n")
                {
                    EndMessage(budgets, 1);
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
                    // Finds out if player picked was cost effective
                    for (var i = 0; i < costEffectivePlayers.GetLength(0); i++)
                    {
                        if (coachPick3 == costEffectivePlayers[i])
                        {
                            costEffectivePlayersPicked++;
                            if (costEffectivePlayersPicked == 3)
                            {
                                if (budgets[2] >= 30000000)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nYou were cost effective");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                    }
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
                    // Finds out if player picked was cost effective
                    for (var i = 0; i < costEffectivePlayers.GetLength(0); i++)
                    {
                        if (coachPick3 == costEffectivePlayers[i])
                        {
                            costEffectivePlayersPicked++;
                            if (costEffectivePlayersPicked == 3)
                            {
                                if (budgets[2] >= 30000000)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nYou were cost effective");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                    }
                }
                else if (yesOrNoDecision == "N")
                {
                    EndMessage(budgets, 2);
                    break;
                }
                else if (yesOrNoDecision == "n")
                {
                    EndMessage(budgets, 2);
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
                    coachPick4 = coachPick4.ToUpper();
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
                    // Finds out if player picked was cost effective
                    for (var i = 0; i < costEffectivePlayers.GetLength(0); i++)
                    {
                        if (coachPick4 == costEffectivePlayers[i])
                        {
                            costEffectivePlayersPicked++;
                            if (costEffectivePlayersPicked == 3)
                            {
                                if (budgets[3] >= 30000000)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nYou were cost effective");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                    }
                }
                else if (yesOrNoDecision == "y")
                {
                    Console.WriteLine("Who would you like to pick?");
                    coachPick4 = Console.ReadLine();
                    coachPick4 = coachPick4.ToUpper();
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
                    // Finds out if player picked was cost effective
                    for (var i = 0; i < costEffectivePlayers.GetLength(0); i++)
                    {
                        if (coachPick4 == costEffectivePlayers[i])
                        {
                            costEffectivePlayersPicked++;
                            if (costEffectivePlayersPicked == 3)
                            {
                                if (budgets[3] >= 30000000)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nYou were cost effective");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                    }
                }
                else if (yesOrNoDecision == "N")
                {
                    EndMessage(budgets, 3);
                    break;
                }
                else if (yesOrNoDecision == "n")
                {
                    EndMessage(budgets, 3);
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
                    // Finds out if player picked was cost effective
                    for (var i = 0; i < costEffectivePlayers.GetLength(0); i++)
                    {
                        if (coachPick5 == costEffectivePlayers[i])
                        {
                            costEffectivePlayersPicked++;
                            if (costEffectivePlayersPicked == 3)
                            {
                                if (budgets[4] >= 30000000)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nYou were cost effective");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                    }
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
                    // Finds out if player picked was cost effective
                    for (var i = 0; i < costEffectivePlayers.GetLength(0); i++)
                    {
                        if (coachPick5 == costEffectivePlayers[i])
                        {
                            costEffectivePlayersPicked++;
                            if (costEffectivePlayersPicked == 3)
                            {
                                if (budgets[4] >= 30000000)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nYou were cost effective");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                    }
                }
                else if (yesOrNoDecision == "N")
                {
                    EndMessage(budgets, 4);
                    break;
                }
                else if (yesOrNoDecision == "n")
                {
                    EndMessage(budgets, 4);
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
                    if (budgets[budgetPos] >= 0)
                    {
                        Console.WriteLine("You picked " + names[i]);
                        Console.WriteLine("The cost " + prices[i].ToString("c"));
                        budgets[newBudgetPos] = budgets[budgetPos] - prices[i];
                        Console.WriteLine("You have " + budgets[newBudgetPos].ToString("c") + " left to spend");
                    }
                    else
                    {
                        Console.WriteLine("Error you don't have enough money for that player");
                    }
                }
            }
        }
        public static void EndMessage(int[] budget, int budgetPos)
        {
            Console.Clear();
            Console.WriteLine("You ended the draft with " + budget[budgetPos].ToString("c")+" left to spend.");
            Console.WriteLine("Enjoy your new players and good luck!");
        }


        //Gives attributes to the player object
        public static Player NewPlayer(string playerName, string playerSchool, int playerCost)
        {

            Player aPlayer = new Player();
            aPlayer.name = playerName;
            aPlayer.school = playerSchool;
            aPlayer.price = playerCost;
            aPlayer.bio = playerName + "\n" + "(" + playerSchool + ")" + "\n" + playerCost.ToString("c") + "\n";
            return aPlayer;


        }
        //Welcome message method
        static void welcomeMessage()
        {
            Console.WriteLine("Welcome to the 2020 draft program!");
            Console.WriteLine("You can take up to 5 picks for the draft without exceeding your $95,000,000 budget.");
            Console.WriteLine("If you select any 3 players in the best, 2nd best, or 3rd best category under $65,000,000,");
            Console.WriteLine("you get a cost effective message.");
            Console.WriteLine("Press any key to continue and go fullscreen after you enter the key.");
            Console.ReadKey();
            Console.Clear();

        }
        //Displays row of players based off what position they play
        public static void DisplayRowOfPlayers(String[,] playerPos, string[] positions, int positionPos)
        {
            Console.WriteLine("");
            Console.Write(positions[positionPos] + "\t");
            for (var i = 0; i < playerPos.GetLength(0); i++)
            {
                for (var x = 0; x < playerPos.GetLength(1); x++)
                {
                    Console.Write($"{playerPos[i, x]} ");
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
