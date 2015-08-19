using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProjectEuler
{
    /// <summary>
    /// Project Euler #2: Even Fibonacci numbers
    /// </summary>
    /// <see href="https://www.hackerrank.com/contests/projecteuler/challenges/euler002"/>
    public class ProjectEuler002
    {
        static ulong CalculateEvenFibonacciNumberSum(ulong n)
        {
            ulong sum = 0, current = 2, previous = 1;

            while (current < n)
            {
                if (current % 2 == 0)
                    sum += current;
                var temp = current + previous;
                previous = current;
                current = temp;
              }
            return sum;
        }
        public void Main()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                ulong N = Convert.ToUInt64(Console.ReadLine());
                ulong sum = CalculateEvenFibonacciNumberSum(N);
                Console.WriteLine(sum.ToString());
            }
        }


        public List<string> Main(List<string> args)
        {
            var result = new List<string>();
            int T = Convert.ToInt32(args[0]);
            for (int i = 0; i < T; i++)
            {
                ulong N = Convert.ToUInt64(args[i + 1]);
                ulong sum = CalculateEvenFibonacciNumberSum(N);
                result.Add((sum).ToString());
            }
            return result;
        }


    }
}
