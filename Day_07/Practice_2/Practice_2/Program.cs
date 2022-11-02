using System;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an input string: ");
            string input = Console.ReadLine();
            Console.Write("Input string in reverse order: ");
            PrintReverseString(input);
        }

        static void PrintReverseString(string input)
        {
            int length = input.Length;
            // v1
            //for (int i = 0; i < length; i++)
            //{
            //    Console.Write(input[length - i - 1]);
            //}

            // v2
            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
        }
    }
}
