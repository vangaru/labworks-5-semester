using System;

namespace Task2
{
    public class Planet
    {
        public string Name { get; init; }
        public Mainland Mainland { get; set; }

        public void MoveAroundSun()
        {
            Console.WriteLine($"Planet {Name} moves around the Sun...");
        }

        public void InvolveTheDisaster()
        {
            Console.WriteLine("Ohh Damn!!!");
            Mainland.Population /= 2;
        }
    }
}