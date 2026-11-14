

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

        // Separate the scripture text into individual words
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

        // Create a temporary list of words that are not hidden
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        // Avoid trying to hide more words than are available
        int count = Math.Min(numberToHide, visibleWords.Count);

        // Randomly select and hide words
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(visibleWords.Count);

            visibleWords[index].Hide();

            // Remove the selected word to prevent selecting it twice
            visibleWords.RemoveAt(index);
        }
    }


    // Get the complete scripture text for display
    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";

        // Add each word to the scripture text
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        // Remove unnecessary spaces at the beginning and end
        return text.Trim();
    }


    // Check whether all words in the scripture are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            // If at least one word is visible, return false
            if (!word.IsHidden())
            {
                return false;
            }
        }

        // All words are hidden
        return true;
    }

    // ENHANCEMENT: counts the number of words that are still visible.
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
}



