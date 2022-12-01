using static GeographyNow.Program;

namespace GeographyNow
{
    internal class Program
    {
        public static void Main()
        {
            string filePath = @"C:\Users\LJ\source\repos\LukaJikia\Day_19\Practice\GeographyNow\Data\Cities.txt";
            string logPath = @"C:\Users\LJ\source\repos\LukaJikia\Day_19\Practice\GeographyNow\Data\Logs.txt";

            List<City> cities = new List<City>();
            List<Country> countries = new List<Country>();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                string[] entries = line.Replace(',', '.').Split('|');

                string cityName = entries[0].ToUpper();
                decimal cityArea = Convert.ToDecimal(entries[1]);
                int cityPopulation = Convert.ToInt32(entries[2]);
                bool isCapital = Convert.ToBoolean(entries[3]);
                string country = entries[4].ToUpper();
                Country newCountry = new Country(country);

                City newCity = new City(cityName, cityArea, cityPopulation, isCapital, newCountry);

                cities.Add(newCity);
                countries.Add(newCountry);
            }

            /*foreach (var city in cities)
            {
                Console.WriteLine($"{city.Name} {city.Area} {city.Population} {city.IsCapital} {city.Country.Name}");
            }

            foreach (var country in countries)
            {
                Console.WriteLine(country.Name);
            }*/

            Console.WriteLine("1. Search Country\n2. Search City");
            Console.Write("Your choice: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            string chosenCountry = "";
            string chosenCity = "";

            string exceptionMessage = "";

            if (userChoice == 1)
            {
                Console.Write("Enter a country name: ");
                chosenCountry = Console.ReadLine().ToUpper();


                List<City> chosenCountryCities = new List<City>();
                Country myCountry = new Country(chosenCountry);
                foreach (var city in cities)
                {
                    if (city.Country.Name == chosenCountry)
                    {
                        chosenCountryCities.Add(city);
                        myCountry = new Country(chosenCountry, chosenCountryCities);
                    }
                }

                exceptionMessage = myCountry.CheckForSingleCapital();
                myCountry.DisplayData();

            }

            if (userChoice == 2)
            {
                Console.Write("Enter a city name: ");
                chosenCity = Console.ReadLine().ToUpper();

                foreach (var city in cities)
                {
                    if (city.Name == chosenCity)
                    {
                        city.DisplayData();
                    }
                }
            }

            using (StreamWriter sw = File.AppendText(logPath))
            {
                Log(exceptionMessage, sw);
            }

            using (StreamReader sr = File.OpenText(logPath))
            {
                DumpLog(sr);
            }
        }
        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine($"{DateTime.Now.ToLongTimeString()} {DateTime.Now.ToLongDateString()}");
            w.WriteLine("  :");
            w.WriteLine($"  :{logMessage}");
            w.WriteLine("-------------------------------");
        }

        public static void DumpLog(StreamReader sr)
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}