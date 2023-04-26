using System;

class Program
{
    static void Main(string[] args)
    {
        // Clear Screen
        Console.Clear();

        // Main Program
        DisplayWelcome();
        string userName = UserNamePrompt();
        int userNumber = UserNumberPrompt();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber, userNumber);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

         static string UserNamePrompt()
        {
            Console.Write("Please enter your Name! ");
            string name = Console.ReadLine();

            return name;   
        }

         static int UserNumberPrompt()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }

         static int SquareNumber(int number)
        {
            int square = number * number;

            return square;
        }

         static void DisplayResult(string name, int square, int userNumber)
        {
            Console.WriteLine($"{name}, the square of your number {userNumber} is {square}");
        }
    }
}