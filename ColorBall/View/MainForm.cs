using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ColorBall.Mod;
using ColorBall.Data;
using System.Text;
using ColorBall.Mod.Common;

namespace ColorBall.View
{
	public partial class MainForm : Form
	{
		private List<Label> redLabelList = null;
		private List<Label> blueLabelList = null;
		public MainForm()
		{
			CheckForIllegalCrossThreadCalls = false;
			InitializeComponent();
			InitEvents();
			InitUIComponents();
		}

		protected void InitEvents()
		{
			EventManager.Instance.AddEventListener(CommonEvent.ON_RANDOM_TICK_EVENT, OnRandomBallTick);
			EventManager.Instance.AddEventListener(CommonEvent.ON_GENERATE_BALL_TICK_EVENT, OnGenerateBallTick);
			EventManager.Instance.AddEventListener(CommonEvent.ON_GET_RESULT_EVENT, OnGetResult);
		}
		protected void OnUpdate()
		{ 
		}
		protected void InitUIComponents()
		{
			redLabelList = new List<Label>() { Ball1label, Ball2label, Ball3label, Ball4label, Ball5label, Ball6label };
			blueLabelList = new List<Label>() { Ball7label};
		}
		
		public void OnGetResult(DataArgs data)
		{
			ResultRichTextBox.Text = (string)data.Get("result");
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
			EventManager.Instance.EventFire(CommonEvent.ON_GENERATE_BALL_EVENT, null);
		}
		private void ResetButton_Click(object sender, EventArgs e)
		{
			EventManager.Instance.EventFire(CommonEvent.ON_RESET_BALLMACHINE_EVENT, null);
			ResetUI();
		}

		protected Label GetBallLabel(int index)
		{
			return null;
		}

		public Label GetRandomBallLabel(int randomIndex)
		{
			Label ballLabel;
			if (randomIndex < GlobalConfig.RedNeed)
			{
				ballLabel = redLabelList[randomIndex];
			}
			else if (randomIndex < GlobalConfig.RedNeed + GlobalConfig.BlueNeed && randomIndex >= GlobalConfig.RedNeed)
			{
				ballLabel = blueLabelList[randomIndex - GlobalConfig.RedNeed];
			}
			else
			{
				ballLabel = null;
			}
			return ballLabel;
		}

		private void OnRandomBallTick(DataArgs data)
		{
			if (data == null)
			{
				return;
			}
			Label ballLabel = GetRandomBallLabel((int)data.Get("randomIndex"));
			if (ballLabel != null)
			{
				ballLabel.Text = data.Get("randomNum").ToString().PadLeft(2, '0');
			}
		}
		private void OnGenerateBallTick(DataArgs data)
		{
			if (data == null)
			{
				return;
			}
			Label selectLabel = GetRandomBallLabel((int)data.Get("randomIndex"));
			selectLabel.Text = ((Ball)data.Get("ball")).Number.ToString().PadLeft(2, '0');
		}
	}
}
