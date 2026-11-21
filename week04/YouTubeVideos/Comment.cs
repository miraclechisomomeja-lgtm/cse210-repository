public class Comment
{
    // Attributes
    private string _commenterName;
    private string _commentText;

    // Constructor
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Get the commenter's name and comment
    public string GetCommentText()
    {
        return $"{_commenterName}: {_commentText}";
    }
}

