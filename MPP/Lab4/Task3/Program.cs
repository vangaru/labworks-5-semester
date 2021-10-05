using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    internal static class Program
    {
        private static void Main()
        {
            var bus = new Bus { Number = 10 };
            var trolleyBus = new TrolleyBus { Number = 3 };

            var route1 = new Route { MovementIntervalMillis = 1000, Number = 14, Vehicle = bus };
            var route2 = new Route() { MovementIntervalMillis = 1500, Number = 92, Vehicle = trolleyBus };
            
            Parallel.Invoke(() => route1.Start(), 
                () => route2.Start(),
                () =>
                {
                    Thread.Sleep(3000);
                    bus.BreakDown();
                });
        }
    }
}