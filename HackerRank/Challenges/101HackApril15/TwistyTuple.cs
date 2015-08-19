using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges._101HackApril15
{
    public class TwistyTuple
    {
        static List<string> CalculateTwistyTuples(int N,List<int> numbers)
        {

            ulong howMany = 0;

            for (int i = 0; i < N; i++)
            {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (j < N)
                        {
                            if (numbers[i] < numbers[j])
                            {
                                for (int k = j + 1; k < N; k++)
                            {
                                if (k < N)
                                {
                                    if (numbers[k] < numbers[i])
                                        howMany++;
                                }
                            }
                        }
                    }
                }
            }

            var result = new List<string>();
            result.Add(howMany.ToString());
            return result;

        }
        public void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            var line1 = Console.ReadLine();
            var numbers = new List<int>();

            for (int i = 0; i < N; i++)
            {
                numbers.Add(Convert.ToInt32(line1.Split(' ')[i]));
            }

            var result = CalculateTwistyTuples(N,numbers);

            foreach (var r in result)
                Console.WriteLine(r);

        }



        public List<string> Main(List<string> args)
        {
            int N = Convert.ToInt32(args[0]);

            var numbers = new List<int>();

            for (int i = 0; i < N; i++)
            {
                numbers.Add(Convert.ToInt32(args[1].Split(' ')[i]));
            }

            var result = CalculateTwistyTuples(N,numbers);

            return result;
        }

    }
}
