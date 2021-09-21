using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Task2
{
    public static class DictionaryManager
    {
        private const string DictionaryFilePath = @"Dictionary";
        private static readonly BinaryTree DictionaryItemsTree = new();
        private static readonly List<DictionaryItem> DictionaryItems = new();

        public static async Task FillTreeFromFile()
        {
             var dictionaryItemsStrings = await File.ReadAllLinesAsync(DictionaryFilePath);
             foreach (var s in dictionaryItemsStrings)
                 DictionaryItems.Add(ToObject(s));
             FillDictionaryItemsTree();
        }
        
        private static DictionaryItem ToObject(string dictionaryItemString)
        {
            var props = dictionaryItemString.Split(' ');
            if (!int.TryParse(props[4], out var count))
                throw new ArgumentException("Invalid count field format", nameof(dictionaryItemString));
            return new DictionaryItem
            {
                EnglishWord = props[0],
                RussianWord = props[2],
                Count = count
            };
        }

        public static async Task CreateItemsAndFillDictionary()
        { 
            CreateAndGetDictionaryItems();
            FillDictionaryItemsTree();
            var dictionaryItemsStrings = CreateAndGetDictionaryItemsStrings();
            await FillDictionaryFile(dictionaryItemsStrings);
        }
        
        private static void CreateAndGetDictionaryItems()
        {
            while (UserAddsNewDictionaryItem())
            {
                var dictionaryItem = CreateAndGetDictionaryItem();
                AddDictionaryItemIfDoesntExists(dictionaryItem);
            }
        }

        private static bool UserAddsNewDictionaryItem()
        {
            string userInput;
            while (true)
            {
                Console.Write("Do you want to add one more item?(y/n): ");
                userInput = Console.ReadLine();
                if (userInput is "y" or "n") break;
            }

            return userInput == "y";
        }

        private static void AddDictionaryItemIfDoesntExists(DictionaryItem dictionaryItem)
        {
            if (DictionaryItems.Contains(dictionaryItem)) return;
            DictionaryItems.Add(dictionaryItem);
        }

        private static DictionaryItem CreateAndGetDictionaryItem()
        {
            var englishWord = GetEnglishWordInput();
            var russianWord = GetRussianWordInput();
            var dictionaryItemCount = GetDictionaryItemCountInput();
            return new DictionaryItem 
                {EnglishWord = englishWord, RussianWord = russianWord, Count = dictionaryItemCount};
        }

        private static string GetEnglishWordInput()
        {
            Console.Write("Input english word: ");
            var englishWord = Console.ReadLine();
            return englishWord;
        }
        
        private static string GetRussianWordInput()
        {
            Console.Write("Input russian word: ");
            var russianWord = Console.ReadLine();
            return russianWord;
        }

        private static int GetDictionaryItemCountInput()
        {
            int count;
            while (true)
            {
                Console.Write("Input dictionary item count: ");
                var countInput = Console.ReadLine();
                if (int.TryParse(countInput, out count)) break;
            }

            return count;
        }

        private static void FillDictionaryItemsTree()
        {
            foreach (var dictionaryItem in DictionaryItems)
                DictionaryItemsTree.Add(dictionaryItem);    
        }

        private static IEnumerable<string> CreateAndGetDictionaryItemsStrings()
        {
            var dictionaryItems = DictionaryItemsTree.ToList();
            var dictionaryItemsStrings = dictionaryItems
                .Select(dictionaryItem => dictionaryItem.ToString()).ToList();
            return dictionaryItemsStrings;
        }

        private static async Task FillDictionaryFile(IEnumerable<string> dictionaryItemsString)
        {
            await File.WriteAllLinesAsync(DictionaryFilePath, dictionaryItemsString);
        }

        public static void PrintItemsToConsoleInEnglishVariant()
        {
            DictionaryItemsTree.TraverseInOrderEnglishVariant();
        }

        public static void PrintItemsToConsoleInRussianVariant()
        {
            DictionaryItemsTree.TraverseInOrderRussianVariant();
        }

        public static void Add(DictionaryItem dictionaryItem)
        {
            DictionaryItems.Add(dictionaryItem);
            DictionaryItemsTree.Add(DictionaryItems.Last());
        }

        public static void Remove(DictionaryItem dictionaryItem)
        {
            foreach (var item in DictionaryItems.Where(item => item.CompareTo(dictionaryItem) == 0))
                DictionaryItemsTree.Remove(item);

            DictionaryItems.Remove(dictionaryItem);
        }
    }
}