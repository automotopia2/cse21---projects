using System;
using System.Runtime.CompilerServices;


class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void LoadToFile()
    {
        
    }
    public void SaveToFile()
    {
        
    }

    public void DeleteEntry()
    {
        
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
    

