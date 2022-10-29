using System;

namespace Practice_5
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

            Console.WriteLine("Unique elements of array are: ");
            for (int i = 0; i < userInput; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < userInput; j++)
                {
                    //Console.WriteLine($"{i} --- {j}");
                    //Console.WriteLine($"{userArray[i]} {userArray[j]}");
                    if (userArray[i] == userArray[j] && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    Console.WriteLine($"{userArray[i]}");
                }
            }
        }
    }
}
