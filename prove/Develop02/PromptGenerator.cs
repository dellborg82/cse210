using System;

public class PromptGenerator

{
    public string _displayPrompt;
    public void randomPrompt()
    {
        // Create a list of Prompts for the program
        List<string> listOfPrompts = new List<string>();
        listOfPrompts.Add("What was the BEST part of my day today? ");
        listOfPrompts.Add("What was the WORST part of my day today? ");
        listOfPrompts.Add("How did I apply the messages of the Matilda Movie in my day today? ");
        listOfPrompts.Add("How did I see the hand of the Lord in my life today? ");
        listOfPrompts.Add("If I could do one thing that I did today over, What would it be, and why? ");
        listOfPrompts.Add("What goals did I work on today? How did I work them them? ");

        // Randomze the prompt
        Random random = new Random();
        int index = random.Next(listOfPrompts.Count);
        _displayPrompt = listOfPrompts[index];
        Console.WriteLine(_displayPrompt);
    }
}