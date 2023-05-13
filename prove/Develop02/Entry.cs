using System;

public class Entry
{
    public Entry(string prompt, string userEntry)
    {
        // Gets the prompt and stores it in a Variable (As a String)
        _prompt = prompt;
        // Gets the user Entry and stores in in a Variale (As a String)
        _userEntry = userEntry.Replace(",", "|");
        // Gets the date and stores it in a Variable
        _date = DateTime.Now.ToString("MM/dd/yyyy");
    }
    public string _userEntry;
    public string _prompt;
    public string _date;
    // public List<string> _entryList;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_userEntry);
    }
}