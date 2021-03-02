using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks4
{
    class NotesStore
    {
        public static int Count { get ; private set; }
        public static List<NotesStore> ActiveNotes { get; private set; }
        public static List<NotesStore> CompletedNotes { get; private set; }
        public static List<NotesStore> notes;
        public DateTime CreationTime { get; private set; }        
        public string State { get; private set; }
        public string Name { get; private set; }
        static NotesStore()
        {
            Count = 0;
            notes = new List<NotesStore>();
            ActiveNotes = new List<NotesStore>();
            CompletedNotes = new List<NotesStore>();
        }
        private NotesStore(string state, string name)
        {
            this.State = state;
            this.Name = name;
            this.CreationTime = DateTime.Now;
        }
        public static List<NotesStore> AddNote(string state, string name)
        {
            if (state == "completed" || state == "active" || state == "others")
            {
                if (name == "")
                {
                    Console.WriteLine("Name cannot be empty");
                }
                else
                {
                    notes.Add(new NotesStore(state, name));
                    Count++;
                    if (state == "active")
                    {
                        ActiveNotes.Add(new NotesStore(state, name));
                    }
                    if (state == "completed")
                    {
                        CompletedNotes.Add(new NotesStore(state, name));
                    }
                }
            }
            else
            {
                Console.WriteLine($"Invalid state: {state}");
            }
            return notes;
        }
        public static List<NotesStore> GetNotes(string state)
        {
            if (state != "completed" || state != "active" || state != "others")
            {
                Console.WriteLine($"Invalid state: {state}");
                return null;
            }
            List<NotesStore> SameStateNotes = new List<NotesStore>();
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].State == state)
                {
                    SameStateNotes.Add(notes[i]);
                }
            }
            return SameStateNotes;
        }
        public static void DeleteNote(string name)
        {
            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i].Name == name)
                {
                    notes.RemoveAt(i);
                    Count--;
                }
            }
            for (int i = 0; i < ActiveNotes.Count; i++)
            {
                if (ActiveNotes[i].Name == name)
                {
                    ActiveNotes.RemoveAt(i);
                }
            }
            for (int i = 0; i < CompletedNotes.Count; i++)
            {
                if (CompletedNotes[i].Name == name)
                {
                    CompletedNotes.RemoveAt(i);
                }
            }
        }
        public static void PrintActiveNote()
        {
            for (int i = 0; i < ActiveNotes.Count; i++)
            {
                Console.WriteLine($"Note name: {ActiveNotes[i].Name}, Note state: {ActiveNotes[i].State}");
            }
        }
        public static void PrintCompletedNote()
        {
            for (int i = 0; i < CompletedNotes.Count; i++)
            {
                Console.WriteLine($"Note name: {CompletedNotes[i].Name}, Note state: {CompletedNotes[i].State}");
            }
        }
    }
}
