using HackerRank.Algorithms.Warmup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hacker Rank Problems");
            Console.WriteLine("============================");
            Console.WriteLine("1. SolveMeFirst");
            Console.WriteLine("3. Utopian Tree");
            Console.WriteLine("4. Maximizing XOR");
            Console.WriteLine("============================");

            int input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    new SolveMeFirst().Main();
                    break;
                case 3:
                    new UtopianTree().Main();
                    break;
                case 4:
                    new MaximizingXor().Main();
                    break;
                default:
                    Console.WriteLine("bad input");
                    break;
            }
            Main(null);
        }
    }
}
