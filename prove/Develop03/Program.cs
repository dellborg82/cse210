using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptures.Add(new Scripture(new Reference("Enos", 1, 13-14, 16), "And now behold, this was the desire which I desired of him—that if it should so be, that my people, the Nephites, should fall into transgression, and by any means be destroyed, and the Lamanites should not be destroyed, that the Lord God would preserve a record of my people, the Nephites; even if it so be by the power of his holy arm, that it might be brought forth at some future day unto the Lamanites, that, perhaps, they might be brought unto salvation— 14 For at the present our strugglings were vain in restoring them to the true faith. And they swore in their wrath that, if it were possible, they would destroy our records and us, and also all the traditions of our fathers. 16 And I had faith, and I did cry unto God that he would preserve the records; and he covenanted with me that he would bring them forth unto the Lamanites in his own due time."));
        scriptures.Add(new Scripture(new Reference("3 Nephi", 11, 7), "Behold my Beloved Son, in whom I am well pleased, in whom I have glorified my name—hear ye him."));

        Random random = new Random();
        int randomScripture = random.Next(0, scriptures.Count);

        string input = "";

        while (input != "quit" && scriptures[randomScripture].GetWordsleft() > 0)
        {
            Console.Clear();
            Console.WriteLine(scriptures[randomScripture].FormScriptureString());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            scriptures[randomScripture].HideWords();
        }
    }   
    
}