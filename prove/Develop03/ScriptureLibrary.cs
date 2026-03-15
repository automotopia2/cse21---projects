using System;
using System.Collections.Generic;
using System.IO;

class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary(string filePath)
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
        LoadScriptures(filePath);
    }

    private void LoadScriptures(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 2)
            {
                string location = parts[0].Trim();
                string text = parts[1].Trim();

                Reference reference = new Reference(location, text);
                Scripture scripture = new Scripture(reference, text);
                _scriptures.Add(scripture);
            }
        }
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
