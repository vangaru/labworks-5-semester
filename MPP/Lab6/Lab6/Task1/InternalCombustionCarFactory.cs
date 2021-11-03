namespace Task1
{
    public class InternalCombustionCarFactory : IFactory
    {
        public IVehicle CreateVehicle(string name)
        {
            return new InternalCombustionCar { Name = name };
        }
    }
}