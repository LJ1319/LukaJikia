using System;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an input string: ");
            string input = Console.ReadLine();

            SeperateWithSpaces(input);
        }

        static void SeperateWithSpaces(string input)
        {
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}
