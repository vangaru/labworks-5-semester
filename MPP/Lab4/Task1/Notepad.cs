using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    public class Notepad : IEnumerable
    {
        private readonly List<NoteSet> _noteSets = new();
        
        public IEnumerator GetEnumerator() => _noteSets.GetEnumerator();

        public void CreateNoteSet()
        {
            var userName = GetUserName();
            var title = GetNoteSetTitleInput();
            var notesCount = GetNotesCountInput();
            var noteSet = CreateAndAddNotes(userName, title, notesCount);
            _noteSets.Add(noteSet);
        }

        private string GetUserName()
        {
            Console.Write("Enter your name: ");
            var userName = Console.ReadLine();
            return userName;
        }

        private string GetNoteSetTitleInput()
        {
            Console.Write("Enter note set title: ");
            var title = Console.ReadLine();
            return title;
        }

        private int GetNotesCountInput()
        {
            int notesCount;
            while (true)
            {
                Console.Write("Enter amount of notes you want to create: ");
                var strNotesCount = Console.ReadLine();
                if (int.TryParse(strNotesCount, out notesCount)) break;
                Console.WriteLine("Incorrect input data format");
            }

            return notesCount;
        }

        private NoteSet CreateAndAddNotes(string author, string title, int notesCount)
        {
            var noteSet = new NoteSet { Author = author, Title = title };
            for (var i = 0; i < notesCount; i++)
                CreateAndAddNote(ref noteSet);
            return noteSet;
        }

        private void CreateAndAddNote(ref NoteSet noteSet)
        {
            var note = CreateNote(noteSet);
            noteSet.Add(note);
        }

        private Note CreateNote(NoteSet noteSet)
        {
            var title = GetUserTitleInput();
            var text = GetUserTextInput();
            return new Note { Author = noteSet.Author, Date = noteSet.Date, Title = title, Text = text };
        }

        private string GetUserTitleInput()
        {
            Console.Write("Enter title of the note: ");
            var title = Console.ReadLine();
            return title;
        }

        private string GetUserTextInput()
        {
            Console.Write("Enter text of the note: ");
            var text = Console.ReadLine();
            return text;
        }
    }
}