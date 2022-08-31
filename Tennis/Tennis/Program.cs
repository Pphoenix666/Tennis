using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis
{
    internal class Program
    {
        public static int scP1s1 = 0;
        public static int scP2s1 = 0;
        public static int scP1s2 = 0;
        public static int scP2s2 = 0;
        public static int scP1s3 = 0;
        public static int scP2s3 = 0;

        public static int setPlaying = 0;

        public static int p1Pts = 0;
        public static int p2Pts = 0;
        public static int p1SetPts = 0;
        public static int p2SetPts = 0;


        public static string scP1 = "love";
        public static string scP2 = "love";


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
                Reset();
                Main();
            }
            else if (userInput == "1" || userInput == "2")
            {
                PlayerGetsAPoint(userInput);
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

        private static void PlayerGetsAPoint(string player)
        {
            if(player == "1")
            {
                ++p1Pts;

                if (p1Pts == 4 && p2Pts < 3)
                {
                    CheckSet(player);
                }
                else if(p1Pts <= 4 && p2Pts <= 3)
                {
                    Score();
                }
                else if (p1Pts == 4 && p2Pts == 4)
                {
                    --p2Pts;
                    Score();
                }
                else
                {
                    CheckSet(player);
                }
            }
            else
            {
                ++p2Pts;

                if (p2Pts == 4 && p1Pts < 3)
                {
                    CheckSet(player);
                }
                else if (p2Pts <= 4 && p1Pts <= 3)
                {
                    Score();
                }
                else if (p2Pts == 4 && p1Pts == 4)
                {
                    --p1Pts;
                    Score();
                }
                else
                {
                    CheckSet(player);
                }
            }
        }

        private static void CheckSet(string player)
        {
            if(setPlaying < 2)
            {
                if(player == "1")
                {
                    p1Pts = 0;
                    p2Pts = 0;

                    p1SetPts = (setPlaying == 0) ? ++scP1s1 : ++scP1s2;

                    if ((p1SetPts == 7 && p2SetPts == 6) || (p1SetPts == 6 && Math.Abs(p1SetPts - p2SetPts) >= 2))
                    {
                        if (scP1s1 > scP2s1 && setPlaying == 1)
                        {
                            EndGame(player);
                        }
                        else
                        {
                            setPlaying++;
                            p1SetPts = 0;
                            p2SetPts = 0;
                            Score();
                        }
                    }
                    else
                    {
                        Score();
                    }
                }
                else
                {
                    p1Pts = 0;
                    p2Pts = 0;

                    p2SetPts = (setPlaying == 0) ? ++scP2s1 : ++scP2s2;

                    if ((p2SetPts == 7 && p1SetPts == 6) || (p2SetPts == 6 && Math.Abs(p2SetPts - p1SetPts) >= 2))
                    {
                        if (scP2s1 > scP1s1 && setPlaying == 1)
                        {
                            EndGame(player);
                        }
                        else
                        {
                            setPlaying++;
                            p1SetPts = 0;
                            p2SetPts = 0;
                            Score();
                        }
                    }
                    else
                    {
                        Score();
                    }
                }
            }
            else
            {
                if (player == "1")
                {
                    scP1s3++;

                    if (scP1s3 == 7)
                    {
                        EndGame(player);
                    }
                    else if (scP1s3 == 6 && Math.Abs(scP1s3 - scP2s3) >= 2)
                    {
                        EndGame(player);
                    }
                    else
                    {
                        Score();
                    }
                }
                else
                {
                    scP2s3++;

                    if (scP2s3 == 7)
                    {
                        EndGame(player);
                    }
                    else if (scP2s3 == 6 && Math.Abs(scP2s3 - scP1s3) >= 2)
                    {
                        EndGame(player);
                    }
                    else
                    {
                        Score();
                    }
                }
            }
        }

        private static void EndGame(string player)
        {
            Console.WriteLine("-----------------------------");
            Score();
            Console.WriteLine("");
            Console.WriteLine("Player " + player + " wins !");
            Reset();
        }

        private static void Reset()
        {
            scP1s1 = 0;
            scP2s1 = 0;
            scP1s2 = 0;
            scP2s2 = 0;
            scP1s3 = 0;
            scP2s3 = 0;

            setPlaying = 0;

            p1Pts = 0;
            p2Pts = 0;
            p1SetPts = 0;
            p2SetPts = 0;

            scP1 = "love";
            scP2 = "love";

            Console.WriteLine("-----------------------------");
            Console.WriteLine("");
            Console.WriteLine("New Game !");
            Console.WriteLine("");
            Score();
            Console.WriteLine("");
            Main();
        }

        private static void Score()
        {
            scP1 = valToScore(p1Pts);
            scP2 = valToScore(p2Pts);
            Console.WriteLine("Joueur 1 : " + scP1s1.ToString() + " | " + scP1s2.ToString() + " | " + scP1s3.ToString() + " — " + scP1);
            Console.WriteLine("Joueur 2 : " + scP2s1.ToString() + " | " + scP2s2.ToString() + " | " + scP2s3.ToString() + " — " + scP2);
        }

        private static string valToScore(int pts)
        {
            switch (pts)
            {
                case 1: return "15";
                case 2: return "30";
                case 3: return "40";
                case 4: return "Av";
                default: return "love";
            }
        }


    }
}
