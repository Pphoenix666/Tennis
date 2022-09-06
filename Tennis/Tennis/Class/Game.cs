using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Class
{
    internal class Game
    {
        public static int p1Pts = 0;
        public static int p2Pts = 0;

        public static void PlayerGetsAPoint(string player)
        {
            if (player == "1")
            {
                ++p1Pts;

                if (p1Pts == 4 && p2Pts < 3)
                {
                    Set.CheckSet(player);
                }
                else if (p1Pts <= 4 && p2Pts <= 3)
                {
                    Score.newScore(p1Pts, p2Pts);
                }
                else if (p1Pts == 4 && p2Pts == 4)
                {
                    --p2Pts;
                    Score.newScore(p1Pts, p2Pts);
                }
                else
                {
                    Set.CheckSet(player);
                }
            }
            else
            {
                ++p2Pts;

                if (p2Pts == 4 && p1Pts < 3)
                {
                    Set.CheckSet(player);
                }
                else if (p2Pts <= 4 && p1Pts <= 3)
                {
                    Score.newScore(p1Pts, p2Pts);
                }
                else if (p2Pts == 4 && p1Pts == 4)
                {
                    --p1Pts;
                    Score.newScore(p1Pts, p2Pts);
                }
                else
                {
                    Set.CheckSet(player);
                }
            }
        }

        public static void EndGame(string player)
        {
            Console.WriteLine("-----------------------------");
            Score.newScore(p1Pts, p2Pts);
            Console.WriteLine("");
            Console.WriteLine("Player " + player + " wins !");
            ResetGame();
        }

        public static void ResetGame()
        {

            p1Pts = 0;
            p2Pts = 0;

            Set.ResetSet();
            Score.ResetScore();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("");
            Console.WriteLine("New Game !");
            Console.WriteLine("");
            Score.newScore(p1Pts, p2Pts);
            Console.WriteLine("");
        }
    }
}
