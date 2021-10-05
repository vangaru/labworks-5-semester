using System;

namespace Task1
{
    public class Note
    {
        public string Title { get; init; }
        public string Author { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Text { get; set; }

        public override string ToString()
            => $"{Title} {Author} {Date:dd/MM/yyyy hh:mm}\n{Text}";
    }
}