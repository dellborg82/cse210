using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int worth) : base(name, description, worth)
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
        SetIsComplete(true);
        return GetPoints();
    }

    public override string SaveGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        bool isComplete = IsComplete();

        return ("SimpleGoal|" + name + "|" + description + "|" + points + "|" + isComplete);
    }
}