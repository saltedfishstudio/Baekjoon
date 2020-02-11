using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.src
{
    class n5622 : ISolutionBase
    {
        public void Execute(string read)
        {
            Console.WriteLine(read.Sum(e => Call(e)));
        }

        static int Call(char character)
        {
            const int defaultDelay = 2;
            int delay;
            switch(character)
            {
                case 'A':
                case 'B':
                case 'C':
                    delay = 1;
                    break;

                case 'D':
                case 'E':
                case 'F':
                    delay = 2;
                    break;

                case 'G':
                case 'H':
                case 'I':
                    delay = 3;
                    break;

                case 'J':
                case 'K':
                case 'L':
                    delay = 4;
                    break;

                case 'M':
                case 'N':
                case 'O':
                    delay = 5;
                    break;

                case 'P':
                case 'Q':
                case 'R':
                case 'S':
                    delay = 6;
                    break;

                case 'T':
                case 'U':
                case 'V':
                    delay = 7;
                    break;

                case 'W':
                case 'X':
                case 'Y':
                case 'Z':
                    delay = 8;
                    break;

                default:
                    delay = 1;
                    break;
            }

            return defaultDelay + delay;
        }
    }
}
