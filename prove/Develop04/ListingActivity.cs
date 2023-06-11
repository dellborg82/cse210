using System;

public class ListingActivity : Activity
{
    private string[] _reflectivePrompts = {
         "How did you apply the teachings of the gospel in your life today?",
        "How did the Matilda Musical affect you today?",
        "How did you work on your Marriage today?",
        "When have you felt the Holy Ghost this month?",
        "What good dead(s) did you perform today?"
    };

    public ListingActivity()
    {
        setName("Listing");
        setDescription("TThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void Run()
    {
        GetReady();
        TimeSpan duration = TimeSpan.FromSeconds(getDuration());

        Random randomGenerator = new Random();

        Console.WriteLine("List as many responses you can to the following prompt:");

        DateTime startTime = DateTime.Now;

        Console.WriteLine(_reflectivePrompts[randomGenerator.Next(0, _reflectivePrompts.Length)]);

        int answerCount = 0;
        while (DateTime.Now - startTime < duration)
        {
            string answer = Console.ReadLine();

            if (answer.Trim().Length > 0)
            {
                answerCount++;
            }
        }

        Console.WriteLine($"You listed {answerCount} items!");

        EndActivity();
    }
}