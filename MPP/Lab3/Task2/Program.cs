using System;
using System.Threading.Tasks;

namespace Task2
{
    internal static class Program
    {
        private static async Task Main()
        {
            // await DictionaryManager.CreateItemsAndFillDictionary();
            // DictionaryManager.PrintItemsToConsole();
            // DictionaryManager.Remove(new DictionaryItem {EnglishWord = "Cat", RussianWord = "Кот", Count = 3});
            // DictionaryManager.PrintItemsToConsole();
            // DictionaryManager.Add(new DictionaryItem {EnglishWord = "Summer", RussianWord = "Лето", Count = 5});
            // DictionaryManager.PrintItemsToConsole();
            await DictionaryManager.FillTreeFromFile();
            var dItem = new DictionaryItem { EnglishWord = "Door", RussianWord = "Дверь" };
            DictionaryManager.Add(dItem);
            DictionaryManager.PrintItemsToConsoleInRussianVariant();
            DictionaryManager.Remove(dItem);
            DictionaryManager.PrintItemsToConsoleInRussianVariant();
            Console.WriteLine(DictionaryManager.Find("Cat").ToString());
        }
    }
}