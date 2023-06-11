using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetDiscription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        SetName("Breathing");
    }
    public void Run()
    {
        GetReady();
        int lenghtTime = GetDuration();

        int timeRemaining = lenghtTime % 10;
        int isOdd = timeRemaining % 2;
        int firstIn = timeRemaining /2;
        int firstOut = firstIn + isOdd;

        Console.WriteLine();
        Console.Write("Breathe in....");
         for (int i = firstIn; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
            timeRemaining--;
        }
        Console.Write(" ");

        Console.WriteLine();
        Console.Write("Breathe out...");
        for (int i = firstOut; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
            timeRemaining--;
        }
        Console.Write(" ");


        while (timeRemaining > 0)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b");
                timeRemaining--;
            }
            Console.Write(" ");

            Console.WriteLine();
            Console.Write("Breathe out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b");
                timeRemaining--;
            }
            Console.WriteLine(" ");

        }
        EndActvity();
    }
}