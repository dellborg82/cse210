using System;

public class EternalGoal : Goal
{
public EternalGoal(string name, string description, int points) : base(name, description, points) 
    {

    }

    public override string DisplayGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        string isComplete = IsComplete() ? "[X]" : "[ ]";

        return (isComplete + " " + name + " (" + description + ")");
    }

    public override int Complete()
    {
        return GetPoints();
    }

    public override string SaveGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        bool isComplete = IsComplete();

        return ("EternalGoal|" + name + "|" + description + "|" + points + "|" + isComplete);
    }
}