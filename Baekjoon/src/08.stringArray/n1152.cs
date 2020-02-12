using System;
using System.Linq;

namespace Baekjoon.src
{
    class n1152 : ISolutionBase
    {
        public string[] TestCase { get; }

        public void Execute(string read)
        {
            string[] block = read.Split(' ');

            int blockCount = block.Length;
            int blankCount = block.Count(e => string.IsNullOrEmpty(e));

            Console.WriteLine(blockCount - blankCount);
        }
    }
}
