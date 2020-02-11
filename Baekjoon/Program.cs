using System;
using System.Linq;
using System.Text;

namespace Baekjoon
{
    using src;

    class Program
    {
        static ISolutionBase solution;

        static int Main(string[] args)
        {
            solution = new n2839();
        
            foreach(string test in solution.TestCase)
            {
                solution.Execute(test);
            }

            return 0;
        }
    }
}
