using System;

class Program
{
    static void Main(string[] args)
    {
        
        // Clear Screen
        Console.Clear();
        // Main Code
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
        // Code to determine if + or -
        string symbol = "";
        if (!(gradePercentage > 95 || gradeLetter == "F"))  
            {
                int gradeRemainder = gradePercentage  % 10;
                if (gradeRemainder >= 7)
                {
                    symbol = "+";
                }
                else if(gradeRemainder <= 3)
                {
                    symbol = "-";
                }
                else
                {
                    symbol ="";
                }
            }
        // Code that writes either Congrats or Sorry based on Percentage
        Console.WriteLine($"Your Grade is: {gradeLetter}{symbol}");

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