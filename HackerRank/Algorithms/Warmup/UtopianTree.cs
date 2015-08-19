using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
   public class UtopianTree
    {
        public void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int val = 1;
                for (int j = 0; j < n; j++)
                {
                    if (j % 2 == 0)
                        val = val * 2;
                    else
                        val = val + 1;

                }
                Console.WriteLine(val);

            }
        }

        public List<string> Main(List<string> args)
        {
            int t = Convert.ToInt32(args[0]);
            var result = new List<string>();

            for (int i = 1; i <= t; i++)
            {
                int n = Convert.ToInt32(args[i]);
                 int val = 1;
               for (int j = 0; j < n; j++)
                {
                    if (j % 2 == 0)
                        val = val * 2;
                    else
                        val = val + 1;

                }
               result.Add(val.ToString());
            }  
            return result;
        }


    }
}
