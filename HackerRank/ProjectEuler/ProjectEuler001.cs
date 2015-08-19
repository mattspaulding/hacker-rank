using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProjectEuler
{
    /// <summary>
    /// Project Euler #1: Multiples of 3 and 5
    /// </summary>
    /// <see href="https://www.hackerrank.com/contests/projecteuler/challenges/euler001"/>
    public class ProjectEuler001
    {
        static ulong CalculateArithmeticProgressionSum(ulong n, ulong a)
        {
            ulong sum, val;

            val = n / a;
            if (n % a == 0)
                val--;
            if (val % 2 == 0)
                sum = (val / 2) * (a + a * val);
            else
                sum = val * ((a + a * val) / 2);
            return sum;
        }
        public void Main()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                ulong N = Convert.ToUInt64(Console.ReadLine());

                //This was my original answer O(n) too slow
                //int sum = 0;
                //for (int j = 0; j < N; j++)
                //{           
                //if (j % 3 == 0 || j % 5 == 0)
                //    sum += j;
                //}


                //This is the O(1) solution using arithmetic progression n(a1+an)/2
                ulong sum = 0;
                sum += CalculateArithmeticProgressionSum(N, 3);
                sum += CalculateArithmeticProgressionSum(N, 5);
                sum -= CalculateArithmeticProgressionSum(N, 15);


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
                //This was my original answer O(n) too slow
                //int sum = 0;
                //for (int j = 0; j < N; j++)
                //{           
                //if (j % 3 == 0 || j % 5 == 0)
                //    sum += j;
                //}


                //This is the O(1) solution using arithmetic progression n(a1+an)/2

                ulong sum = 0;
                sum += CalculateArithmeticProgressionSum(N, 3);
                sum += CalculateArithmeticProgressionSum(N, 5);
                sum -= CalculateArithmeticProgressionSum(N, 15);

             
                result.Add((sum).ToString());
            }
            return result;
        }


    }
}
