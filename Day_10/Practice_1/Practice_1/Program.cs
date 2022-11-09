using System;
using System.Transactions;

namespace Practice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Cat object...");
            Cat cat1 = new Cat();

            Console.Write("Enter name: ");
            cat1.Name = Console.ReadLine();

            Console.Write("Enter breed: ");
            cat1.Breed = Console.ReadLine();

            Console.Write("Enter age: ");
            cat1.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter sex: ");
            cat1.Gender = Console.ReadLine();

            Console.WriteLine("Cat object created.");

            Console.Write("Enter food weight in grams: ");
            int foodWeightInGrams = Convert.ToInt32(Console.ReadLine());
            cat1.Eat(foodWeightInGrams);

            Console.Write("Enter meowing count: ");
            int meowingCount = Convert.ToInt32(Console.ReadLine());
            cat1.Meow(meowingCount);
        }
    }
}
