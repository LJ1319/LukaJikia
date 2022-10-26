using System;

namespace Practice_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userInput = int.Parse(Console.ReadLine());

            Console.Write($"divisors of {userInput} are: ");
            for (int i = 1; i <= userInput; i++)
            {
                if (userInput % i == 0)
                {
                    if (i == userInput)
                    {
                        Console.Write($"{i}");
                    }
                    else
                    {
                        Console.Write($"{i}, ");
                    }
                }
            }
        }
    }
}
