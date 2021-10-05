using System;

namespace Task3
{
    public class Bus : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"Bus №{Number} moves...");            
        }
    }
}