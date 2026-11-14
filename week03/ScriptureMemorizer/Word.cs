public class Word
{
    // Attributes
    private string _text;
    private bool _isHidden;


    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }


    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }


    // Show the word
    public void Show()
    {
        _isHidden = false;
    }


    // Check whether the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }


    // Get the word for display
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}

