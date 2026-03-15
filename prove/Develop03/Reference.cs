using System;

class Reference 
{
    // Variables 
    private string _location;
    private string _text;
    
    // Methods
    public Reference(string location, string text)
    {
        _location = location;
        _text = text;
    }
    
    public string GetLocation()
    {
        return _location;
    }

    public string GetText()
    {
        return _text;
    }
}