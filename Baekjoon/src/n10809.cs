using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.src
{
    class n10809 : ISolutionBase
    {
        public void Execute()
        {
            string s = Console.ReadLine();
            const int a = 97;
            const int z = 122;

            var sb = new StringBuilder(100);

            for (int i = a; i <= z; i++)
            {
                int index = s.IndexOf(Convert.ToChar(i));
                sb.Append(index);
                
                if(i != z)
                {
                    sb.Append(" ");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
