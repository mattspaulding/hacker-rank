using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
    /// <summary>
    /// Algorithms -> Warmup -> Service Lane
    /// </summary>
    /// <see href="https://www.hackerrank.com/challenges/service-lane"/>
    public class ServiceLane
    {
        public void Main()
        {
            var line1 = Console.ReadLine();
            int N = Convert.ToInt32(line1.Split(' ')[0]);
            int T = Convert.ToInt32(line1.Split(' ')[1]);
            List<int> widths = Console.ReadLine().Split(' ').ToList().Select(int.Parse).ToList();

            for (int index = 0; index < T; index++)
            {
                var linei = Console.ReadLine();
                int i = Convert.ToInt32(linei.Split(' ')[0]);
                int j = Convert.ToInt32(linei.Split(' ')[1]);

                var range = widths.GetRange(i, j - i + 1);

                if (range.Contains(1))
                    Console.WriteLine(1);
                else if (range.Contains(2))
                    Console.WriteLine(2);
                else
                    Console.WriteLine(3);
            }
        }

        public List<string> Main(List<string> args)
        {
            int N = Convert.ToInt32(args[0].Split(' ')[0]);
            int T = Convert.ToInt32(args[0].Split(' ')[1]);
            List<int> widths = args[1].Split(' ').ToList().Select(int.Parse).ToList();

            var result = new List<string>();

            for (int index = 0; index < T; index++)
            {
                int i = Convert.ToInt32(args[index + 2].Split(' ')[0]);
                int j = Convert.ToInt32(args[index + 2].Split(' ')[1]);

                var range = widths.GetRange(i, j - i + 1);

                if (range.Contains(1))
                    result.Add("1");
                else if (range.Contains(2))
                    result.Add("2");
                else
                    result.Add("3");
            }
            return result;
        }


    }
}
