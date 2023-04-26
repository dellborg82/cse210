using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Clear Screen
        Console.Clear();

        // Main Program
        List<int> listNum = new List<int>();

        int userNum = -1;
        Console.WriteLine("Enter a number (Enter 0 to quit thep program).");
        while(userNum != 0)
        {
            Console.Write("Enter a number: ");

            string userAnswer = Console.ReadLine();
            userNum = int.Parse(userAnswer);

            // Only add the nummber if the user enters a number other then 0
            if (userNum != 0)
            {
                listNum.Add(userNum);
            }
        }

        // Part 1 - Add the Sum of the  list
        int sumNum = 0;
        foreach (int number in listNum)
        {
            sumNum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sumNum}");

        // Part 2 - Gets the Average of the list
        float averageNum = ((float)sumNum) / listNum.Count;
        Console.WriteLine($"The Average of the numbers is: {averageNum}");

        // Part 3 - Gets the largest and lowest number in the list
        int maxNum = listNum[0];

        foreach (int number in listNum)
        {
            if (number > maxNum)
            {
                maxNum = number;
            }
        }

        Console.WriteLine($"The Largest Number in the list is: {maxNum}");

        int lowestNum = listNum[0];
        foreach (int number in listNum)
        {
            if (number < lowestNum && number >= 0)
            {
                lowestNum = number;
            }
        }
        Console.WriteLine($"The Smallest Positive Number in the list is: {lowestNum}");
    }

    
}