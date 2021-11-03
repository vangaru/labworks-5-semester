namespace Task1
{
    public interface IVehicle
    {
        public string Name { get; init; }
        public IEngine Engine { get; init; }
    }
}