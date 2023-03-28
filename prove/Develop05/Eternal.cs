using System;

public class Eternal : Goal
{
    private string _type = "Eternal Goal:";
    private bool _status;


    public Eternal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _status = false;
    }
    public Eternal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        _status = status;
    }


    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] {GetName()} ({GetDescription()})");
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
      public override void RecordGoalEvent(List<Goal> goals)
    {
       Console.WriteLine($"Well Done! You get {GetPoints()} points!");
    }


}
