using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToCsv());
            }
        }
    }

    public void LoadFromFile(string filename, string dateFilter = "all")
    {
        if (File.Exists(filename))
        {
            List<Entry> fileEntries = new List<Entry>();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Entry entry = Entry.FromCsv(line);
                    fileEntries.Add(entry);
                }
            }

            IEnumerable<Entry> filteredEntries = fileEntries;

            if (dateFilter != "all")
            {
                filteredEntries = fileEntries.Where(entry => entry.Date.Contains(dateFilter));
            }

            foreach (Entry entry in filteredEntries)
            {
                Console.WriteLine(entry);
            }
        }
        else
        {
            Console.WriteLine("Journal file not found.");
        }
    }
    public bool HasEntries()
    {
        return entries.Count > 0;
    }
}
