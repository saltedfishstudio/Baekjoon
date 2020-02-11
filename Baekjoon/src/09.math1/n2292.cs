using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.src
{
    class n2292 : ISolutionBase
    {
        public string[] TestCase => new string[] { 
            "1", 
            "6", 
            "7", 
            "8", 
            "10", 
            "11", 
            "19", 
            "20", 
            "58" ,
            "1203",
        };

        public void Execute(string read)
        {
            int number = int.Parse(read);

            if(number == 1)
            {
                Console.WriteLine("1");
                return;
            }

            int length = 1;
            number--;
            while(number > 0)
            {
                length++;
                number -= (6 * (length - 1));
            }

            Console.WriteLine(length);
        }
    }
}
