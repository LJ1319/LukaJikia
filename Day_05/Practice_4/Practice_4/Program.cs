using System;

namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int[] userArray = new int[userInput];

            long product = 1;
            for (int i = 0; i < userInput; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                userArray[i] = Convert.ToInt32(Console.ReadLine());

                product *= userArray[i];
            }

            Console.WriteLine($"Product of array elements is {product}");
        }
    }
}
