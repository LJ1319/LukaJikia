namespace GeographyNow
{
    public class City : GeographicEntity
    {
        public string Name { get; set; }
        public decimal Area { get; set; }
        public int Population { get; set; }
        public bool IsCapital { get; set; }

        public Country Country { get; set; }

        public City(string name, decimal area, int population, bool isCapital, Country country)
        {
            Name = name;
            Area = area;
            Population = population;
            IsCapital = isCapital;
            Country = country;
        }

        public override void DisplayData()
        {
            Console.WriteLine($"City Name: {Name}\nPopulation: {Population}\nCapital: {IsCapital}\nCountry: {Country.Name}");
        }
    }
}