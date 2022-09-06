using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennis.Class;

namespace Tennis
{
    internal class Tennis
    {
        static void Main()
        {
            Console.WriteLine("Please input C or c to close and R or r to reset");
            Console.WriteLine("For player 1 to score a point please input 1, otherwise 2 for player 2 ");

            string userInput = Console.ReadLine();

            if (userInput == "c" || userInput == "C")
            {
                return;
            }
            else if(userInput == "r" || userInput == "R")
            {
                Game.ResetGame();
                Main();
            }
            else if (userInput == "1" || userInput == "2")
            {
                Game.PlayerGetsAPoint(userInput);
                Main();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid input, please only type the options sepecified above and below, thank you !");
                Console.WriteLine("");
                Main();
            }
        }


    }
}
