using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Class
{
    internal class Score : Set
    {
        public int p1SetPts = 0;
        public int p2SetPts = 0;

        public static string scP1 = "love";
        public static string scP2 = "love";

        public static void newScore(int p1Pts, int p2Pts)
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


        public static void ResetScore()
        {
            scP1 = "love";
            scP2 = "love";
        }
    }
}
