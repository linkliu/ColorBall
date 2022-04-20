using System.Collections.Generic;
using System.Text;
using System.Timers;
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
		private Timer randomTimer, generateTimer;

		public MainFormManager()
		{
			Console.WriteLine("MainFormManager constract!");
		}

		public void SetSynchronizingObject(System.Windows.Forms.Form form)
		{
			if (randomTimer != null)
			{ 
				randomTimer.SynchronizingObject = form;
			}
			if (generateTimer != null)
			{ 
				generateTimer.SynchronizingObject = form;
			}
		}

		public override void OnInitData()
		{
            ballMachine = new BallMachine();
            ballMachine.InitBalls();
            ballMachine.SetAlgorithm(MathTools.PickMethod1);
			randomTimer = new Timer();
			generateTimer = new Timer();
			randomTimer.Interval = GlobalConfig.RandomTimerInterval;
			generateTimer.Interval = GlobalConfig.GenerateTimerInterval;
			randomTimer.Elapsed += OnRandomTimerTick;
			generateTimer.Elapsed += OnGenerateTimerTick;
		}

		public override void OnInitEvents()
		{
			EventManager.Instance.AddEventListener(CommonEvent.ON_GENERATE_BALL_EVENT, (data) => 
			{
				GenerateBall();
			});
			EventManager.Instance.AddEventListener(CommonEvent.ON_RESET_BALLMACHINE_EVENT, (data) => 
			{
				Reset();
			});
		}

        protected void GenerateBall()
        {
            Reset();
            ballMachine.PickUpBalls();
			randomTimer.Start();
			generateTimer.Start();
        }

        protected void Reset()
        {
            randomIndex = 0;
            ballMachine.Clear();
			randomTimer.Stop();
			generateTimer.Stop();
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

		private DataArgs randomTickData = new DataArgs();//主要是为了避免频繁的new操作

		protected void OnRandomTimerTick(object sender, ElapsedEventArgs e)
		{
			int randomNum = 0;
			if (randomIndex < GlobalConfig.RedNeed)
			{
				randomNum = MathTools.Random(1, GlobalConfig.RedBallCapacity);
			}
			else if (randomIndex < GlobalConfig.RedNeed + GlobalConfig.BlueNeed && randomIndex >= GlobalConfig.RedNeed)
			{
				randomNum = MathTools.Random(1, GlobalConfig.BlueBallCapacity);
			}
			randomTickData.Set("randomIndex", randomIndex);
			randomTickData.Set("randomNum", randomNum);
			EventManager.Instance.EventFire(CommonEvent.ON_RANDOM_TICK_EVENT, randomTickData);
		}

		private DataArgs generateTickData = new DataArgs();
		private DataArgs resultData = new DataArgs();
		protected void OnGenerateTimerTick(object sender, ElapsedEventArgs e)
		{ 
			randomTimer.Stop();
			Ball selectBall = GetCurrentRandomBall();
			generateTickData.Set("randomIndex", randomIndex);
			generateTickData.Set("ball", selectBall);
			EventManager.Instance.EventFire(CommonEvent.ON_GENERATE_BALL_TICK_EVENT, generateTickData);
			randomIndex++;
			if (IsRandomFinished())
			{
				generateTimer.Stop();
				resultData.Set("result", GetResultString());
				EventManager.Instance.EventFire(CommonEvent.ON_GET_RESULT_EVENT, resultData);
				return;
			}
			randomTimer.Start();

		}

		protected string GetResultString()
		{
			resultSB.Clear();
			for (int i = 0; i < ballMachine.PickedRedBalls.Count; i++)
			{
				Ball ball = ballMachine.PickedRedBalls[i];
				resultSB.Append(ball.Number.ToString().PadLeft(2, '0'));
				resultSB.Append(",");
			}
			for (int i = 0; i < ballMachine.PickedBlueBalls.Count; i++)
			{
				Ball ball = ballMachine.PickedBlueBalls[i];
				resultSB.Append(ball.Number.ToString().PadLeft(2, '0'));
				if (i < ballMachine.PickedBlueBalls.Count - 1)
				{
					resultSB.Append(",");
				}
			}
			return resultSB.ToString();
		}




	}
}
