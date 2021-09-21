#nullable enable
using System;

namespace Task2
{
    public class TreeNode : IComparable
    {
        public TreeNode? Left { get; set; }
        public TreeNode? Right { get; set; }
        public DictionaryItem Value { get; set; }

        public int CompareTo(object? obj)
            => Value.CompareTo((DictionaryItem)obj!);
    }
}