using System;
using System.Threading;

namespace Task3
{
    public class Route
    {
        private const int MaxVehicleServices = 10;

        public int MovementIntervalMillis { get; init; }
        public int Number { get; init; }
        public Vehicle Vehicle { get; init; }

        public void Start()
        {
            var serviceNumber = 0;
            while (true)
            {
                if (Vehicle.IsBrokeDown)
                    Vehicle.Repair();
                Console.Write($"Route №{Number}: ");
                Vehicle.Move();
                if (serviceNumber == MaxVehicleServices)
                    break;
                Thread.Sleep(MovementIntervalMillis);
                serviceNumber++;
            }
        }
    }
}