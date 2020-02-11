using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.src
{
    class n1157 : ISolutionBase
    {
        public string[] TestCase { get; }

        public void Execute(string read)
        {
            int highest = 0;
            var collection = new List<char>();

            var dict = new Dictionary<char, int>();

            foreach(char c in read.ToLower())
            {
                if (!dict.ContainsKey(c))
                {
                    dict[c] = 0;
                }
                
                dict[c] += 1;
                
                // validate highest
                if(dict[c] > highest)
                {
                    highest = dict[c];
                    collection.Clear();
                    collection.Add(c);
                } 
                else if(dict[c] == highest)
                {
                    collection.Add(c);
                }
            }

            if(collection.Count > 1)
            {
                Console.WriteLine("?");
            } else
            {
                Console.WriteLine(collection[0].ToString().ToUpper());
            }
        }
    }
}
