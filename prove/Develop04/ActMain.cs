using System;

public class ActMain
{
    
    private string _activityName;
    private int _activityTime;
    private string _message = "You may begin in...";

    
    public ActMain(string activityName, int activityTime)
    {
        _activityName = activityName;
        _activityTime = activityTime;
    }
    public void GetActivityName()
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity\n");
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public int GetActivityTime()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _activityTime = userSeconds;
        return userSeconds;
    }
    public void SetActivityTime(int activityTime)
    {
        _activityTime = activityTime;
    }

   
    public void GetReady()
    {
        Console.Clear();
        Gyro rolling = new Gyro();
        rolling.ShowGyroReady();
    }

    public void GetDone()
    {
        Gyro rolling = new Gyro();
        rolling.ShowGyroDone();
        Console.WriteLine($"\nYou have completed another {_activityTime} seconds of the {_activityName} Activity!");
        rolling.ShowGyro();
    }
     public void CountDown(int time)
    {
        Console.WriteLine();  
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{_message}{i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_message.Length + 5));  
            Console.Write(blank);
        }
        Console.WriteLine($"Go:                                  ");  
    }


}
