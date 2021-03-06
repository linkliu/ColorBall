using System;
using ColorBall.View;
using System.Windows.Forms;
using ColorBall.Mod;
using ColorBall.Mod.Common;

namespace ColorBall
{
	public static class Program
	{
		[STAThread]
		static void Main()
		{
			MainFormManager mainFormManager = new MainFormManager();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			MainForm mainForm = new MainForm();
			mainFormManager.SetSynchronizingObject(mainForm);
			Application.Run(mainForm);
		}
	}
}
