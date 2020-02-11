using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.src
{
    class n1316 : ISolutionBase
    {
        public void Execute(string read)
        {
            int testCase = int.Parse(read);
            var list = new List<char>();

            int groupWordCount = 0;

            for(int i=0; i < testCase; i++)
            {
                list.Clear();

                string str = Console.ReadLine();
                char last = ' ';

                bool isGroupWord = true;

                foreach(char c in str)
                {
                    if(c == last)
                    {
                        continue;
                    }
                    else if (list.Contains(c))
                    {
                        isGroupWord = false;
                        break;
                    }

                    list.Add(c);
                    last = c;
                }

                if (isGroupWord)
                {
                    groupWordCount++;
                }
            }

            Console.WriteLine(groupWordCount);
        }
    }
}
