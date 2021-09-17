using System;

namespace Task3
{
    internal static class Program
    {
        private static void Main()
        {
            // test
            var str = Console.ReadLine();
            Console.WriteLine(StripWhitespaces(str));
        }

        private static string StripWhitespaces(string str)
            => string.IsNullOrEmpty(str) ? null : StripNotNullStringWhitespaces(str);

        private static string StripNotNullStringWhitespaces(string str)
        {
            if (str[0] == ' ' && str[^1] == ' ') return StripNotNullStringWhitespaces(str[1..^1]);
            if (str[0] == ' ') return StripNotNullStringWhitespaces(str[1..]);
            if (str[^1] == ' ') return StripNotNullStringWhitespaces(str[..^1]);
            return str;
        }
    }
}