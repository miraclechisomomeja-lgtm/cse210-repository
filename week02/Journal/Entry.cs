using System;

// The Entry class stores and displays one journal entry.
public class Entry
{
    // Stores the date.
    public string _date;

    // Stores the time.
    public string _time;

    // Stores the journal question.
    public string _promptText;

    // Stores the user's written response.
    public string _entryText;

    // Stores the user's mood.
    public string _mood;

    // Displays all information in this entry.
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
    }
}

