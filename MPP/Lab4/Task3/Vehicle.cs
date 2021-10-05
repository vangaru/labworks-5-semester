using System;
using System.Threading;

namespace Task3
{
    public abstract class Vehicle
    {
        private int _number;
        
        public int Number
        {
            get => _number;
            init
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException(nameof(value),
                        "Number of the vehicle cannot be less than zero");
                _number = value;
            }
        }

        public bool IsBrokeDown { get; private set; }

        public void BreakDown()
        {
            IsBrokeDown = true;
        }

        public void Repair()
        {
            Console.WriteLine("Repairing vehicle...");
            Thread.Sleep(1000);
            IsBrokeDown = false;
        }

        public abstract void Move();
    }
}