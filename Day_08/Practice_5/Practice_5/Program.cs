using System;

namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text: ");
            string text = Console.ReadLine();

            Console.WriteLine($"Is palindrome? {IsPalindrome(text)}");
        }

        static bool IsPalindrome(string text)
        {
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                    return IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
    }
}
