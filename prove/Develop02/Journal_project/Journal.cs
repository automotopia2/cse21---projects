using System;
using System.Runtime.CompilerServices;
using System.IO;


class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void LoadToFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry(date, prompt, response);

            _entries.Add(entry);
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetResponse()}");
            }
        }
    }

    public void DeleteEntry(int journalIndex)
    {
        _entries.RemoveAt(journalIndex);
    }
    public void DisplayEntriesForDelete()
    {
        for(int i = 0; i<_entries.Count; i++)
        {
            Console.Write($"Entry {i + 1}:\n");
            _entries[i].DisplayEntry();
        }
    }   

    public List<Entry> GetEntries()
    {
        return _entries;
    }

    public void DisplayEntries()
    {
        for(int i = 0; i<_entries.Count; i++)
        {
            _entries[i].DisplayEntry();
        }
    }

}    
    

