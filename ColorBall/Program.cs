using System;
using ColorBall.Mod;

namespace ColorBall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BallMachine machine = new BallMachine();
            machine.InitBalls();
            while (true)
            {
                Console.WriteLine("选择你的操作，C:选择不同随机算法，G：生成双色球，Q退出");
                ConsoleKeyInfo Key = Console.ReadKey();
                if (Key.Key == ConsoleKey.G)
                {
                    machine.Clear();
                    machine.PickUpBalls();
                    machine.DebugPrintBalls();
                }
                else if (Key.Key == ConsoleKey.Q)
                {
                    break;
                }
                else if (Key.Key == ConsoleKey.C)
                {
                    Console.WriteLine("请选择随机算法：算法1[1]， 算法2[2]");
                    ConsoleKeyInfo funKey = Console.ReadKey();
                    if (funKey.Key == ConsoleKey.D1)
                    {
                        machine.SetAlgorithm(MathTools.PickMethod1);
                        Console.WriteLine("已选算法1");
                    }
                    else if (funKey.Key == ConsoleKey.D2)
                    {
                        machine.SetAlgorithm(MathTools.PickMethod2);
                        Console.WriteLine("已选算法2");
                    }
                    else
                    { 
                        Console.WriteLine("请输入正确的数字");
                    }
                }
            }
        }
    }
}
