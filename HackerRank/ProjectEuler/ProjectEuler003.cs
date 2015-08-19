using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProjectEuler
{
    /// <summary>
    /// Project Euler #3: Largest prime factor
    /// </summary>
    /// <see href="https://www.hackerrank.com/contests/projecteuler/challenges/euler003"/>
    public class ProjectEuler003
    {
        static ulong CalculateLargestPrimeFactor(ulong n)
        {
            ulong d = 2;
            var factors = new List<ulong>();
         
            while (d <= Math.Sqrt(n))
            {
                while (n % d == 0)
                {
                    n /= d;
                    factors.Add(d);
                }
                d++;
            }
            factors.Add(n);

            return factors.Max();
        }
        public void Main()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                ulong N = Convert.ToUInt64(Console.ReadLine());
                ulong sum = CalculateLargestPrimeFactor(N);
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
                ulong sum = CalculateLargestPrimeFactor(N);
                result.Add((sum).ToString());
            }
            return result;
        }


    }
}
