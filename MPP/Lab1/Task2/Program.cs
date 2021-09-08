using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    internal static class Program
    {
        private static void Main()
        {
            var arr = new[]
            {
                new[] { 1.0, 2.0 },
                new[] { 3.0, 4.0 },
                new[] { 5.0, 6.0 }
            };
            var flattened = Flatten(arr);
            foreach (var i in flattened)
            {
                Console.WriteLine(i);
            }
        }

        private static double[] Flatten(IEnumerable<double[]> arr)
            => arr.SelectMany(i => i).ToArray();
    }
}