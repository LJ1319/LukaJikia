namespace Practice_2
{
    internal partial class Program
    {
        public interface ILandVehicle
        {
            int NumberOfPassengers { get; set; }
            double EngineVolume { get; set; }
            int HorsePower { get; set; }
            int MaxSpeed { get; set; }
            bool Armored { get; set; }
        }
    }
}