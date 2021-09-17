using System;

namespace Task1
{
    internal static class Program
    {
        private static void Main()
        {
            var cs1 = new CharSet { Container = { 'a', 'b', 'c', 'd' } };
            var cs2 = new CharSet { Container = { 'c', 'd', 'e', 'f', 'g', 'h' } };
            (cs1 ^ cs2).WriteToConsole();
            cs1.Remove('c');
            cs1.WriteToConsole();
            cs2.Add('j');
            cs2.WriteToConsole();
            Console.WriteLine(cs1.Equals(cs2));
            var cs3 = new CharSet { Container = { 'a', 'b', 'd' } };
            Console.WriteLine(cs1.Equals(cs3));
        }
    }
}