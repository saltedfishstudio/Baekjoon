﻿using System;
using System.Text;

namespace Baekjoon.src
{
    class n10809 : ISolutionBase
    {
        public string[] TestCase { get; }

        public void Execute(string s)
        {
            const int a = 97;
            const int z = 122;

            var sb = new StringBuilder(100);

            for (int i = a; i <= z; i++)
            {
                int index = s.IndexOf(Convert.ToChar(i));
                sb.Append(index);

                if (i != z)
                {
                    sb.Append(" ");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
