using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Journal Program!");

        Prompt promptAnswer = new Prompt();
        Journal journal = new Journal();

        static string askForUserChoice()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Please type the number of the option you choose?");
            string userAnswer = Console.ReadLine();
            return userAnswer;
        }

        string userAnswer = "";

        while (userAnswer != "5")
        {
            userAnswer = askForUserChoice();
            // Using Switch Case instead of if else
            switch (userAnswer)
            {
                case "1": // Write
                    promptAnswer.RandomPrompt();
                    Entry entry = new Entry(promptAnswer._displayPrompt, Console.ReadLine());
                    journal._entries.Add(entry);
                    break;
                case "2": // Display
                    journal.DisplayEntries();
                    break;
                case "3": // Load
                    Console.WriteLine("Please enter the filename?");
                    journal.LoadFromFile(Console.ReadLine());
                    break;
                case "4": // Save
                    Console.WriteLine("Please enter the filename?");
                    journal.SaveToFile(Console.ReadLine());
                    break;
                case "5": // Quit
                    Console.WriteLine("Thank you for using the Journal Program. Please come again soon!");
                    break;
                default:
                    Console.WriteLine("You have entered an invalid choice");
                    break;
            }

        }

    }
}