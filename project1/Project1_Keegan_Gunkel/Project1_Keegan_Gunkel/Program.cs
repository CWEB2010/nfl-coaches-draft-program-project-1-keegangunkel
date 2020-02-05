using System;
using System.Collections;
namespace Project1_Keegan_Gunkel
{
    class Program
    {
        static void Main(string[] args)
        {

            int amountOfPicks = 5;
            double allowance = 95000000;
            double costEffective = 65000000;
            //Welcome message
            welcomeMessage(allowance, amountOfPicks, costEffective);
            //Quarterbacks list
            Player joeBurrow = NewPlayer("Joe Burrow", "LSU", "26,400,100");
            Player tuaTagoVailoa = NewPlayer("Tua Tagovailoa", "Alabama", "20,300,100");
            Player justinHerbert = NewPlayer("Justin Herbert", "Oregon", "17,420,300");
            Player jordanLove = NewPlayer("Jordan Love", "Utah St.", "13,100,145");
            Player jakeFromm = NewPlayer("Jake Fromm", "Georgia", "10,300,000");
            //Running Backs list
            Player deandreSwift = NewPlayer("D'Andre Swift", "Georgia", "24,500,100");
            Player jonathanTaylor = NewPlayer("Jonathan Taylor", "Wisconsin", "19,800,200");
            Player jkDobbins = NewPlayer("J.K. Dobbins", "Ohio State", "18,700,800");
            Player zackMoss = NewPlayer("Zack Moss", "Utah", "15,000,000");
            Player camAtkers = NewPlayer("Cam Atkers", "Florida St.", "11,600,400");
            // Wide Recievers list
           
            
            // Positions lsit
            string[] positions = { "Quarterbacks", "Running Backs", "Wide Recievers" };
            // Player list to figure out which player the coach picked
            var players = new ArrayList();
            // Multi Dimensional Arrays for each player position
            String[,] quarterBacks = {
                { joeBurrow.name.ToUpper(), tuaTagoVailoa.name.ToUpper(), justinHerbert.name.ToUpper(), jordanLove.name.ToUpper(), jakeFromm.name.ToUpper() },
                { "\t\t\t"+joeBurrow.school, "\t\t\t\t"+tuaTagoVailoa.school, "\t\t\t"+justinHerbert.school, "\t\t\t\t"+jordanLove.school, "\t\t\t"+jakeFromm.school},
                { "\t\t\t"+joeBurrow.price,"\t\t\t"+tuaTagoVailoa.price,"\t\t\t"+justinHerbert.price,"\t\t\t"+jordanLove.price, "\t\t\t"+jakeFromm.price  }
            };
            String[,] runningBacks =  {
                {deandreSwift.name.ToUpper(), jonathanTaylor.name.ToUpper(), jkDobbins.name.ToUpper(),zackMoss.name.ToUpper(),camAtkers.name.ToUpper() },
                {"\t\t\t"+deandreSwift.school, "\t\t\t\t"+jonathanTaylor.school, "\t\t\t"+jkDobbins.school,"\t\t\t"+zackMoss.school,"\t\t\t\t"+camAtkers.school },
                {"\t\t\t"+deandreSwift.price, "\t\t\t"+jonathanTaylor.price, "\t\t\t"+jkDobbins.price,"\t\t\t"+zackMoss.price,"\t\t\t"+camAtkers.price }
            };
            DisplayQuarterbacks(quarterBacks, positions);
            DisplayRunningBacks(runningBacks, positions);

            Console.WriteLine("Who would you like to pick?");
            string coachPick = Console.ReadLine();
            coachPick = coachPick.ToUpper();
            GetCoachPick(coachPick, players);
            // If logic for which player is picked and prints that player to the screen
                if (coachPick == players[0])
                {
                    Console.WriteLine(players[0]);
                    joeBurrow.price.Split(",", 3);
                    Convert.ToInt32(joeBurrow.price);
                    Console.WriteLine(players.price);

                int number = Int32.Parse("number 32");

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
        public static Player NewPlayer(string playerName, string playerSchool, string playerCost)
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
        public static void GetCoachPick(string coachPick, ArrayList players)
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
        public string price { get; set; }
        public string bio { get; set; }

    }
}
