using System;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            int userInput = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= userInput; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum from 1 to {userInput} is {sum}");
        }
    }
}
