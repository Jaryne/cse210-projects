class Word
{
    private string _text;
    private bool _isHidden;


    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public bool Hidden()
    {
        return _isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetText()
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

    // Exceeding requirement - Getting a hint**
    public string GetHint()
    {
        if (_isHidden)
        {
            return _text[0] + new string('_', _text.Length - 1);
        }
        else
        {
            return _text;
        }
    }
}