class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;


    // Constructor for single verses
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;

    }

    // Constructor for ranged verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;

    }

    // Get formatted reference
    public string GetReference()
    {
        if (_endVerse == 0 || _startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}