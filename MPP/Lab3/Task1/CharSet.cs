#nullable enable
using System;
using System.Collections;
using System.Linq;

namespace Task1
{
    public class CharSet
    {
        public ArrayList Container { get; } = new();

        public void Add(char c) => Container.Add(c);

        public void Remove(char c)
        {
            if (!Container.Contains(c))
                throw new ArgumentException("Container doesnt exist in container", nameof(c));
            Container.Remove(c);
        }

        public bool Contains(char c) => Container.Contains(c);

        public void WriteToConsole()
        {
            Console.WriteLine(ToString());
        }

        public override bool Equals(object? obj)
        {
            CharSet charSetToCompare;
            try
            {
                charSetToCompare = (CharSet)obj!;
            }
            catch
            {
                return false;
            }

            return Container.Count == charSetToCompare.Count() 
                   && ElementsEqual(charSetToCompare);
        }

        public int Count() => Container.Count;

        private bool ElementsEqual(CharSet other)
        {
            for (var i = 0; i < other.Count(); i++)
            {
                if ((char)Container[i]! != other[i]) 
                    return false;
            }

            return true;
        }

        public static CharSet operator ^(CharSet cs1, CharSet cs2)
            => cs1.Count() > cs2.Count() ? Intersect(cs1, cs2) : Intersect(cs2, cs1);

        private static CharSet Intersect(CharSet cs1, CharSet cs2)
        {
            var resultCharSet = new CharSet();
            foreach (var el in cs1.Container)
                if (cs2.Contains((char)el))
                    resultCharSet.Add((char)el);
            return resultCharSet;
        }

        public char this[int i]
        {
            get
            {
                if (i < 0 || i >= Container.Count)
                    throw new IndexOutOfRangeException("Index of the charSet is out of range");
                return (char)Container[i]!;
            }
            set
            {
                if (i < 0 || i >= Container.Count)
                    throw new IndexOutOfRangeException("Index of the charSet is out of range");
                Container[i] = value;
            }
        }

        public override string ToString()
            => Container
                .Cast<char>()
                .Aggregate("{ ", (current, el) 
                    => current + $"\'{el}\', ") + "}";
        
    }
}