using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ColorBall.Mod;

namespace ColorBall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BallMachine machine = new BallMachine();
            machine.InitBalls();
            Console.WriteLine("Before shuffle!");
            machine.DebugPrint(Data.BallColor.BLUE);
            Console.WriteLine();
            machine.DebugPrint(Data.BallColor.RED);
            Console.WriteLine();
            machine.Shuffle();
            Console.WriteLine("After shuffle!");
            machine.DebugPrint(Data.BallColor.BLUE);
            Console.WriteLine();
            machine.DebugPrint(Data.BallColor.RED);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
