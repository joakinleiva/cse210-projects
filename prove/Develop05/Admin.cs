using System;
using System.IO;

public class Admin

{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;


    
    public Admin()
    {
        _totalPoints = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
    public void AddBonus(int bonusPoints)
    {
        _totalPoints += bonusPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public List<Goal> GetGoalsList()
    {
        return _goals;
    }

    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nYour Goals :");

            int index = 1;
            foreach (Goal goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("\nYou have no goals!");
        }
    }
    public void RecordGoalEvent()
    {
        ListGoals();

        Console.Write("\nWhich goal did you finish?  ");
        int select = int.Parse(Console.ReadLine())-1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(_goals);

        Console.WriteLine($"\n*** You get {GetTotalPoints()} points! ***\n");
    }
    public void SaveGoals()
    {
        Console.Write("\nName for this goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine(GetTotalPoints());
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nName of your goal file?  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);
            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);
            
            readText = readText.Skip(1).ToArray();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    Simple sGoal = new Simple(type, name, description, points, status);
                    AddGoal(sGoal);
                }
                if (entries[0] == "Eternal Goal:")
                {
                    Eternal eGoal = new Eternal(type, name, description, points, status);
                    AddGoal(eGoal);
                }
                if (entries[0] == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    Check clGoal = new Check(type, name, description, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(clGoal);
                }
                if (entries[0] == "Negative Goal:")
                {
                    Negative nGoal = new Negative(type, name, description, points, status);
                    AddGoal(nGoal);
                }
            }
        }
    }


}