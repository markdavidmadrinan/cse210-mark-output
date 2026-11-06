using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Member variable
    public List<Entry> _entries;

    // Constructor
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Add an entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all journal entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nYour journal is empty.");
        }
        else
        {
            Console.WriteLine("\n===== MY JOURNAL =====\n");

            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    // Save the journal to a file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(
                    $"{entry._date}~|~{entry._prompt}~|~{entry._response}"
                );
            }
        }

        Console.WriteLine("\nJournal saved successfully!");
    }

    // Load the journal from a file
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            // Clear the current journal first
            _entries.Clear();

            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);

                if (parts.Length == 3)
                {
                    Entry entry = new Entry();

                    entry._date = parts[0];
                    entry._prompt = parts[1];
                    entry._response = parts[2];

                    _entries.Add(entry);
                }
            }

            Console.WriteLine("\nJournal loaded successfully!");
        }
        else
        {
            Console.WriteLine("\nFile not found. Please check the filename.");
        }
    }
}
