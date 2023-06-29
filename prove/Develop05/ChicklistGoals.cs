using System;

public class ChecklistGoal : Goal
{
    private int _amount;
    private int _currentAmount;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int amount, int bonus) : base(name, description, points)
    {
        _amount = amount;
        _bonus = bonus;
    }

    public override string DisplayGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        string isComplete = IsComplete() ? "[X]" : "[ ]";

        return (isComplete + " " + name + " (" + description + ")" + " -- Currently compeleted: " + _currentAmount + "/" + _amount);
    }

    public override int Complete()
    {
        _currentAmount++;
        if (_currentAmount >= _amount)
        {
            SetIsComplete(true);
            return GetPoints() + _bonus;
        }
        return GetPoints();
    }

    public override string SaveGoal()
    {
        string name = GetName();
        string description = GetDescription();
        int points = GetPoints();
        bool isComplete = IsComplete();

        return ("ChecklistGoal|" + name + "|" + description + "|" + points + "|" + isComplete + "|" + _amount + "|" + _currentAmount + "|" + _bonus);
    }
}