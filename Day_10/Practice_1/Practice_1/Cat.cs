using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Practice_1
{
    internal class Cat
    {
        string _name;
        string _breed;
        int _age;

        readonly int _oneBiteInGrams = 10;

        public string Name
        {
            get => _name;
            set => _name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }

        public string Breed
        {
            get => _breed;
            set => _breed = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
        }

        public int Age
        {
            get { return _age; }

            set
            {
                if (value > 0)
                    _age = value;
            }
        }

        public string Gender
        { get; set; }

        public void Meow(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Meowing...");
            }
        }

        public void Eat(int foodWeightInGrams)
        {
            Console.WriteLine($"{_name} start eating.");
            //int bites = 0;

            while (foodWeightInGrams > 0)
            {
                foodWeightInGrams -= _oneBiteInGrams;
                //bites++;
                Console.WriteLine("Eating...");
            }

            Console.WriteLine($"{_name} finished eating.");
        }
    }
}
