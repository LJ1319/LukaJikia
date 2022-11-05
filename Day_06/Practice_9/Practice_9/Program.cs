using System;

namespace Practice_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product(1, 3, 4, 15, 13, 23, 98);

            int[] myIntArray = { 1, 3, 4, 15, 13, 23, 98 };
            Product(myIntArray);
        }

        static int Product(params int[] userArr)
        {
            int product = 1;

            for (int i = 0; i < userArr.Length; i++)
            {
                product *= userArr[i];
            }

            Console.WriteLine($"The product of array elements is: {product}");

            return product;
        }
    }
}
