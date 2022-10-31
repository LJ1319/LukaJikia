using System;

namespace Practice_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateFactorial(PopulateArray(), 6);
        }

        static int[] PopulateArray()
        {
            Console.Write("Enter size of array: ");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            int[] userArr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"Enter integer for index {i}: ");
                userArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return userArr;
        }

        static int CalculateFactorial(int[] userArr, int number)
        {
            if (number < 0)
            {
                Console.WriteLine("Number can not be a negative number");
                return 1;
            }

            int factorial = 1;
            int arrSize = userArr.Length;

            bool inArray = false;

            for (int i = 0; i < arrSize; i++)
            {
                if (userArr[i] == number)
                {
                    inArray = true;
                    break;
                }
            }

            if (!inArray)
            {
                Console.WriteLine($"Number {number} was not found in the given array");
                return 1;
            }

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Factorial of {number} is {factorial}");

            return factorial;
        }
    }
}
