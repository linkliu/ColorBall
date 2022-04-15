using System;
using System.Collections.Generic;
using ColorBall.Data;

namespace ColorBall.Mod
{
    internal class BallMachine
    {
        protected List<Ball> blueList = new List<Ball>();
        protected List<Ball> redList = new List<Ball>();

        public void InitBalls()
        {
            blueList.Clear();
            redList.Clear();
            blueList = generateBalls(1, GlobalConfig.BlueBallCapacity, BallColor.BLUE);
            redList = generateBalls(1, GlobalConfig.RedBallCapacity, BallColor.RED);
        }

        public void Shuffle()
        {
            blueList = shuffleBalls(blueList);
            redList = shuffleBalls(redList);
        }

        protected List<Ball> generateBalls(int startNum, int endNum, BallColor color)
        {
            List<Ball> list = new List<Ball>();
            for(int i = startNum; i <= endNum; i++)
            {
                list.Add(new Ball(i, color));
            }
            return list;
        }

        protected List<Ball> shuffleBalls(List<Ball> ballList)
        {
            if (ballList == null || ballList.Count == 0)
            {
                return new List<Ball>();
            }
            List<int> posList = new List<int>();
            List<int> newPosList = new List<int>();
            List<Ball> newBallList = new List<Ball>();
            for (int i = 0; i < ballList.Count; i++)
            {
                posList.Add(i);
            }
            while (posList.Count > 0)
            { 
                int pickPos = MathTools.Random(0, posList.Count - 1);
                newPosList.Add(posList[pickPos]);
                posList.RemoveAt(pickPos);
            }

            for (int i = 0; i < newPosList.Count; i++)
            { 
                newBallList.Add(ballList[newPosList[i]]);
            }
            return newBallList;
        }

        public void DebugPrint(BallColor color)
        {
            Console.WriteLine("{0}Ball infor:", color);
            List<Ball> ballList = color == BallColor.RED ? redList : blueList;
            for (int i = 0; i < ballList.Count; i++)
            {
                Console.Write("{0:d2}{1}", ballList[i].Number, (i < ballList.Count -1 ? ",":""));
            }
        }


    }

}
