using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        setName("Breathing");
        setDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void Run()
    {
        GetReady();
        int lenghtTime = getDuration();

        int remainder = lenghtTime % 10;
        int odd = remainder % 2;
        int firstBreatheIn = remainder / 2;
        int firstBreatheOut = firstBreatheIn + odd;

        Console.WriteLine();
        Console.Write("Breathe in...");
        for (int i = firstBreatheIn; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
            lenghtTime--;
        }
        Console.Write(" ");

        Console.WriteLine();
        Console.Write("Breathe out...");
        for (int i = firstBreatheOut; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
            lenghtTime--;
        }
        Console.Write(" ");


        while (lenghtTime > 0)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b");
                lenghtTime--;
            }
            Console.Write(" ");

            Console.WriteLine();
            Console.Write("Breathe out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b");
                lenghtTime--;
            }
            Console.WriteLine(" ");

        }
        EndActivity();
    }
}