using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HackerRank.Algorithms.Strings
{
    public class HammingDistance
    {
        static string R(string str, int l, int r)
        {
            var subStr = str.Substring(l, r - l + 1);
            var revSubStr = new string(subStr.Reverse().ToArray());
            str = str.Remove(l, r - l + 1);
            str = str.Insert(l, revSubStr);

            return str;
        }

        static string W(string str, int l, int r)
        {
            return str.Substring(l, r - l + 1);
        }

        static string C(string str, int l, int r, string ch)
        {
            char[] array = new char[r - l + 1];
            char c = ch.ToCharArray()[0];
            for (int i = 0; i < r - l + 1;i++ )
            {
                array[i] = c;
            }
            var sub = new string(array);
            str = str.Insert(l, sub);
            str = str.Remove(r+1, r-l+1);
                  
            return str;
        }

        static string H(string str, int l, int r, int len)
        {
             var subStr1 = str.Substring(l, len);
            var subStr2 = str.Substring(r, len);
              var count = subStr1.Zip(subStr2, (c1, c2) => c1 == c2 ? 0 : 1).Sum();

        
            return count.ToString();
        }

        static string Swap(string str, int l1, int r1, int l2, int r2)
        {
            var newStr = str.Substring(0, l1)+str.Substring(l2, r2 - l2 + 1)+str.Substring(r1+1, l2 - r1-1)+str.Substring(l1, r1 - l1 + 1)+str.Substring(r2+1);

           //var first = str.Substring(0, l1);
           //var subStr1 = str.Substring(l1, r1 - l1 + 1);
           //var middle = str.Substring(r1+1, l2 - r1 - 1);
           //var subStr2 = str.Substring(l2, r2 - l2 + 1);
           //var end = str.Substring(r2+1 );
          
            return newStr;
        }


        public void Main()
        {
            int T = Convert.ToInt32(Console.ReadLine());
            var S = Console.ReadLine();
            var M = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                var line = Console.ReadLine();
                var function = line.Split(' ')[0];
                switch (function)
                {
                    case "R":
                        {
                            var l = Convert.ToInt32(line.Split(' ')[1]) - 1;
                            var r = Convert.ToInt32(line.Split(' ')[2]) - 1;
                            S = R(S, l, r);
                            break;
                        }
                    case "W":
                        {
                            var l = Convert.ToInt32(line.Split(' ')[1]) - 1;
                            var r = Convert.ToInt32(line.Split(' ')[2]) - 1;
                            Console.WriteLine(W(S, l, r));
                            break;
                        }
                    case "C":
                        {
                            var l = Convert.ToInt32(line.Split(' ')[1]) - 1;
                            var r = Convert.ToInt32(line.Split(' ')[2]) - 1;
                            var ch = line.Split(' ')[3];
                            S = C(S, l, r, ch);
                            break;
                        }
                    case "H":
                        {
                            var l = Convert.ToInt32(line.Split(' ')[1]) - 1;
                            var r = Convert.ToInt32(line.Split(' ')[2]) - 1;
                            var len = Convert.ToInt32(line.Split(' ')[3]);
                            Console.WriteLine(H(S, l, r, len));
                            break;
                        }
                    case "S":
                        {
                            var l1 = Convert.ToInt32(line.Split(' ')[1]) - 1;
                            var r1 = Convert.ToInt32(line.Split(' ')[2]) - 1;
                            var l2 = Convert.ToInt32(line.Split(' ')[3]) - 1;
                            var r2 = Convert.ToInt32(line.Split(' ')[4]) - 1;
                            S = Swap(S, l1, r1, l2, r2);
                            break;
                        }
                    default:
                        throw new NotSupportedException();
                }
            }
        }


        public List<string> Main(List<string> args)
        {
            var stopWatch = new Stopwatch();
            var result = new List<string>();
            var S = args[1];
            var M = Convert.ToInt32(args[2]);
            for (int i = 0; i < M; i++)
            {
                var function = args[i + 3].Split(' ')[0];
                switch (function)
                {
                    case "R":
                        {
                            var l = Convert.ToInt32(args[i + 3].Split(' ')[1]) - 1;
                            var r = Convert.ToInt32(args[i + 3].Split(' ')[2]) - 1;
                            stopWatch.Restart();
                            S = R(S, l, r);
                            var elapsed=stopWatch.ElapsedTicks;
                            break;
                        }
                    case "W":
                        {
                            var l = Convert.ToInt32(args[i + 3].Split(' ')[1]) - 1;
                            var r = Convert.ToInt32(args[i + 3].Split(' ')[2]) - 1;
                            stopWatch.Restart();
                            result.Add(W(S, l, r));
                            var elapsed = stopWatch.ElapsedTicks;
                            break;
                        }
                    case "C":
                        {
                            var l = Convert.ToInt32(args[i + 3].Split(' ')[1]) - 1;
                            var r = Convert.ToInt32(args[i + 3].Split(' ')[2]) - 1;
                            var ch = args[i + 3].Split(' ')[3];
                            stopWatch.Restart();
                            S = C(S, l, r, ch);
                            var elapsed = stopWatch.ElapsedTicks;
                            var milli = stopWatch.ElapsedMilliseconds;
                            break;
                        }
                    case "H":
                        {
                            var l = Convert.ToInt32(args[i + 3].Split(' ')[1]) - 1;
                            var r = Convert.ToInt32(args[i + 3].Split(' ')[2]) - 1;
                            var len = Convert.ToInt32(args[i + 3].Split(' ')[3]);
                            stopWatch.Restart();
                            result.Add(H(S, l, r, len));
                            var elapsed = stopWatch.ElapsedTicks;
                            var milli = stopWatch.ElapsedMilliseconds;
                            break;
                        }
                    case "S":
                        {
                            stopWatch.Restart();
                            var l1 = Convert.ToInt32(args[i + 3].Split(' ')[1]) - 1;
                            var r1 = Convert.ToInt32(args[i + 3].Split(' ')[2]) - 1;
                            var l2 = Convert.ToInt32(args[i + 3].Split(' ')[3]) - 1;
                            var r2 = Convert.ToInt32(args[i + 3].Split(' ')[4]) - 1;
                           
                           S = Swap(S, l1, r1, l2, r2);
                            var elapsed = stopWatch.ElapsedTicks;
                           var  milli = stopWatch.ElapsedMilliseconds;
                          break;
                        }
                    default:
                        throw new NotSupportedException();
                }
             
            }
            return result;
        }


    }
}
