using System;

namespace Task1
{
    internal static class Program
    {
        private static void Main()
        {
            var electricCarFactory = new ElectricCarFactory();
            var electricCar = electricCarFactory.CreateVehicle("Tesla model x");
            electricCar.Engine.Initiate();

            var internalCombustionCarFactory = new InternalCombustionCarFactory();
            var internalCombustionCar = internalCombustionCarFactory.CreateVehicle("Audi R8");
            internalCombustionCar.Engine.Initiate();
        }
    }
}