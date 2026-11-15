

using System;
using System.Collections.Generic;


public class Scripture
{
    // Attributes
    private Reference _reference;
    private List<Word> _words;


    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Separate scripture text into individual words
        string[] words = text.Split(' ');

        // Create a Word object for each word
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }


    // Hide a specified number of random visible words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // Create a temporary list of visible words
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        // Avoid hiding more words than are available
        int count = Math.Min(numberToHide, visibleWords.Count);

        // Randomly select and hide words
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(visibleWords.Count);

            visibleWords[index].Hide();

            // Prevent selecting the same word twice
            visibleWords.RemoveAt(index);
        }
    }


    // Get the complete scripture text for display
    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text.Trim();
    }


    // Check whether all scripture words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }


    // Enhancement 1: Count visible words remaining
    public int GetVisibleWordCount()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }

        return count;
    }


    // Enhancement 3: Reveal one randomly hidden word
    public void ShowRandomWord()
    {
        Random random = new Random();

        List<Word> hiddenWords = new List<Word>();

        // Find all hidden words
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenWords.Add(word);
            }
        }

        // Reveal one randomly selected hidden word
        if (hiddenWords.Count > 0)
        {
            int index = random.Next(hiddenWords.Count);

            hiddenWords[index].Show();
        }
        else
        {
            Console.WriteLine("There are no hidden words to reveal.");
        }
    }
}


