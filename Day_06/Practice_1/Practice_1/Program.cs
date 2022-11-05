using System;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userArr = { 1, 3, 4, 15, 13, 23, 98 };
            int index = 4;
            NumberAtIndex(userArr, index);
        }

        static int NumberAtIndex(int[] userArr, int index)
        {
            int numAtIndx = userArr[index];

            Console.WriteLine($"Number at index {index} in the array is {numAtIndx}");

            return numAtIndx;
        }
    }
}
