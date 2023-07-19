using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBox.MathAlgorithms
{
    public static class FindSpecialMultiples
    {
        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}