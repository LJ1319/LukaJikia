using System;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            int[] userArray = new int[userInput];

            for (int i = 0; i < userInput; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                userArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("Here is your array!");
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(userArray[i]);
            }
        }
    }
}
