using System;

public class ReflectionActivity : Activity
{
    private string[] _reflectivePrompts = {
       "Think of a time when you did something really difficult, How did you handle it?",
        "Reflect on a time when you felt really Happy",
        "If you could change something about your past, What would it be and Why?",
        "What is something you've had to think quite a lot about?",
        "What's something you've learned about yourself recently?"
    };

    private string[] _reflectiveQuestions = {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "Did you have to step out of your comfort zone? How did that feel?",
        "How did you stay motivated to overcome difficulties during this experience?",
        "What made this time different than other times when you were not as successful?",
        "Did this experience change your perspective on anything?",
        "What did you learn about yourself through this experience?",
        "What is your favorite thing about this experience?",
        "How did you feel when you accomplished your goal?",
        "What are some ways this experience has influenced or impacted you?"
    };

    public ReflectionActivity()
    {
        setName("Reflection");
        setDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void Run()
    {
        GetReady();
        int duration = getDuration();

        Random randomGenerator = new Random();

        Console.WriteLine();
        Console.WriteLine(_reflectivePrompts[randomGenerator.Next(0, _reflectivePrompts.Length)]);
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press a key to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        Console.Clear();

        while (duration > 0)
        {
            Console.WriteLine(_reflectiveQuestions[randomGenerator.Next(0, _reflectiveQuestions.Length)]);
            DisplaySpinner(5);
            duration -= 5;
        }
        EndActivity();
    }
}