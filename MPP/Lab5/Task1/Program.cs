using System;

namespace Task1
{
    internal static class Program
    {
        private static void Main()
        {
            var file = new File();
            file.WriteData("str");
            Console.WriteLine(file.ReadData()[0]);
        }
    }
}