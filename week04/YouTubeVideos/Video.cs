public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

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

    // Comment Section
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCount()
    {
        return _comments.Count;
    }

    // Vid
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Comment Count: {GetCount()}");
        Console.WriteLine("Comments: ");

        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment.GetName()}: '{comment.GetText()}'");
        }

        Console.WriteLine();
    }
}