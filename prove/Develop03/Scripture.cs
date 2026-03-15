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

    public void Display()
    {
        Console.Write(_reference.GetLocation() + " ");
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }
        for (int i = 0; i < count; i++)
        {
            if (visibleWords.Count == 0) break;

            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }
    public bool IsCompleted()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    
}