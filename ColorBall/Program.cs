using System;
using ColorBall.View;
using System.Windows.Forms;
using ColorBall.Mod;
using ColorBall.Mod.Common;

namespace ColorBall
{
	internal static class Program
	{
		[STAThread]
		static void Main()
		{

			while (true)
			{
				ConsoleKeyInfo	keyInfo = Console.ReadKey();
				if (keyInfo.Key == ConsoleKey.D1)
				{
					EventManager.Instance.AddEventListener("Add", Add);
				}
				else if (keyInfo.Key == ConsoleKey.D2)
				{
					EventManager.Instance.AddEventListener("Sub", Sub);
				}
				else if (keyInfo.Key == ConsoleKey.D3)
				{
					EventManager.Instance.RemoveEventListenter("Add", Add);
				}
				else if (keyInfo.Key == ConsoleKey.D4)
				{
					EventManager.Instance.RemoveEventListenter("Sub", Sub);
				}
				else if (keyInfo.Key == ConsoleKey.D5)
				{
					DataArgs data = new DataArgs();
					data.Set("add", 5);
					EventManager.Instance.EventFire("Add", data);
				}
				else if (keyInfo.Key == ConsoleKey.D6)
				{
					DataArgs data = new DataArgs();
					data.Set("sub", 6);
					EventManager.Instance.EventFire("Sub", data);
				}
				else if (keyInfo.Key == ConsoleKey.D7)
				{ 
					EventManager.Instance.AddEventListener("Add", Mul);
				}
			}
		}


		public static void Add(DataArgs a)
		{
			Console.WriteLine("Add a=" + a.Get("add"));
		}

		public static void Sub(DataArgs b)
		{ 
			Console.WriteLine("Sub b=" + b.Get("sub"));
		}
		public static void Mul(DataArgs c)
		{
			Console.WriteLine("Add c=" + c.Get("mul"));
		}
	}
}
