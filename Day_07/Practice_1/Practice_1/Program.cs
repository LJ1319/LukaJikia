using System;
using System.Linq;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an input string: ");
            string input = Console.ReadLine();

            NumberOfLetters(input);
            PrintLetters(input);

            NumberOfLetters(input, 'c');
            PrintLetters(input, 'C');
        }

        static int NumberOfLetters(string input, char letter = 'V')
        {
            var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            var consonants = new char[] { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };

            int length = input.Length;

            int vowelCount = 0;
            int consonantsCount = 0;

            if (Char.ToUpper(letter) == 'V')
            {
                for (int i = 0; i < length; i++)
                {
                    if (vowels.Contains(Char.ToUpper(input[i])))
                    {
                        vowelCount++;
                    }
                }

                Console.WriteLine($"Vowel count: {vowelCount}");

                return vowelCount;
            }

            if (Char.ToUpper(letter) == 'C')
            {
                for (int i = 0; i < length; i++)
                {
                    if (consonants.Contains(Char.ToUpper(input[i])))
                    {
                        consonantsCount++;
                    }
                }

                Console.WriteLine($"Consonant count: {consonantsCount}");

                return consonantsCount;
            }

            return 0;
        }

        static void PrintLetters(string input, char letter = 'V')
        {
            var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            var consonants = new char[] { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };

            int length = input.Length;

            
            if (Char.ToUpper(letter) == 'V')
            {
                Console.Write("Vowels: ");
                for (int i = 0; i < length; i++)
                {
                    char vowel = input[i];
                    if (vowels.Contains(Char.ToUpper(vowel)))
                    {
                        Console.Write($"{vowel} ");
                    }
                }

                Console.WriteLine();

                return;
            }

            
            if (Char.ToUpper(letter) == 'C')
            {
                Console.Write("Consonants: ");
                for (int i = 0; i < length; i++)
                {
                    char consonant = input[i];
                    if (consonants.Contains(Char.ToUpper(consonant)))
                    {
                        Console.Write($"{consonant} ");
                    }
                }

                Console.WriteLine();

                return;
            }
        }
    }
}
