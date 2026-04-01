using System;

class Comment
{
    // Variables 
    private string _commentAuth;
    private string _commentText;
    // Constructor
    public Comment(string commentAuth, string commentText)
    {
        _commentAuth = commentAuth;
        _commentText = commentText;
    }
    // Methods
    public void DisplayComment()
    {
        Console.WriteLine($"{_commentAuth}\n'{_commentText}'");
    }
}