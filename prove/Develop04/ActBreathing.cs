using System;

public class ActBreathing : ActMain
{
    
    private string _message1 = "Breathe in...";
    private string _message2 = "Now breathe out...";
    private string _description = "This will help you relax by breathing in and out slowly. Focus on your breathing.";

    
    public ActBreathing(string activityName, int activityTime) : base(activityName, activityTime)
    {

    }
    public void GetActivityDescription()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(_description);
        Console.ResetColor();
    }

    public void Breathing(int seconds)
    {
        Console.WriteLine();  
        int secondsTimer = 0;
        while (secondsTimer < seconds)
        {
            Console.WriteLine();  
            for (int i = 4; i > 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{_message1}{i}");
                Console.ResetColor();
                Thread.Sleep(1000);
                string blank = new string('\b', (_message1.Length + 2));  
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_message1}  ");
            Console.ResetColor();  
            for (int i = 5; i > 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{_message2}{i}");
                Console.ResetColor();
                Thread.Sleep(1000);
                string blank = new string('\b', (_message2.Length + 2));  
                Console.Write(blank);
                secondsTimer += 1;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{_message2}  ");
            Console.ResetColor();  
        }
    }
}












