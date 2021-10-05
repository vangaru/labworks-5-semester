using System;

namespace Task2
{
    internal static class Program
    {
        private static void Main()
        {
            var mainland = new Mainland { Name = "Africa", Population = 1000000 };
            var planet = new Planet { Name = "Saturn", Mainland = mainland };
            planet.MoveAroundSun();
            planet.InvolveTheDisaster();
        }
    }
}