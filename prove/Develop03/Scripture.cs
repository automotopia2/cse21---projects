using System;
using System.Collections.Generic;

class Scripture
{
    // Variables
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        // Split the text and wrap each piece in a Word object
        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }
}