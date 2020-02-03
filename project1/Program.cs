using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfPicks = 5;
            double allowance = 95000000;
            double costEffective = 65000000;
            string[,] playerTable = { };
            
            welcomeMessage(allowance, amountOfPicks, costEffective);

        }

        static void welcomeMessage(double budget, int picks, double costEfficient)
        {
            Console.WriteLine("Welcome to the 2020 draft program!");
            Console.WriteLine("You can take up to " + picks + " picks for the draft without exceeding your "+ budget + " budget.");
            Console.WriteLine("If you select any 3 players in the best, 2nd best, or 3rd best category under " + costEfficient + "you get a cost effective message");


        }
        public static void displayPlayers(string[,] players)
        {
            Console.WriteLine($"\t The best \t\t 2nd best \t\t 3rd best \t\t 4th best \t\t 5th best ");
            for (var i = 0; i < players.GetLength(0); i++)
            {
                Console.Write($"{i} \t");
                for (var x = 0; x < players.GetLength(1); x++)
                {
                    Console.Write($"{players[i, x]} \t");
                }
                Console.WriteLine("");
            }
        } //displayPlayers

        public static string newPlayer(string name, string playerSchool, int playerCost)
        {
            Player name;
            name = new Player();
            name.school = playerSchool;
            name.price = playerCost;
            playerCost.Console.ForegroundColor(green);
            Console.WriteLine(name + "\n" + playerSchool + "\n" + playerCost);

        }
    }

    class Player
    {
        public string name  { get; set; }
        public string school { get; set; }
        public int price { get; set; }

    }
}
