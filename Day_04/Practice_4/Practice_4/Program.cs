using System;

namespace Practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= userInput; i++)
            {
                if (i % 2 != 0)
                {
                    //Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine($"sum of odd numbers from 1 to {userInput} is {sum}");
        }
    }
}
