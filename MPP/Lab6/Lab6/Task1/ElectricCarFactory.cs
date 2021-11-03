namespace Task1
{
    public class ElectricCarFactory : IFactory
    {
        public IVehicle CreateVehicle(string name)
        {
            return new ElectricCar { Name = name };
        }
    }
}
