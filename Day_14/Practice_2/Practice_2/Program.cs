namespace Practice_2
{
    internal partial class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a land vehicle type: ");
            Console.WriteLine($"1: {Vehicle.Army}\n2: {Vehicle.Consumer}\n3: {Vehicle.Public}\n4: {Vehicle.Sports}");

            Console.Write("Your choice: ");
            int vehicleType = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Creating {GetVehicleType(vehicleType)} Vehicle");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Choose a precise vehicle: ");
            ShowVehicleOptions(vehicleType);

            Console.Write("Your choice: ");
            int vehicle = Convert.ToInt32(Console.ReadLine());

            Console.Write("Creating ");
            CreatePreciseVehicle(vehicleType, vehicle);
            Console.WriteLine("-------------------------");



            Car mercedes = new Car(CreateConsumerVehicle(vehicle), 3, 1.6, 165, false, "Mercedes", "1999");

            Console.WriteLine(mercedes.Style);

            //string[] armyVehicles = new string[3];
            //string[] consumerVehicles = new string[3];
            //string[] publicVehicles = new string[3];
            //string[] sportsVehicles = new string[3];
        }

        public static Vehicle GetVehicleType(int vehicleType)
        {
            switch (vehicleType)
            {
                case (int)Vehicle.Army:
                    return Vehicle.Army;
                case (int)Vehicle.Consumer:
                    return Vehicle.Consumer;
                case (int)Vehicle.Public:
                    return Vehicle.Public;
                case (int)Vehicle.Sports:
                    return Vehicle.Sports;
                default:
                    Console.WriteLine("such type not available");
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static void ShowVehicleOptions(int vehicleType)
        {
            switch (vehicleType)
            {
                case (int)Vehicle.Army:
                    Console.WriteLine($"1: {Army.Tank}\n2: {Army.BTR}\n3: {Army.Hummer}");
                    break;
                case (int)Vehicle.Consumer:
                    Console.WriteLine($"1: {Consumer.Sedan}\n2: {Consumer.Hatchback}\n3: {Consumer.SUV}");
                    break;
                case (int)Vehicle.Public:
                    Console.WriteLine($"1: {Public.Bus}\n2: {Public.Metro}\n3: {Public.Taxi}");
                    break;
                case (int)Vehicle.Sports:
                    Console.WriteLine($"1: {Sports.F1}\n2: {Sports.Rally}\n3: {Sports.OffRoad}");
                    break;
                default:
                    return;
            }
        }

        /*public static string GetPreciseVehicle(int vehicleType, int vehicle)
        {
            switch (vehicleType)
            {
                case (int)Vehicle.Army:
                    if (vehicle == (int)Army.Tank)
                        return "Tank";
                    if (vehicle == (int)Army.BTR)
                        return "BTR";
                    if (vehicle == (int)Army.Hummer)
                        return "Hummer";
                    return "such vehicle not available";
                case (int)Vehicle.Consumer:
                    if (vehicle == (int)Consumer.Sedan)
                        return "Sedan";
                    if (vehicle == (int)Consumer.Hatchback)
                        return "Hatchback";
                    if (vehicle == (int)Consumer.SUV)
                        return "SUV";
                    return "such vehicle not available";
                case (int)Vehicle.Public:
                    if (vehicle == (int)Public.Bus)
                        return "Bus";
                    if (vehicle == (int)Public.Metro)
                        return "Metro";
                    if (vehicle == (int)Public.Taxi)
                        return "Taxi";
                    return "such vehicle not available";
                case (int)Vehicle.Sports:
                    if (vehicle == (int)Sports.F1)
                        return "F1";
                    if (vehicle == (int)Sports.Rally)
                        return "Rally";
                    if (vehicle == (int)Sports.OffRoad)
                        return "OffRoad";
                    return "such vehicle not available";
                default:
                    return "such type not available";
            }
        }*/

        public static void CreatePreciseVehicle(int vehicleType, int vehicle)
        {
            switch (vehicleType)
            {
                case (int)Vehicle.Army:
                    Console.WriteLine($"{CreateArmyVehicle(vehicle)}");
                    break;
                case (int)Vehicle.Consumer:
                    Console.WriteLine($"{CreateConsumerVehicle(vehicle)}");
                    break;
                case (int)Vehicle.Public:
                    Console.WriteLine($"{CreatePublicVehicle(vehicle)}");
                    break;
                case (int)Vehicle.Sports:
                    Console.WriteLine($"{CreateSportsVehicle(vehicle)}");
                    break;
                default:
                    break;
            }
        }

        public static Army CreateArmyVehicle(int vehicle)
        {
            switch (vehicle)
            {
                case (int)Army.Tank:
                    return Army.Tank;
                case (int)Army.BTR:
                    return Army.BTR;
                case (int)Army.Hummer:
                    return Army.Hummer;
                default:
                    Console.WriteLine("such vehicle not available");
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static Consumer CreateConsumerVehicle(int vehicle)
        {
            switch (vehicle)
            {
                case (int)Consumer.Sedan:
                    return Consumer.Sedan;
                case (int)Consumer.Hatchback:
                    return Consumer.Hatchback;
                case (int)Consumer.SUV:
                    return Consumer.SUV;
                default:
                    Console.WriteLine("such vehicle not available");
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static Public CreatePublicVehicle(int vehicle)
        {
            switch (vehicle)
            {
                case (int)Public.Bus:
                    return Public.Bus;
                case (int)Public.Metro:
                    return Public.Metro;
                case (int)Public.Taxi:
                    return Public.Taxi;
                default:
                    Console.WriteLine("such vehicle not available");
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static Sports CreateSportsVehicle(int vehicle)
        {
            switch (vehicle)
            {
                case (int)Sports.F1:
                    return Sports.F1;
                case (int)Sports.Rally:
                    return Sports.Rally;
                case (int)Sports.OffRoad:
                    return Sports.OffRoad;
                default:
                    Console.WriteLine("such vehicle not available");
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}