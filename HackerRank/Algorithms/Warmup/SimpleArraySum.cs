using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    /// <summary>
    /// Algorithms -> Warmup -> Simple Array Sum
    /// </summary>
    /// <see href="https://www.hackerrank.com/challenges/simple-array-sum"/>
    public class SimpleArraySum
    {
        public void Main()
        {
            var line1 = Console.ReadLine();
            int N = Convert.ToInt32(line1.Split(' ')[0]);
            List<int> A = Console.ReadLine().Split(' ').ToList().Select(int.Parse).ToList();

            var sum = A.Sum();

            Console.WriteLine(sum);
        }

        public List<string> Main(List<string> args)
        {
            int N = Convert.ToInt32(args[0].Split(' ')[0]);
            List<int> A = args[1].Split(' ').ToList().Select(int.Parse).ToList();
            var result = new List<string>();

            var sum = A.Sum();

            result.Add(sum.ToString());
            return result;
        }


    }
}
