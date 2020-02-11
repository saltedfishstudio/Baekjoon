using System;
using System.Text;

namespace Baekjoon
{
    using src;

    class Program
    {
        static ISolutionBase solution;

        static int Main(string[] args)
        {
            solution = new n2675();
            solution.Execute(Console.ReadLine());

            return 0;
        }
    }
}
