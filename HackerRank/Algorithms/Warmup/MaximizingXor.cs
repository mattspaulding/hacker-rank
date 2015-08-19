using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmup
{
   public class MaximizingXor
    {
          static int maxXor(int l, int r) {
        int val=0;
        for(int i=l;i<=r;i++)
            {
            for(int j=l;j<=r;j++)
                {
                int temp=i^j;
                if(temp>val)
                    val=temp;
            }
        }
        return val;
    }
        public void Main()
        {
                int res;
        int _l;
        _l = Convert.ToInt32(Console.ReadLine());
        
        int _r;
        _r = Convert.ToInt32(Console.ReadLine());
        
        res = maxXor(_l, _r);
        Console.WriteLine(res);
        
    }
        

        public List<string> Main(List<string> args)
        {
            int _l = Convert.ToInt32(args[0]);
            int _r = Convert.ToInt32(args[1]);
            var result = new List<string>();

            var res = maxXor(_l, _r);
            result.Add(res.ToString());
            return result;
        }


    }
}
