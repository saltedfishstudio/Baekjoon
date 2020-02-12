namespace Baekjoon
{
    using src;

    class Program
    {
        static ISolutionBase solution;

        static int Main(string[] args)
        {
            solution = new n10250();

            foreach (string test in solution.TestCase)
            {
                solution.Execute(test);
            }

            return 0;
        }
    }
}
