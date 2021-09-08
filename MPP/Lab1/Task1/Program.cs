using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var nums = ConvertArgsToIntArray(args);
            TryPrintNumberWithMaxEjectionIfNotEmpty(nums);
        }

        private static int[] ConvertArgsToIntArray(string[] args) =>
            args.Length == 1 ? Array.Empty<int>() : args[1..args.Length].Select(int.Parse).ToArray();

        private static void TryPrintNumberWithMaxEjectionIfNotEmpty(int[] nums)
        {
            try
            {
                var numberWithMaxEjection = GetNumberWithMaxEjectionIfNotEmpty(nums);
                Console.WriteLine(numberWithMaxEjection);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        private static int GetNumberWithMaxEjectionIfNotEmpty(int[] nums)
        {
            if (nums.Length == 0) throw new ArgumentOutOfRangeException(nameof(nums), "Args cannot be empty");
            var numberEjectionDictionary = GetNumberEjectionDictionary(nums);
            return numberEjectionDictionary
                .Aggregate((x, y) => x.Value > y.Value ? x : y).Key;
        }

        private static Dictionary<int, int> GetNumberEjectionDictionary(IEnumerable<int> arr)
        {
            arr = arr.ToList();
            var numberEjectionDictionary = new Dictionary<int, int>();
            
            foreach (var num in arr)
                numberEjectionDictionary[num] = GetEjection(arr, num);
            
            return numberEjectionDictionary;
        }

        private static int GetEjection(IEnumerable<int> arr, int num)
        {
            var ejection = Math.Abs(arr.Sum(i => num - i));
            return ejection;
        }
    }
}