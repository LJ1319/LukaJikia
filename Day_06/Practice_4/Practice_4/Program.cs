using System;

namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AverageOfArray(PopulateArray());
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

        static double AverageOfArray(int[] userArr)
        {
            double avg = 0;
            int sum = 0;
            int arrSize = userArr.Length;

            for (int i = 0; i < arrSize; i++)
            {
                sum += userArr[i];
                avg = (double)sum / arrSize;
            }

            Console.WriteLine(String.Format("Arithmetic average of array is {0:0.00}", avg));

            return avg;
        }
    }
}
