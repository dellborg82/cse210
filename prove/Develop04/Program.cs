using System;

class Program
{
    static void Main(string[] args)
    {
        Boolean isRunning = false;
        int numBreathActvitiesDone = 0;
        int numListActvitiesDone = 0;
        int numReflectActvitiesDone = 0;
        int totalActivities = numBreathActvitiesDone + numListActvitiesDone + numReflectActvitiesDone;
        while (!isRunning)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userAnswer = Console.ReadLine();
            Console.WriteLine();

            switch (userAnswer)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.StartActvity();
                    breathing.Run();
                    numBreathActvitiesDone++;
                    break;
                case "2":
                    ReflectionActivity reflecting = new ReflectionActivity();
                    reflecting.StartActvity();
                    reflecting.Run();
                    numReflectActvitiesDone++;
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.StartActvity();
                    listing.Run();
                    numListActvitiesDone++;
                    break;
                case "4":
                    Console.WriteLine($"Well Done, you did {numBreathActvitiesDone} Breathing Activities, {numListActvitiesDone} Listing Activities, {numReflectActvitiesDone} Reflection Activities, for a total of {totalActivities} Actvities.");
                    Console.WriteLine("Thank you for running the Mindfulness Program!");
                    isRunning = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}