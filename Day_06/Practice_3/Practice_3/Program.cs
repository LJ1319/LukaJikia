using System;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using out parameters");
            MaxAndMinOuts(PopulateArray(), out _, out _);

            Console.WriteLine("-----------");

            Console.WriteLine("Using helper array");
            MaxAndMinValues(PopulateArray());
        }

        static int[] PopulateArray()
        {
            Console.Write("Enter size of array: ");
            int arrSize = Convert.ToInt32(Console.ReadLine());

            int[] userArr = new int[arrSize];

            for (int i = 0; i < arrSize; i++)
            {
                Console.Write($"Enter iteger for index {i}: ");
                userArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return userArr;
        }

        // Using out parameters
        static void MaxAndMinOuts(int[] userArr, out int min, out int max)
        {
            min = int.MaxValue;
            max = int.MinValue;

            for (int i = 0; i < userArr.Length; i++)
            {
                if (userArr[i] < min)
                {
                    min = userArr[i];
                }

                if (userArr[i] > max)
                {
                    max = userArr[i];
                }
            }

            Console.WriteLine($"The minimum number in the array is {min}");
            Console.WriteLine($"The maximum number in the array is {max}");
        }

        // Using helper array
        static int[] MaxAndMinValues(int[] userArr)
        {
            int min = int.MaxValue;
            int max = int.MinValue;

            for (int i = 0; i < userArr.Length; i++)
            {
                if (userArr[i] < min)
                {
                    min = userArr[i];
                }

                if (userArr[i] > max)
                {
                    max = userArr[i];
                }
            }

            int[] values = new int[2] { min, max };

            Console.WriteLine($"The minimum number in the array is {min}");
            Console.WriteLine($"The maximum number in the array is {max}");

            return values;
        }
    }
}
