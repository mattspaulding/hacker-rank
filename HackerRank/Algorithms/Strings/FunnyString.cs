using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Strings
{
    public class FunnyString
    {
        static string CalculateFunnyString(string str)
        {
            var s = str.ToCharArray();
            var r = s.Reverse().ToArray();

            for (int i = 0; i < str.Length-1; i++)
            {
                if (Math.Abs(s[i + 1] - s[i]) != Math.Abs(r[i + 1] - r[i]))
                    return "Not Funny";
            }
            return "Funny";
        }


        public void Main()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var str = Console.ReadLine();
                var res = CalculateFunnyString(str);
                Console.WriteLine(res);
            }
        }


        public List<string> Main(List<string> args)
        {
            var result = new List<string>();
            int T = Convert.ToInt32(args[0]);
            for (int i = 0; i < T; i++)
            {
                var str = args[i + 1];
                var res = CalculateFunnyString(str);
                result.Add(res);
            }
            return result;
        }


    }
}
