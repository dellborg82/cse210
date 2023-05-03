using System;

public class Resume
{
    public string _name;

    // Initilize the list
    public List<Job> _jobs = new List<Job>();

    // Display the list
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("jobs: ");

        // Loop through the jobs
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}