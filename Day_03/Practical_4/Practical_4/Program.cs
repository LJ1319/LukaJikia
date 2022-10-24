using System;

namespace Practical_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birth year: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            int signNumber = birthYear % 12;

            string animal = signNumber switch
            {
                0 => "Monkey",
                1 => "Rooster",
                2 => "Dog",
                3 => "Boar / Pig",
                4 => "Rat",
                5 => "Ox",
                6 => "Tiger",
                7 => "Rabbit",
                8 => "Dragon",
                9 => "Snake",
                10 => "Horse",
                11 => "Sheep",
                _ => throw new NotImplementedException(),
            };

            Console.WriteLine($"{birthYear} was {animal} year");
        }
    }
}
