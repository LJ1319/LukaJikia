using System;

namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an input string: ");
            string input = Console.ReadLine();

            PrintCount(WordCount(input));
        }

        static int WordCount(string input)
        {
            int length = input.Length;

            bool inWord = true;

            int wordCount;

            if (input == null || length == 0)
            {
                wordCount = 0;
                return wordCount;
            }

            wordCount = 1;

            for (int i = 0; i < length; i++)
            {
                if (input[i] == ' ' || input[i] == '\n' || input[i] == '\t' || 
                    input[i] == '.' || input[i] == ',' || input[i] == ';' ||
                    input[i] == ':' || input[i] == '?' || input[i] == '!' ||
                    input[i] == '\'' || input[i] == '\"' || input[i] == '(' || input[i] == ')')
                {
                    inWord = false;
                }
                else if (inWord == false)
                {
                    inWord = true;
                    wordCount++;
                }
            }

            return wordCount;
        }

        static void PrintCount(int wordCount)
        {
            Console.WriteLine($"Word Count = {wordCount}");
        }
    }
}
