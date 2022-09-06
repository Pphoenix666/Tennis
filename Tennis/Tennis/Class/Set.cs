using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Class
{
    internal class Set
    {
        public static int scP1s1 = 0;
        public static int scP2s1 = 0;
        public static int scP1s2 = 0;
        public static int scP2s2 = 0;
        public static int scP1s3 = 0;
        public static int scP2s3 = 0;

        public static int setPlaying = 0;

        public static Score score = new Score();

        public static void CheckSet(string player)
        {
            if (setPlaying < 2)
            {
                if (player == "1")
                {
                    Game.p1Pts = 0;
                    Game.p2Pts = 0;

                    score.p1SetPts = (setPlaying == 0) ? ++scP1s1 : ++scP1s2;

                    if ((score.p1SetPts == 7 && score.p2SetPts == 6) || (score.p1SetPts == 6 && Math.Abs(score.p1SetPts - score.p2SetPts) >= 2))
                    {
                        if (scP1s1 > scP2s1 && setPlaying == 1)
                        {
                            Game.EndGame(player);
                        }
                        else
                        {
                            setPlaying++;
                            score.p1SetPts = 0;
                            score.p2SetPts = 0;
                            Score.newScore(Game.p1Pts, Game.p2Pts);
                        }
                    }
                    else
                    {
                        Score.newScore(Game.p1Pts, Game.p2Pts);
                    }
                }
                else
                {
                    Game.p1Pts = 0;
                    Game.p2Pts = 0;

                    score.p2SetPts = (setPlaying == 0) ? ++scP2s1 : ++scP2s2;

                    if ((score.p2SetPts == 7 && score.p1SetPts == 6) || (score.p2SetPts == 6 && Math.Abs(score.p2SetPts - score.p1SetPts) >= 2))
                    {
                        if (scP2s1 > scP1s1 && setPlaying == 1)
                        {
                            Game.EndGame(player);
                        }
                        else
                        {
                            setPlaying++;
                            score.p1SetPts = 0;
                            score.p2SetPts = 0;
                            Score.newScore(Game.p1Pts, Game.p2Pts);
                        }
                    }
                    else
                    {
                        Score.newScore(Game.p1Pts, Game.p2Pts);
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
                        Game.EndGame(player);
                    }
                    else if (scP1s3 == 6 && Math.Abs(scP1s3 - scP2s3) >= 2)
                    {
                        Game.EndGame(player);
                    }
                    else
                    {
                        Score.newScore(Game.p1Pts, Game.p2Pts);
                    }
                }
                else
                {
                    scP2s3++;

                    if (scP2s3 == 7)
                    {
                        Game.EndGame(player);
                    }
                    else if (scP2s3 == 6 && Math.Abs(scP2s3 - scP1s3) >= 2)
                    {
                        Game.EndGame(player);
                    }
                    else
                    {
                        Score.newScore(Game.p1Pts, Game.p2Pts);
                    }
                }
            }
        }

        public static void ResetSet()
        {
            scP1s1 = 0;
            scP2s1 = 0;
            scP1s2 = 0;
            scP2s2 = 0;
            scP1s3 = 0;
            scP2s3 = 0;

            setPlaying = 0;

            score.p1SetPts = 0;
            score.p2SetPts = 0;            
        }
    }    
}
