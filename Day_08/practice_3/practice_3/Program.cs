using System;

namespace practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int digits = NumberOfDigits(num);
            Console.WriteLine(digits == 0 ? "1" : digits.ToString());
        }

        static int NumberOfDigits(int num)
        {
            if (num == 0)
                return 0;
            return 1 + NumberOfDigits(num / 10);
        }
    }
}
