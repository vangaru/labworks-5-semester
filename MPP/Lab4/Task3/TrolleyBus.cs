using System;

namespace Task3
{
    public class TrolleyBus : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"Trolleybus №{Number} moves");
        }
    }
}