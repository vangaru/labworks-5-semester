namespace Task1
{
    public class ElectricCar : IVehicle
    {
        public string Name { get; init; }
        public IEngine Engine { get; init; } = new ElectricEngine();
    }
}