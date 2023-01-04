using System.Diagnostics;

namespace Practice_2
{
    internal class Program
    {
        static async Task Main()
        {
            List<ElectricCar> electricCars = new List<ElectricCar>();
            ElectricCar teslaModelS = new ElectricCar(2, "Tesla Model S", 2015);
            ElectricCar teslaModelX = new ElectricCar(53, "Tesla Model S", 2016);
            ElectricCar teslaRoadster = new ElectricCar(10, "Tesla Roadset", 2017);

            electricCars.Add(teslaModelS);
            electricCars.Add(teslaModelX);
            electricCars.Add(teslaRoadster);

            await ChargeCars(electricCars);

            //foreach (var electricCar in electricCars)
            //{
            //    Console.WriteLine(electricCar.BatteryLevel);
            //}
        }

        static async Task ChargeCars(IEnumerable<ElectricCar> cars)
        {
            List<Task> tasks = new List<Task>();
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("Stopwatch started");
            sw.Start();

            foreach (ElectricCar car in cars)
            {
                tasks.Add(car.Charge());
            }

            await Task.WhenAll(tasks);
            sw.Stop();
            Console.WriteLine("Time elapsed to charge all cars: " + sw.Elapsed);
        }
    }
}