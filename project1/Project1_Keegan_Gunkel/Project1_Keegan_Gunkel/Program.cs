using System;
using System.Collections;
namespace Project1_Keegan_Gunkel
{
    class Program
    {
        static void Main(string[] args)
        {

            int amountOfPicks = 5;
            int allowance = 95000000;
            int costEffective = 65000000;
            //Welcome message
            welcomeMessage(allowance, amountOfPicks, costEffective);
            //Quarterbacks list
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
            // Wide Recievers list
           
            
            // Positions lsit
            string[] positions = { "Quarterbacks", "Running Backs", "Wide Recievers" };
            // Player list to figure out which player the coach picked
            var players = new ArrayList();
            var playerPrices = new ArrayList();
            // Multi Dimensional Arrays for each player position
            String[,] quarterBacks = {
                { joeBurrow.name.ToUpper(), tuaTagoVailoa.name.ToUpper(), justinHerbert.name.ToUpper(), jordanLove.name.ToUpper(), jakeFromm.name.ToUpper() },
                { "\t\t\t"+joeBurrow.school, "\t\t\t\t"+tuaTagoVailoa.school, "\t\t\t"+justinHerbert.school, "\t\t\t\t"+jordanLove.school, "\t\t\t"+jakeFromm.school},
                { "\t\t\t"+joeBurrow.price.ToString("c"),"\t\t\t"+tuaTagoVailoa.price.ToString("c"),"\t\t\t"+justinHerbert.price.ToString("c"),"\t\t\t"+jordanLove.price.ToString("c"), "\t\t\t"+jakeFromm.price.ToString("c")  }
            };
            String[,] runningBacks =  {
                {deandreSwift.name.ToUpper(), jonathanTaylor.name.ToUpper(), jkDobbins.name.ToUpper(),zackMoss.name.ToUpper(),camAtkers.name.ToUpper() },
                {"\t\t\t"+deandreSwift.school, "\t\t\t\t"+jonathanTaylor.school, "\t\t\t"+jkDobbins.school,"\t\t\t"+zackMoss.school,"\t\t\t\t"+camAtkers.school },
                {"\t\t\t"+deandreSwift.price.ToString("c"), "\t\t\t"+jonathanTaylor.price.ToString("c"), "\t\t\t"+jkDobbins.price.ToString("c"),"\t\t\t"+zackMoss.price.ToString("c"),"\t\t\t"+camAtkers.price.ToString("c") }
            };
            DisplayQuarterbacks(quarterBacks, positions);
            DisplayRunningBacks(runningBacks, positions);

            Console.WriteLine("Who would you like to pick?");
            string coachPick = Console.ReadLine();
            coachPick = coachPick.ToUpper();
            Console.WriteLine("How much does the player cost?");
            string playerCost = Console.ReadLine();

            GetCoachPick(coachPick, players, playerCost);
            // If logic for which player is picked and prints that player to the screen
                if (coachPick == players[0])
            {
                int playerPriceInt = Int32.Parse(playerCost);
                int newBudget = allowance - playerPriceInt;
                Console.WriteLine("You picked "+players[0]+" You have " + newBudget.ToString("c")+ " left to spend");
            }
        }
        //Welcome message method
        static void welcomeMessage(double budget, int picks, double costEfficient)
        {
            Console.WriteLine("Welcome to the 2020 draft program!");
            Console.WriteLine("You can take up to " + picks + " picks for the draft without exceeding your " + budget + " budget.");
            Console.WriteLine("If you select any 3 players in the best, 2nd best, or 3rd best category under " + costEfficient + " , you get a cost effective message");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

        }
        //Displays Quarter Backs
        public static void DisplayQuarterbacks(String[,] quarterbacks, string [] positions)
        {
            Console.WriteLine($"\t\t\t The best \t\t\t 2nd best \t\t\t 3rd best \t\t\t 4th best \t\t\t 5th best\n");
            Console.Write(positions[0] + "\t");
            for (var i = 0; i < quarterbacks.GetLength(0); i++)
            {
                for (var x = 0; x < quarterbacks.GetLength(1); x++)
                {
                    Console.Write($"{quarterbacks[i,x]} ");
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
        // Creates new player objects
        public static Player NewPlayer(string playerName, string playerSchool, int playerCost)
        {
           
           Player aPlayer =  new Player();
            aPlayer.name = "\t" + playerName + "\t\t";
            aPlayer.school = playerSchool  ;
            aPlayer.price =  playerCost ;
            aPlayer.bio = playerName + "\n" + "("+playerSchool+")" + "\n" + "$" + playerCost + "\n";
            //Console.WriteLine(aPlayer.bio);
            return aPlayer;

        }
        //Gets the coach's pick
        public static void GetCoachPick(string coachPick, ArrayList players, string playerPrice)
        {
            string coachPickVar = coachPick;
            players.Add(coachPickVar);
            

        }
    }
    //Class "blueprint" for my player objects
    class Player
    {
        public string name { get; set; }
        public string school { get; set; }
        public int price { get; set; }
        public string bio { get; set; }

    }
}
