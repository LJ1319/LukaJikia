using System;

namespace Practical_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput % 2  == 0)
            {
                Console.WriteLine($"Entered number {userInput} is even");
            } else
            {
                Console.WriteLine($"Entered number {userInput} is odd");
            }
        }
    }
}
