using System;

class Word
{
    // Variables
    private string _text;
    private bool _isHidden;
    private Random _random;

    // Constructor
    public Word(string text)
    {
        _text = text;
    }
    
    // Methods
    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

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