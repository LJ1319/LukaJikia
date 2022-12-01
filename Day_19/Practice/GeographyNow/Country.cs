namespace GeographyNow
{
    public class Country : GeographicEntity
    {
        private decimal _area;
        private int _population;

        public string Name { get; set; }

        public decimal Area
        {
            get
            {
                foreach (var city in Cities)
                {
                    _area += city.Area;
                }
                return _area;
            }
            //set { _area = value; }
        }

        public int Population
        {
            get
            {
                foreach (var city in Cities)
                {
                    _population += city.Population;
                }
                return _population;
            }
            //set { _population = value; }
        }

        public List<City> Cities { get; set; } = new List<City>();

        public Country(string name)
        {
            Name = name;
        }

        public Country(string name, List<City> cities)
        {
            Name = name;
            Cities = cities;
        }

        public override void DisplayData()
        {
            Console.WriteLine($"Country Name: {Name}\nArea: {Area}\nPopulation: {Population} ");

            Console.Write("Cities: ");
            foreach (var city in Cities)
            {
                if (city.IsCapital)
                {
                    Console.Write($"{city.Name}(Capital) ");
                } else
                {
                    Console.Write($"{city.Name} ");
                }
            }
        }

        public string CheckForSingleCapital()
        {
            int capital = 0;

            string message = "";

            try
            {
                foreach (var city in Cities) 
                { 
                    if (city.IsCapital) 
                    {
                        capital += 1;
                    }

                    if (capital > 1)
                    {
                        throw new CountryMustHaveSingleCapitalException($"More than one capitals: {capital}");
                    }
                }
            }
            catch (CountryMustHaveSingleCapitalException ex)
            {
                Console.WriteLine(ex.ToString());
                message = ex.ToString();
            }

            return message;
        }
    }
}