using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
   public class SolveMeFirst
    {
        static int solveMeFirst(int a, int b)
        {
            return a + b;
        }
        public void Main()
        {
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = solveMeFirst(val1, val2);
            Console.WriteLine(sum);
        }

        public List<string> Main(List<string> args)
        {
            var result = new List<string>();
            int val1 = Convert.ToInt32(args[0]);
            int val2 = Convert.ToInt32(args[1]);
            int sum = solveMeFirst(val1, val2);
            result.Add(sum.ToString());
            return result;
        }


    }
}
