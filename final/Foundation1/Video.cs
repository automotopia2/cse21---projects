using System;

class Video
{
    // Variables
    private string _title;
    private string _author;
    private int _length; // In seconds
    private List<Comment> _comments = new List<Comment>();
    // Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    // Methods
    public int ReturnNumberOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public void DisplayVideo()
    {
        Console.WriteLine("--VIDEO--");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Runtime: {_length} seconds");
        Console.WriteLine();
        Console.WriteLine("--COMMENTS--");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
            Console.WriteLine();
        }
    }
}