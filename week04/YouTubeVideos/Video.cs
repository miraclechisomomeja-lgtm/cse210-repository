

using System.Collections.Generic;

public class Video
{
    // Attributes
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    // Add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Return the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    // Return video information
    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    // Return all comments
    public List<Comment> GetComments()
    {
        return _comments;
    }
}

