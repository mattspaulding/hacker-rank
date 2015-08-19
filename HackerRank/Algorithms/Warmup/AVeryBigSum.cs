using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
   public class AVeryBigSum
    {
        
        public void Main()
        {
               
        ulong sum = 0;
        int T = Convert.ToInt32(Console.ReadLine());
        var vals = Console.ReadLine().Split(' ').ToList();
        for (int i = 0; i < T; i++)
        {
            ulong val = Convert.ToUInt64(vals[i]);
            sum += val;
        }
       
        Console.WriteLine(sum);
        
    }
        

        public List<string> Main(List<string> args)
        {
            var result = new List<string>();
            ulong sum = 0 ;
            int T = Convert.ToInt32(args[0]);
            var vals = args[1].Split(' ').ToList();
            for (int i = 0; i < T; i++)
            {
                ulong val = Convert.ToUInt64(vals[i]);
                sum += val;
            }
            result.Add(sum.ToString());
            return result;
          
        }


    }
}
