using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges._101HackApril15
{
    public class RatRace
    {
       static List<string> CalculateWinners(List<int> speeds, List<int> distances)
        {
            var winners = new List<int>();
            double bestTime = 0.0;

            for (int i = 0; i < speeds.Count; i++)
            {
                var time = (double)distances[i] / (double)speeds[i];

                if (winners.Count == 0)
                {
                    winners.Add(i + 1);
                    bestTime = time;
                }
                else if (time < bestTime)
                {
                    winners = new List<int>();
                    winners.Add(i + 1);
                    bestTime = time;
                }
                else if (time == bestTime)
                {
                    winners.Add(i + 1);
                }
            }
            var result = new List<string>();
            foreach (var winner in winners)
                result.Add((winner).ToString());
            return result;

        }
        public void Main()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            var line1 = Console.ReadLine();
            var line2 = Console.ReadLine();

            var speeds = new List<int>();
            var distances = new List<int>();


            for (int i = 0; i < N; i++)
            {
                speeds.Add(Convert.ToInt32(line1.Split(' ')[i]));
                distances.Add(Convert.ToInt32(line2.Split(' ')[i]));
            }
            var result = CalculateWinners(speeds, distances);

            foreach (var r in result)
                Console.WriteLine(r);

        }



        public List<string> Main(List<string> args)
        {
            int N = Convert.ToInt32(args[0]);

            var speeds = new List<int>();
            var distances = new List<int>();

            for (int i = 0; i < N; i++)
            {
                speeds.Add(Convert.ToInt32(args[1].Split(' ')[i]));
                distances.Add(Convert.ToInt32(args[2].Split(' ')[i]));
            }

            var result = CalculateWinners(speeds, distances);

            return result;
        }

    }
}
