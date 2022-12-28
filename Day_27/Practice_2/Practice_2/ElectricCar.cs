namespace Practice_2
{
    public class ElectricCar
    {
        private int _batteryLevel;
        public int BatteryLevel
        {
            get => _batteryLevel;
            set
            {
                if (value < 0)
                {
                    _batteryLevel = 0;
                }
                else if (value > 100)
                {
                    _batteryLevel = 100;
                }
                else
                {
                    _batteryLevel = value;
                }
            }
        }

        public string Model { get; set; }
        public int Year { get; set; }

        public ElectricCar(int batteryLevel, string model, int year)
        {
            BatteryLevel = batteryLevel;
            Model = model;
            Year = year;
        }

        public async Task Charge()
        {
            Console.WriteLine($"Car Charging Started\nModel: {Model}\tYear: {Year}\tBattery: {BatteryLevel}%\n");
            while (BatteryLevel < 100)
            {
                await Task.Delay(1000);
                BatteryLevel += 5;
                Console.WriteLine($"Car Charged by 5%! \nModel: {Model}\tYear: {Year}\tBattery: {BatteryLevel}%\n");
            }
            Console.WriteLine($"Car Charging Ended\nModel: {Model}\tYear: {Year}\tBattery: {BatteryLevel}%\n");
        }
    }
}