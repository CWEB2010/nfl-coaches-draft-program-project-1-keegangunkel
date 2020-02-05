using System;

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
            //Quarterbacks
            Player joeBurrow = newPlayer("Joe Burrow", "LSU", "26,400,100");
            Player tuaTagoVailoa = newPlayer("Tua Tagovailoa", "Alabama", "20,300,100");
            Player justinHerbert = newPlayer("Justin Herbert", "Oregon", "17,420,300");
            Player jordanLove = newPlayer("Jordan Love", "Utah St.", "13,100,145");
            Player jakeFromm = newPlayer("Jake Fromm", "Georgia", "10,300,000");
            //Running Backs
            Player deandreSwift = newPlayer("D'Andre Swift", "Georgia", "24500100");
            Player jonathanTaylor = newPlayer("Jonathan Taylor", "Wisconsin", "9800200");
            Player jkDobbins = newPlayer("J.K. Dobbins", "Ohio State", "18700800");
            Player zackMoss = newPlayer("Zack Moss", "Utah", "15000000");
            Player camAtkers = newPlayer("Cam Atkers", "Florida St.", "11600400");
            // Wide Recievers
            string[] positions = { "Quarterbacks", "Running Backs" };
            // Mulri Dimensional Arrays for each player position
            String[,] quarterBacks = { 
                { joeBurrow.name.ToUpper(), tuaTagoVailoa.name, justinHerbert.name, jordanLove.name, jakeFromm.name },
                { "\t\t\t"+joeBurrow.school, "\t\t\t\t"+tuaTagoVailoa.school, "\t\t\t"+justinHerbert.school, "\t\t\t\t"+jordanLove.school, "\t\t\t"+jakeFromm.school},
                { "\t\t\t"+joeBurrow.price,"\t\t\t"+tuaTagoVailoa.price,"\t\t\t"+justinHerbert.price,"\t\t\t"+jordanLove.price, "\t\t\t"+jakeFromm.price  }
            };
            String[,] runningBacks =  {
                {deandreSwift.name, jonathanTaylor.name, jkDobbins.name,zackMoss.name,camAtkers.name },
                {"\t\t\t"+deandreSwift.school, "\t\t\t\t"+jonathanTaylor.school, "\t\t\t"+jkDobbins.school,"\t\t\t"+zackMoss.school,"\t\t\t\t"+camAtkers.school },
                {"\t\t\t"+deandreSwift.price, "\t\t\t"+jonathanTaylor.price, "\t\t\t\t"+jkDobbins.price,"\t\t\t"+zackMoss.price,"\t\t\t\t"+camAtkers.price }
            };
            displayQuarterbacks(quarterBacks, positions);
            displayRunningBacks(runningBacks, positions);

            Console.WriteLine("Who would you like to pick?");
            string coachPick = Console.ReadLine();
            coachPick.ToLower();
            // If logic for which player is picked
            if (coachPick == "joe burrow")
            {
                Console.WriteLine("You picked joe burrow.");
                joeBurrow.price.Split(",", 3);
                Int64.Parse(joeBurrow.price);
                

            }
        }

        static void welcomeMessage(double budget, int picks, double costEfficient)
        {
            Console.WriteLine("Welcome to the 2020 draft program!");
            Console.WriteLine("You can take up to " + picks + " picks for the draft without exceeding your " + budget + " budget.");
            Console.WriteLine("If you select any 3 players in the best, 2nd best, or 3rd best category under " + costEfficient + " , you get a cost effective message");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

        }
        public static void displayQuarterbacks(String[,] quarterbacks, string [] positions)
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
        } //displayQuarterbacks
        public static void displayRunningBacks(String[,] runningbacks, string[] positions)
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
        } //displayQuarterbacks

        public static Player newPlayer(string playerName, string playerSchool, string playerCost)
        {
           
           Player aPlayer =  new Player();
            aPlayer.name = "\t" + playerName + "\t\t";
            aPlayer.school = playerSchool  ;
            aPlayer.price =  playerCost ;
            aPlayer.bio = playerName + "\n" + "("+playerSchool+")" + "\n" + "$" + playerCost + "\n";
            //Console.WriteLine(aPlayer.bio);
            return aPlayer;

        }
    }

    class Player
    {
        public string name { get; set; }
        public string school { get; set; }
        public string price { get; set; }
        public string bio { get; set; }

    }
}
