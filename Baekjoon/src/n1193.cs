using System;

namespace Baekjoon.src
{
    class n1193 : ISolutionBase
    {
        public string[] TestCase => new string[]
        {
            "14",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
        };

        public void Execute(string read)
        {
            int x = int.Parse(read);
            Console.WriteLine($"{GetUpper(x)}/{GetUnder(x)}");
        }

        static int GetUpper(int x)
        {
            int current = 1;
            while (x > 0)
            {

                x--;
            }

            return current;
        }

        static int GetUnder(int x)
        {
            int peek = 2;
            int current = 1;
            bool isGrowing = false;

            while (x > 0)
            {
                if (peek == current)
                {
                    if (isGrowing)
                    {
                        isGrowing = false;
                    }
                    else
                    {
                        isGrowing = true;
                    }

                    peek += 2;
                }

                else if (peek > current)
                {
                    if (isGrowing)
                    {
                        current++;
                    }
                    else
                    {
                        current--;
                    }
                }

                x--;
            }

            return current;
        }
    }
}
