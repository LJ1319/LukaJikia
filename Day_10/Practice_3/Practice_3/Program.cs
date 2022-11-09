using System;

namespace Practice_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock1 = new Clock();

            Console.Write("Enter hours: ");
            clock1.Hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter minutes: ");
            clock1.Minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter seconds: ");
            clock1.Seconds = Convert.ToInt32(Console.ReadLine());


            clock1.SecondForward();
            clock1.SecondForward();
            clock1.SecondForward();
            clock1.SecondForward();
            clock1.GetCurrentTime();
            clock1.SecondForward();
            clock1.SecondForward();
            clock1.SecondForward();
            clock1.MinuteForward();

            //clock1.SecondBack();
            //clock1.MinuteBack();
            clock1.GetCurrentTime();

        }
    }
}
