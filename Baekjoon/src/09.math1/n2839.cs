using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.src
{
    class n2839 : ISolutionBase
    {
        public string[] TestCase
        {
            get
            {
                return new string[] {
                    "18",
                "4",
                "6",
                "9",
                "11",
            };
            }
        }

        public void Execute(string read)
        {
            int goal = int.Parse(read);
            int start = goal / 5;

            for(int i = start; i >= 0; i--)
            {
                int rest = goal - (i * 5);
                if(rest % 3 == 0)
                {
                    Console.WriteLine(i + rest / 3);
                    return;
                }
            }

            Console.WriteLine(-1);
        }
    }
}
