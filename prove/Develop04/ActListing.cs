using System;
using System.Diagnostics;

public class ActListing : ActMain
{
    // Attributes 
    private List<string> _promptList = new List<string>
    {
    "Who are people you love the most?",
    "When was the last time you felt God loves you?",
    "Who are people that you have helped this week?",
    
    };
    private List<string> _userList = new List<string>();
    private string _description = "This will help you reflect on the good things in your life by listings some things about it.";

    public ActListing(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetActivityDescription()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(_description);
        Console.ResetColor();
    }
    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    public void ReturnPrompt(int seconds)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();  
        var question = GetRandomPrompt();
        Console.WriteLine("\nList as many responses to this question:");
        Console.WriteLine($"\n--- {question} ---");
        Console.ResetColor();
        CountDown(8);
        Timer(seconds);
    }
    public void Timer(int seconds)
    {

        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("> ");
            Console.ResetColor();
            _userList.Add(Console.ReadLine());
        }
        timer.Stop();
        int listLength = _userList.Count;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\nGreat! You listed {listLength} items!");
        Console.ResetColor();
    }





}