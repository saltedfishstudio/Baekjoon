using System;

namespace Baekjoon
{
    using src;

    class Program
    {
        static ISolutionBase solution;

        static int Main(string[] args)
        {
            solution = new n10809();
            solution.Execute();

            return 0;
        }
    }
}
