using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Task1
{
    internal static class Program
    {
        private static async Task Main()
        {
            const string filePath = @"../../../TestFile.txt";
            await PrintSortedAscFileLinesListAsync(filePath);
        }

        private static async Task PrintSortedAscFileLinesListAsync(string filePath)
        {
            var listOfFileLines = await GetListOfFileLinesAsync(filePath);
            foreach (var line in listOfFileLines.OrderBy(l => l.Length))
                Console.WriteLine(line);
        }

        private static async Task<List<string>> GetListOfFileLinesAsync(string filePath)
        {
            var listOfFileLines = new List<string>();
            using var streamReader = new StreamReader(filePath, System.Text.Encoding.Default);
            string line;
            while ((line = await streamReader.ReadLineAsync()) != null) 
                listOfFileLines.Add(line);

            return listOfFileLines;
        }
    }
}