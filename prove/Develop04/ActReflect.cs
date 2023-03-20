using System;
using System.Diagnostics;

public class ActReflect : ActMain
{
   
    private List<string> _promptList = new List<string>
    {
    "Think about a hard experience you overcame in life.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you failed at something."
    };
    private List<string> _questionList = new List<string>
    {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "What was your motivation?"
    };
    private List<string> _useQuestionsList = new List<string>();

    private string _prompt;
    private string _question;
    private string _description = "This activity will help you reflect on times in your life when you have overcame trials.";

    public ActReflect(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetActivityDescription()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(_description);
        Console.ResetColor();
    }
    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }
    private string GetRandomQuestion()
    {
        var random = new Random();
        int index = random.Next(_useQuestionsList.Count);
        return _useQuestionsList[index];
    }
    public void ShowPrompt(int seconds)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine();  
        var prompt = GetRandomPrompt();
        
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");
        Console.ResetColor();

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            ShowQuestion(seconds);
        }
    }
    public void ShowQuestion(int seconds)
    {
        _useQuestionsList.AddRange(_questionList); 
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nNow ponder on each of the following questions as they related to this experience.");
        Console.ResetColor();
        CountDown(8);
        Console.Clear();
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < seconds)
        {
            if (_useQuestionsList.Count != 0)
            {
                var question = GetRandomQuestion();
                Console.Write($"\n>> {question}  ");
                _useQuestionsList.Remove(question);  
            }
        }
        timer.Stop();
    }

}