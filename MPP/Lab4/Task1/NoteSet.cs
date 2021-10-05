using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class NoteSet : IEnumerable
    {
        private readonly List<Note> _notes = new();

        public string Title { get; init; }
        public string Author { get; set; }
        public DateTime Date { get; } = DateTime.Now;
        public int Count => _notes.Count;

        IEnumerator IEnumerable.GetEnumerator()
            => _notes.GetEnumerator();

        public void Add(Note note)
        {
            _notes.Add(note);
        }

        public override string ToString()
        {
            var str = $"{Title} {Author} {Date:dd/MM/yyyy hh:mm} - {Count} notes\n";
            str = _notes.Aggregate(str, (current, note) => current + $"{note}\n");
            return str;
        }
    }
}