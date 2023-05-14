using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                // Read each line
                string line = reader.ReadLine();
                // Split into parts by spliting from the Comma
                string[] parts = line.Split(',');
                // Pulls the Saved Entry from the split and store it in a variable
                string savedEntry = parts[1];
                // Pulls the prompt used to prompt the entry and store it in a variable
                Entry entry = new Entry(parts[0], savedEntry.Replace("|", ","));
                // pulls the date from the entry, and stores it in a variable
                entry._date = parts[2];
                // adds the entries to the list. 
                _entries.Add(entry);
            }
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                // Writes the entries to the file. 
                outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._userEntry}");
            }
        }
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            // Display Message if there is no entries in the list.
            Console.WriteLine("No entries to display");
            return;
        }
        foreach (Entry entry in _entries)
        {
            // Find how many entries in the list and display the count
            Console.WriteLine($"There are {_entries.Count} Journal Entries in this Journal!");
            Console.WriteLine();
            // Display what's in the list _entries
            entry.Display();
            Console.WriteLine();
        }
    }
}