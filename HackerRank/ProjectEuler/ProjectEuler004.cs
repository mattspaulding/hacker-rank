using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.ProjectEuler
{
    /// <summary>
    /// Project Euler #4: Largest palindrome product
    /// </summary>
    /// <see href="https://www.hackerrank.com/contests/projecteuler/challenges/euler004"/>
    public class ProjectEuler004
    {
        static List<ulong> CalculatePalindromes()
        {
             var palindromes = new List<ulong>();

            for (int i = 100; i < 1000; i++)
            {
                for (int j = i; j < 1000; j++)
                {
                    var str = (i * j).ToString();
                    char[] charArray = str.ToCharArray();
                    Array.Reverse(charArray);
                    var rev= new string(charArray);
                    if (str == rev)
                    {
                        palindromes.Add(Convert.ToUInt64(str));
                    }
                }
            }
            
            return palindromes;
        }

        static ulong CalculateLargestPalindromeProduct(ulong n,List<ulong> palindromes)
        {
           return palindromes.Where(x => x < n).Max();
        }

        public void Main()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            var palindromes = CalculatePalindromes();
            for (int i = 0; i < T; i++)
            {
                ulong N = Convert.ToUInt64(Console.ReadLine());
                var res = CalculateLargestPalindromeProduct(N,palindromes);
                Console.WriteLine(res.ToString());
            }
        }


        public List<string> Main(List<string> args)
        {
            var result = new List<string>();
            int T = Convert.ToInt32(args[0]);
            var palindromes = CalculatePalindromes();
            for (int i = 0; i < T; i++)
            {
                ulong N = Convert.ToUInt64(args[i + 1]);
                var res = CalculateLargestPalindromeProduct(N, palindromes);
                result.Add((res).ToString());
            }
            return result;
        }


    }
}
