using System;
using System.Collections.Generic;
using ColorBall.Data;

namespace ColorBall.Mod
{
    public class BallMachine
    {
        protected List<Ball> blueBallList = new List<Ball>();
        protected List<Ball> redBallList = new List<Ball>();
        protected List<Ball> pickedBlueBalls = new List<Ball>();
        protected List<Ball> pickedRedBalls = new List<Ball>();
        public delegate List<int> pickAlgorithmFun(int starNum, int endNum, int needCount);
        protected pickAlgorithmFun pickFun = MathTools.PickMethod1;

        public List<Ball> RedList 
        { 
            get 
            { return blueBallList; } 
        }

        public List<Ball> BlueList
        {
            get { return redBallList; }
        }

        public List<Ball> PickedBlueBalls
        { 
           get{ return pickedBlueBalls; }
        }
        public List<Ball> PickedRedBalls
        {
            get { return pickedRedBalls; }
        }
        public void InitBalls()
        {
            blueBallList.Clear();
            redBallList.Clear();
            blueBallList = generateBalls(1, GlobalConfig.BlueBallCapacity, BallColor.BLUE);
            redBallList = generateBalls(1, GlobalConfig.RedBallCapacity, BallColor.RED);
        }

        public void SetAlgorithm(pickAlgorithmFun func)
        {
            pickFun = func;
        }

        public void PickUpBalls()
        {
            pickedBlueBalls = pickUpBalls(blueBallList, GlobalConfig.BlueNeed);
            pickedRedBalls = pickUpBalls(redBallList, GlobalConfig.RedNeed);
        }

        public void Clear()
        { 
            pickedRedBalls.Clear();
            pickedBlueBalls.Clear();
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

        protected List<Ball> pickUpBalls(List<Ball> ballList, int pickNum)
        {
            if (ballList == null || ballList.Count == 0)
            {
                return new List<Ball>();
            }
            List<int> posList = pickFun(0, ballList.Count -1, pickNum);
            List<Ball> newBallList = new List<Ball>();
            for (int i = 0; i < posList.Count; i++)
            {
                newBallList.Add(ballList[posList[i]]);
            }
            return newBallList;
        }

        public void DebugPrint(BallColor color)
        {
            Console.WriteLine("{0}Ball infor:", color);
            List<Ball> ballList = color == BallColor.RED ? redBallList : blueBallList;
            for (int i = 0; i < ballList.Count; i++)
            {
                Console.Write("{0:d2}{1}", ballList[i].Number, (i < ballList.Count -1 ? ",":""));
            }
        }

        public void DebugPrintBalls()
        {
            Console.WriteLine("RedBalls:");
            for (int i = 0; i < pickedRedBalls.Count; i++)
            {
                Console.Write("{0:d2}{1}", pickedRedBalls[i].Number, (i < pickedRedBalls.Count - 1 ? "," : ""));
            }
            Console.WriteLine();
            Console.WriteLine("BlueBall:");
            for (int i = 0; i < pickedBlueBalls.Count; i++)
            {
                Console.Write("{0:d2}{1}", pickedBlueBalls[i].Number, (i < pickedBlueBalls.Count - 1 ? "," : ""));
            }
            Console.WriteLine();
        }


    }

}
