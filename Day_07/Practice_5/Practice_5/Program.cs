using System;

namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an input string: ");
            string input = Console.ReadLine();

            int letterCount = LetterCount(input);
            int digitCount = DigitCount(input);

            PrintResults(input, letterCount, digitCount);
        }

        static int LetterCount(string input)
        {
            int length = input.Length;

            int letterCount = 0;

            for (int i = 0; i < length; i++)
            {
                if (Char.IsLetter(input[i]) == true)
                {
                    letterCount++;
                }
            }

            return letterCount;
        }

        static int DigitCount(string input)
        {
            int length = input.Length;

            int digitCount = 0;

            for (int i = 0; i < length; i++)
            {
                if (Char.IsDigit(input[i]) == true)
                {
                    digitCount++;
                }
            }

            return digitCount;
        }

        static void PrintResults(string input, int letterCount, int digitCount)
        {
            int length = input.Length;

            int otherCharactersCount = length - letterCount - digitCount;

            Console.WriteLine($" \"{input}\" -> Letters: {letterCount}, Numbers: {digitCount}, Others: {otherCharactersCount}");
        }
    }
}
