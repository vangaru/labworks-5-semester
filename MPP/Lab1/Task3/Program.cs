#nullable enable
using System;
using System.Linq;

namespace Task1
{
    internal static class Program
    {
        private static void Main()
        {
            Console.WriteLine(StripWhiteSpaces("") == null); ;
            Console.WriteLine(StripWhiteSpaces(" ") == null);
            Console.WriteLine(StripWhiteSpaces(" a bc"));
            Console.WriteLine(StripWhiteSpaces(" a bc")!.Length);
            Console.WriteLine(StripWhiteSpaces(" abc "));
            Console.WriteLine(StripWhiteSpaces(" abc ")!.Length);
            Console.WriteLine(StripWhiteSpaces("abc "));
            Console.WriteLine(StripWhiteSpaces("abc ")!.Length);
        }

        private static string? StripWhiteSpaces(string? str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            if (str.Length >= 2 && str.First() == ' ' && str.Last() == ' ') return str[1..^1];
            if (str.First() == ' ') return str[1..];
            if (str.Last() == ' ') return str[..^1];
            return str;
        }
    }
}