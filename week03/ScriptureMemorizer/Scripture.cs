using System.Collections.Generic;

public class Scripture
{
    private Reference _reference = new Reference("", 0, 0);
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
    }

    public void HideRandomWords(int numberToHide)
    {
    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}
