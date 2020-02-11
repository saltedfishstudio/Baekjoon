using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon
{
    interface ISolutionBase
    {
        public void Execute(string read);
        public string[] TestCase { get; }
    }
}
