using System;

namespace Baekjoon.src
{
    class n10250 : ISolutionBase
    {
        public void Execute(string read)
        {
            string[] bl = read.Split(' ');

            int h = int.Parse(bl[0]);
            int w = int.Parse(bl[1]);
            int n = int.Parse(bl[2]);

            int height = n % h;
            int width = n / h + 1;

            Console.WriteLine($"{height}{width:00.##}");
        }

        public string[] TestCase => new string[]
        {
            "6 12 10",
            "30 50 72",
        };
    }
}
