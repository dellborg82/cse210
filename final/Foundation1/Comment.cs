using System;

public class Comment
{
    public string _nameOfPerson;
    public string _comment;

    public Comment(string nameOfPerson, string comment)
    {
        _nameOfPerson = nameOfPerson;
        _comment = comment;
    }

    public void Display()
    {
        Console.WriteLine($"- {_nameOfPerson} - with comment of: {_comment}");
    }
}
