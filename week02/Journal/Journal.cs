using System.IO;
using System.Collections.Generic;

// The Journal class manages all journal entries.
public class Journal
{
    // Creates a list to store multiple journal entries.
    public List<Entry> _entries = new List<Entry>();

    // Adds a new entry to the journal.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Displays all entries stored in the journal.
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();

            Console.WriteLine();
        }
    }

    // All journal entries saved to a file.
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // Iterates through every entry in the journal.
            foreach (Entry entry in _entries)
            {
                // Saves the date, time, prompt, response and mood.
                outputFile.WriteLine(
                    $"{entry._date} | {entry._time} | {entry._promptText} | {entry._entryText} | {entry._mood}"
                );
            }
        }
    }

    // Loads previously saved journal entries from a file.
    public void LoadFromFile(string file)
    {
        // Clears existing entries from memory.
        _entries.Clear();

        // Reads all lines from the specified file.
        string[] lines = File.ReadAllLines(file);

        // Processes each saved journal entry.
        foreach (string line in lines)
        {
            // Separates the information using the pipe character.
            string[] parts = line.Split("|");

            // Creates a new Entry object.
            Entry entry = new Entry();

            // Restores the saved information. The trim used here
            // are used to remove extra unnecessary spaces before and after.
            entry._date = parts[0].Trim();
            entry._time = parts[1].Trim();
            entry._promptText = parts[2].Trim();
            entry._entryText = parts[3].Trim();
            entry._mood = parts[4].Trim();

            // Adds the restored entry to the journal list.
            _entries.Add(entry);
        }
    }
}
