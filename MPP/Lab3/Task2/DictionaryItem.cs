#nullable enable
using System;

namespace Task2
{
    public class DictionaryItem : IComparable
    {
        public string? RussianWord { get; init; }
        public string? EnglishWord { get; init; }
        public int Count { get; set; } = 1;

        public int CompareTo(object? obj)
            => Count - ((DictionaryItem)obj!).Count;

        public override string ToString()
            => $"{EnglishWord} - {RussianWord} : {Count}";

        public string ToRussianVariantString()
            => $"{RussianWord} - {EnglishWord} : {Count}";
    }
}