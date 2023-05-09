using System;


// Class: Person (Name of the Class)
// Attributes: (Member Variables)
// * _givenName : string
// * _familyName : string

// Behaviors: (Methods or Functions)
// * ShowEasternName() : void
// * ShowWesternName() : void


class Program
{
    static void Main(string[] args)
    {
        // Clear Screen
        Console.Clear();

        // Prompt for the Class name and stor it in a variable
        Console.Write("Please enter the Class Name: ");
        string className = Console.ReadLine();
        
        // Create Lists for Attributes and Behaviors
        List<string> attributes = new List<string>();
        Console.WriteLine("Enter the Class Attributes (Member Variables). Type done when complete.");
        string attribute = Console.ReadLine();
        while (attribute != "done")
        {
            attributes.Add(attribute);
            attribute = Console.ReadLine();
        }

        List<string> behaviors = new List<string>();
        Console.WriteLine("Enter the Class Behaviors (Methods or Functions). Type done when complete");
        string behavior = Console.ReadLine();
        while (behavior != "done")
        {
            behaviors.Add(behavior);
            behavior = Console.ReadLine();
        }

        // Display the Class Diagram
        Console.WriteLine($"Bellow you will find the Class Diagram for {className}:");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|                                      |");
        Console.WriteLine($"|            {className}              |");
        Console.WriteLine("|                                      |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|                                      |");

        // Print attributes
        foreach (string attributeItem in attributes)
        {
            Console.WriteLine($"|            {attributeItem}              |");
        }
        Console.WriteLine("|                                      |");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|                                      |");
         foreach (string behaviorItem in behaviors)
        {
            Console.WriteLine($"|            {behaviorItem}              |");
        }
        Console.WriteLine("|                                      |");
        Console.WriteLine("----------------------------------------");
    }
}