using System;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powValue = 3;

            Console.WriteLine("Enter a number: ");
            long userInput = Convert.ToInt64(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                long cubed = (long)Math.Pow(i, powValue);
                Console.WriteLine($"{i} cubed is {cubed}");
            }
        }
    }
}
