using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTests
{
    public static class Utils
    {
        public static List<string> ReadFile(string path)
        {
            string fullPath = Path.Combine(Environment.CurrentDirectory,@"TestFiles\"+ path);
            var result = new List<string>();
            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException(fullPath + " does not exist");
            }

            // Open the file to read from. 
            string[] readText = File.ReadAllLines(fullPath);
            foreach (string s in readText)
            {
                result.Add(s);
            }
            return result;
        }

        public static List<string> ReadInput(string testName)
        {
            return Utils.ReadFile(testName + "Input.txt");
        }

        public static List<string> ReadOutput(string testName)
        {
            return Utils.ReadFile(testName + "Output.txt");
        }

        public static void CompareOutputs(List<string> actual, string path)
        {
            var expected = Utils.ReadOutput(path);
            for (int i = 0; i < expected.Count(); i++)
            {
                Assert.AreEqual(actual[i], expected[i]);
            }
        }
    }
}
