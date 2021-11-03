namespace Task1
{
    public class InternalCombustionCar : IVehicle
    {
        public string Name { get; init; }
        public IEngine Engine { get; init; } = new InternalCombustionEngine();
    }
}