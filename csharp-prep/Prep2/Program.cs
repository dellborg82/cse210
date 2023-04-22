using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("What is your Grade percentage? ");
        string gradeNumber = Console.ReadLine();

        int gradePercentage = int.Parse(gradeNumber);

        string  gradeLetter = "";

        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
         else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
         else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your Grade is: {gradeLetter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, You have passed!");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass, Better Luck next time.");
        }


    }
}