using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    /// <summary>
    /// Algorithms -> Strings -> Pangrams
    /// </summary>
    /// <see href="https://www.hackerrank.com/challenges/pangrams"/>
    public class Pangrams
    {
        static string IsThisAPangram(string str)
        {
            var sList = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            str = str.ToLower();
            foreach (var s in sList)
            {
                if (!str.Contains(s))
                    return "not pangram";
            }

            return "pangram";
        }


        public void Main()
        {
            var str = Console.ReadLine();
            var res = IsThisAPangram(str);
            Console.WriteLine(res);
        }


        public List<string> Main(List<string> args)
        {
            var result = new List<string>();
            var str = args[0];

            var res = IsThisAPangram(str);
            result.Add(res);

            return result;
        }


    }
}
