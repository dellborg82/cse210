using System;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthSeconds;
    
    public List<Comment> _listOfComments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public int GetNumOfComments()
    {
        int numOfComments = _listOfComments.Count();
        return numOfComments;
    }
     public void Display()
     {
        Console.WriteLine($"{_title} - with a length of {_lengthSeconds} seconds.");
        Console.WriteLine($"Uploaded by {_author}");
        Console.WriteLine($"~~ {GetNumOfComments()} people have commented on this video!");
        foreach (Comment comment in _listOfComments)
        {
            comment.Display();
        }
        Console.WriteLine();
        Console.WriteLine();
        
     }
     public void AddCommentToVideo(Comment comment)
     {
        _listOfComments.Add(comment);
     }
    
}