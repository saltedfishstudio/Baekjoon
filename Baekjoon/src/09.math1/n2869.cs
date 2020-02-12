using System;

namespace Baekjoon.src
{
    class n2869 : ISolutionBase
    {
        public string[] TestCase => new string[]
        {
            "2 1 5",
        };

        public void Execute(string read)
        {
            string[] bl = read.Split(' ');

            int a = int.Parse(bl[0]);
            int b = int.Parse(bl[1]);
            int v = int.Parse(bl[2]);

            int result = (v - a) / (a - b);
            if ((v - a) % (a - b) != 0)
            {
                result++;
            }

            Console.WriteLine(result + 1);
        }
    }
}
