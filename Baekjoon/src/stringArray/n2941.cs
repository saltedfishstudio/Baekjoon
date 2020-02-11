using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.src
{
    class n2941 : ISolutionBase
    {
        public string[] TestCase { get; }
        public void Execute(string read)
        {
            string[] entry = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            foreach(string cr in entry)
            {
                read = read.Replace(cr, ".");
            }

            Console.WriteLine(read.Length);
        }
    }
}
