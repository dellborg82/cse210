using System;

public class Prompt
{
    public string _displayPrompt;
    public void RandomPrompt()
    {
        List<string> listOfPrompts = new List<string>();
        listOfPrompts.Add("What was the BEST part of my day today? ");
        listOfPrompts.Add("What was the WORST part of my day today? ");
        listOfPrompts.Add("How did I apply the messages of the Matilda Movie in my life day today? ");
        listOfPrompts.Add("How did I see the hand of the Lord in my life today? ");
        listOfPrompts.Add("If I could do one thing that I did today over, What would it be, and why? ");
        listOfPrompts.Add("What goals did I work on today? How did I work them them? ");
        listOfPrompts.Add("What was your favorite thing that you said today, and Why? ");
        listOfPrompts.Add("The Day is over, What TV Show do you watch, and why? ");
        listOfPrompts.Add("If you went to hogwarts and the sorting hat say's Slitherin to you how do tell him that you think that he's wrong? ");
        
        Random random = new Random();
        int index = random.Next(listOfPrompts.Count);
        _displayPrompt = listOfPrompts[index];
        Console.WriteLine(_displayPrompt);
    }

}