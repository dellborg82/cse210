using System;

class Program
{
    static void Main(string[] args)
    {
        // Clear Screen
        Console.Clear();

        // Main Code
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 101);

        int numberGuess = -1;
        int numOfGuesses = 0;

        // Loop
        while (numberGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            numberGuess = int.Parse(Console.ReadLine());  

            if (magicNumber > numberGuess)
            {
                Console.WriteLine("Higher");
                numOfGuesses = numOfGuesses +1;
            }
            else if (magicNumber < numberGuess)
            {
                Console.WriteLine("Lower");
                numOfGuesses = numOfGuesses +1;
            }
            else
            {
                Console.WriteLine($"You Guessed it! It took you {numOfGuesses} guesses!");
            }
        }
    }
}