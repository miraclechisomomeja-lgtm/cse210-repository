public class Reference
{
    private string _book = "";
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Single verse, e.g. John 3:16
    public Reference(string book, int chapter, int verse)
    {
    }

    // Verse range, e.g. Proverbs 3:5-6
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
    }

    public string GetDisplayText()
    {
        return "";
    }
}


