using System;

namespace Task2
{
    internal static class Program
    {
        private static void Main()
        {
            var array = ReadDoubleArrayFromConsole();
            var flattenedArray = Flatten(array);
            
            // test
            foreach (var i in flattenedArray)
            {
                Console.WriteLine(i);
            }
        }

        private static double[,] ReadDoubleArrayFromConsole()
        {
            var firstDimensionSize = ReadIntFromConsole("Enter size of the array's first dimension: ");
            var secondDimensionSize = ReadIntFromConsole("Enter size of the array's second dimension: ");
            var arr = new double[firstDimensionSize, secondDimensionSize];
            ReadDoubleArrValuesFromConsole(ref arr);
            return arr;
        }

        private static int ReadIntFromConsole(string message = "")
        {
            Console.Write(message);
            var value = Console.ReadLine();
            if (!int.TryParse(value, out var intValue))
                throw new FormatException("Invalid format");
            return intValue;
        }
        
        private static void ReadDoubleArrValuesFromConsole(ref double[,] arr)
        {
            for (var i = 0; i < arr.GetLength(0); i++)
            for (var j = 0; j < arr.GetLength(1); j++)
                arr[i, j] = ReadDoubleFromConsole($"Enter [{i},{j}] element: ");
        }
        
        private static double ReadDoubleFromConsole(string message = "")
        {
            Console.Write(message);
            var value = Console.ReadLine();
            if (!double.TryParse(value, out var doubleValue))
                throw new FormatException("Invalid format");
            return doubleValue;
        }
        
        private static double[] Flatten(double[,] arr)
        {
            var flattenedArray = new double[arr.GetLength(0) * arr.GetLength(1)];
            var index = 0;
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    flattenedArray[index] = arr[i,j];
                    index++;
                }
            }

            return flattenedArray;
        }
    }
}