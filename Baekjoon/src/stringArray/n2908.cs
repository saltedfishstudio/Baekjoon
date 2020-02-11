using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.src
{
    class n2908 : ISolutionBase
    {
        public void Execute(string read)
        {
            string[] block = read.Split(' ');

            string n1 = $"{block[0][2].ToString()}{block[0][1].ToString()}{block[0][0].ToString()}";
            string n2 = $"{block[1][2].ToString()}{block[1][1].ToString()}{block[1][0].ToString()}";

            int first = int.Parse(n1);
            int second = int.Parse(n2);

            Console.WriteLine(first > second ? first : second);
        }
    }
}
