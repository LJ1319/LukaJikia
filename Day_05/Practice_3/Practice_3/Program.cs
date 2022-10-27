using System;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int[] userArray = new int[userInput];

            int sum = 0;
            for (int i = 0; i < userInput; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                userArray[i] = Convert.ToInt32(Console.ReadLine());

                sum += userArray[i];
            }

            Console.WriteLine($"Sum of array elements is {sum}");
        }
    }
}
