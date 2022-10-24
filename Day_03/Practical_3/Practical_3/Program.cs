using System;

namespace Practical_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double powValue = 2;

            Console.WriteLine("Enter number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            double result = Math.Pow(userInput, powValue);
            Console.WriteLine($"The pow of the entered number is {result}");
        }
    }
}
