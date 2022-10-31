using System;

namespace Practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userArr = { 1, 3, 123, 15, 13, 23, 98 };
            int index = 6;
            SumOfDigits(userArr, index);
        }

        static int SumOfDigits(int[] userArr, int index)
        {
            int numAtIndx = userArr[index];

            int sum = 0, rem;

            while(numAtIndx > 0)
            {
                rem = numAtIndx % 10;
                sum += rem;
                numAtIndx /= 10;
            }

            Console.WriteLine($"The sum of the digits of a number at index {index} is {sum}");

            return sum;
        }
    }
}
