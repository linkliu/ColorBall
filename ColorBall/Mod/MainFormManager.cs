using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System;
using ColorBall.Mod.Common;
using ColorBall.Data;

namespace ColorBall.Mod
{


	public class MainFormManager : BaseManager
	{
        private StringBuilder resultSB = new StringBuilder();
        private BallMachine ballMachine;
        private int randomIndex = 0;

		public MainFormManager()
		{
			Console.WriteLine("MainFormManager constract!");
		}

		public override void OnInitData()
		{
            ballMachine = new BallMachine();
            ballMachine.InitBalls();
            ballMachine.SetAlgorithm(MathTools.PickMethod1);
		}

		public override void OnInitEvents()
		{
		}

        protected void GenerateBall()
        {
            Reset();
            ballMachine.PickUpBalls();
            //TODO 启动定时器
        }

        protected void Reset()
        {
            randomIndex = 0;
            ballMachine.Clear();
        }

        protected bool IsRandomFinished()
        {

			return randomIndex > GlobalConfig.BlueNeed + GlobalConfig.RedNeed - 1;
        }
        
        protected Ball GetCurrentRandomBall()
        {
            if (randomIndex < GlobalConfig.RedNeed)
			{
				return ballMachine.PickedRedBalls[randomIndex];
			}
			else if (randomIndex < GlobalConfig.RedNeed + GlobalConfig.BlueNeed && randomIndex >= GlobalConfig.RedNeed)
			{
				return ballMachine.PickedBlueBalls[randomIndex - GlobalConfig.RedNeed];
			}
			else
			{
				return null;
			}
        }




	}
}
