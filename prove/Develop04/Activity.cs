using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _lenghtTime;
    protected int _spinner;

    public void SetDuration(int lenghtTime)
    {
        _lenghtTime = lenghtTime;
    }
    public int GetDuration()
    {
        return _lenghtTime;
    }
    public void SetDiscription(string description)
    {
        _description = description;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void DisplaySpinner(int timeToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.ElapsedMilliseconds / 1000 < timeToRun)
        {
            _spinner++;
            switch (_spinner % 4)
            {
                case 0:
                    Console.Write("/");
                    break;
                case 1:
                    Console.Write("-");
                    break;
                case 2:
                    Console.Write("\\");
                    break;
                case 4:
                    Console.Write("|");
                    break;
            }
            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write(" ");
    }
    public void StartActvity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Actvity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in Seconds would you like to run the program? ");
        int.Parse(Console.ReadLine());
    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(3);
    }
    public void EndActvity()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done, you have completed the activity!");
        DisplaySpinner(3);
        Console.WriteLine($"You have completed another {_lenghtTime} Seconds of the {_name} Actvity");
        DisplaySpinner(3);
    }
}