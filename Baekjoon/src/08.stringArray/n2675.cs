using System;
using System.Text;

namespace Baekjoon.src
{
    class n2675 : ISolutionBase
    {
        public string[] TestCase { get; }

        public void Execute(string s)
        {
            int testCase = int.Parse(s);
            for (int i = 0; i < testCase; i++)
            {
                string c = Console.ReadLine();
                string[] block = c.Split(' ');

                int times = int.Parse(block[0]);
                string msg = block[1];

                StringBuilder sb = new StringBuilder();
                foreach (char ch in msg)
                {
                    for (int j = 0; j < times; j++)
                    {
                        sb.Append(ch);
                    }
                }

                Console.WriteLine(sb.ToString());
            }
        }
    }
}
