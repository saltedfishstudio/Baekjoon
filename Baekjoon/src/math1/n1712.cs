using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.src
{
    class n1712 : ISolutionBase
    {
        public string[] TestCase { get; }

        public void Execute(string read)
        {
            string[] block = read.Split(' ');

            int a = int.Parse(block[0]);
            int b = int.Parse(block[1]);
            int c = int.Parse(block[2]);

            int margin = c - b;
            if(margin <= 0)
            {
                Console.WriteLine("-1");
                return;
            }

            Console.WriteLine(a / margin + 1);
        }
    }
}
