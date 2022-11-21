namespace Practice_2
{
    internal partial class Program
    {
        public class Car : CitizenDrivable, ILandVehicle
        {
            public string Mark { get; set; }
            public string ReleaseYear { get; set; }

            public Car(Consumer style, int numberOfPassengers, double engineVolume, int horsePower, bool armored, string mark, string releaseYear)
            {
                Style = style;
                NumberOfPassengers = numberOfPassengers;
                EngineVolume = engineVolume;
                HorsePower = horsePower;
                Armored = armored;
                Mark = mark;
                ReleaseYear = releaseYear;
            }

            public Consumer Style { get; set; }
            public int NumberOfPassengers { get; set; }
            public double EngineVolume { get; set; }
            public int HorsePower { get; set; }
            public int MaxSpeed { get; set; }
            public bool Armored { get; set; }

            public override void StartEngine()
            {
                throw new NotImplementedException();
            }

            public override void StopEngine()
            {
                throw new NotImplementedException();
            }
        }
    }
}