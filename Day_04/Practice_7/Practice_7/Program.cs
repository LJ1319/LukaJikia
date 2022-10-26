using System;

namespace Practice_7
{
    internal class Program
    {
        //https://www.mathsisfun.com/numbers/fibonacci-sequence.html
        //The Fibonacci sequence is a sequence where the next term is the sum of the previous two terms.
        //The first two terms of the Fibonacci sequence are 0 and 1.

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput < 2)
            {
                Console.Write("Number must be equal or greater than two!");
            }
            else
            {

                int t1 = 0, t2 = 1;
                int nextTerm = t1 + t2;

                Console.Write($"{t1}, {t2}, ");
                for (int i = 2; i <= userInput; ++i)
                {
                    if (i != userInput)
                    {
                        Console.Write($"{nextTerm}, ");
                    }
                    else
                    {
                        Console.Write($"{nextTerm}");
                    }

                    t1 = t2;
                    t2 = nextTerm;
                    nextTerm = t1 + t2;
                }
            }
        }
    }
}
