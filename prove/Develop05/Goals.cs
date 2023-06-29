using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public abstract string DisplayGoal();
    public abstract int Complete();
    public abstract string SaveGoal();
}