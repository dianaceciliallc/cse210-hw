using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using ( StreamWriter writer = new StreamWriter(file))
        {
            for(int i = 0; i < _entries.Count; i++)
            {
                writer.WriteLine($"{_entries[i]._date}|{_entries[i]._promptText}|{_entries[i]._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        using ( StreamReader reader = new StreamReader(file))
        {
            string line;

            while ( (line = reader.ReadLine()) != null )
            {
                string[] parts = line.Split('|');

                Entry newEntry = new Entry();

                newEntry._date =  parts[0];
                newEntry._promptText = parts[1];
                newEntry._entryText = parts[2];

                AddEntry(newEntry);
            }
        }
    }
}