using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ColorBall.Mod;
using ColorBall.Data;
using System.Text;

namespace ColorBall.View
{
	public partial class MainForm : Form
	{
		private List<Label> redLabelList = null;
		private List<Label> blueLabelList = null;
		public MainForm()
		{
			InitializeComponent();
			InitUIComponents();
		}
		protected void OnUpdate()
		{ 
		}
		protected void InitUIComponents()
		{
			redLabelList = new List<Label>() { Ball1label, Ball2label, Ball3label, Ball4label, Ball5label, Ball6label };
			blueLabelList = new List<Label>() { Ball7label};
		}
		
		protected void SetResultText(List<Ball> redBallList, List<Ball> blueBallList)
		{
			//resultSB.Clear();
			//for (int i = 0; i < redBallList.Count; i++)
			//{
			//	resultSB.Append(redBallList[i].Number.ToString().PadLeft(2, '0'));
			//	resultSB.Append(",");
			//}
			//for (int i = 0; i < blueBallList.Count; i++)
			//{
			//	resultSB.Append(blueBallList[i].Number.ToString().PadLeft(2, '0'));
			//	if (i < blueBallList.Count - 1)
			//	{
			//		resultSB.Append(",");
			//	}
			//}
			//ResultRichTextBox.Text = resultSB.ToString();
		}
		protected void ResetUI()
		{ 
			for (int i = 0; i < redLabelList.Count; i++)
			{
				Label lable = redLabelList[i];
				lable.Text = "00";
			}
			for (int i = 0; i < blueLabelList.Count; i++)
			{
				Label label = blueLabelList[i];
				label.Text = "00";
			}
			ResultRichTextBox.Text = "00,00,00,00,00,00,00";
		}
	   
		private void GenerateButton_Click(object sender, EventArgs e)
		{
		}

		private void ResetButton_Click(object sender, EventArgs e)
		{
		}

		protected Label GetBallLabel(int index)
		{
			return null;
		}

		private void RandomTimer_Tick(object sender, EventArgs e)
		{
			//Label ballLabel;
			//int randomNum;
			//if (randomIndex < GlobalConfig.RedNeed)
			//{
			//	ballLabel = redLabelList[randomIndex];
			//	randomNum = MathTools.Random(1, GlobalConfig.RedBallCapacity);
			//}
			//else if (randomIndex < GlobalConfig.RedNeed + GlobalConfig.BlueNeed && randomIndex >= GlobalConfig.RedNeed)
			//{
			//	ballLabel = blueLabelList[randomIndex - GlobalConfig.RedNeed];
			//	randomNum = MathTools.Random(1, GlobalConfig.BlueBallCapacity);
			//}
			//else
			//{
			//	throw new Exception("ballLabel is null");
			//}
			//ballLabel.Text = randomNum.ToString().PadLeft(2, '0');
		}

		private void GenerateTimer_Tick(object sender, EventArgs e)
		{
			//RandomTimer.Stop();
			//Ball selectBall = GetCurrentRandomBall();
			//Label selectLabel = GetCurrentRandomBallLabel();
			//selectLabel.Text = selectBall.Number.ToString().PadLeft(2, '0');
			//randomIndex++;
			//if (IsRandomFinished())
			//{ 
			//	GenerateTimer.Stop();
			//	SetResultText(ballMachine.PickedRedBalls, ballMachine.PickedBlueBalls);
			//	return;
			//}
			//RandomTimer.Start();
		}
	}
}
