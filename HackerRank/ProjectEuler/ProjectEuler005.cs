using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProjectEuler
{
    /// <summary>
    /// Project Euler #5: Smallest multiple
    /// </summary>
    /// <see href="https://www.hackerrank.com/contests/projecteuler/challenges/euler005"/>
    public class ProjectEuler005
    {
        static long LCM(long[] numbers)
        {
            return numbers.Aggregate(lcm);
        }
        static long lcm(long a, long b)
        {
            return Math.Abs(a * b) / GCD(a, b);
        }
        static long GCD(long a, long b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        static long CalculateSmallestMultiple(int n)
        {
            long[] numbers=new long[n];
            for (int i = 0; i < n;i++ )
            {
                numbers[i] = i + 1;
            }
            var val = LCM(numbers);
             
            return val;
        }

     
        public void Main()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var N = Convert.ToInt32(Console.ReadLine());
                var res = CalculateSmallestMultiple(Convert.ToInt32(N));
                Console.WriteLine(res.ToString());
            }
        }


        public List<string> Main(List<string> args)
        {
            var result = new List<string>();
            int T = Convert.ToInt32(args[0]);
            for (int i = 0; i < T; i++)
            {
                ulong N = Convert.ToUInt64(args[i + 1]);
                var res = CalculateSmallestMultiple(Convert.ToInt32(N));
                result.Add((res).ToString());
            }
            return result;
        }


    }
}
