using System;

namespace Task1
{
    internal static class Program
    {
        private static void Main()
        {
            var notePad = new Notepad();
            notePad.CreateNoteSet();
            notePad.CreateNoteSet();
            foreach (var noteSet in notePad)
                Console.WriteLine(noteSet.ToString());
        }
    }
}