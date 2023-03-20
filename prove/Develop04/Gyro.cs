using System;
using System.Diagnostics;

public class Gyro
{
    int counter;

    public void Stopwatch()
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < 10)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b"); 
            Console.Write("-"); 
        }

        timer.Stop();

    }

    private void ConsoleGyro()
    {
        counter = 0;
    }

    public void Turn()
    {
        counter++;

        int remainder = counter % 4;
        if (remainder == 0)
        {
            Console.Write("=>");
        }
        else if (remainder == 1)
        {
            Console.Write("==>");
        }
        else if (remainder == 2)
        {
            Console.Write("===>");
        }
        else if (remainder == 3)
        {
            Console.Write("====>");
        }
        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }

    public void ShowSimplePercentage()
    {
        for (int i = 0; i <= 100; i++)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"\rGet Ready... {i}%   ");
            Console.ResetColor();
            Thread.Sleep(50);
        }
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("\rGet Ready...      ");
        Console.ResetColor();
    }

    public void ShowGyro()
    {
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            int remainder = counter % 4;
            if (remainder == 0)
            {
                Console.Write("/");
            }
            else if (remainder == 1)
            {
                Console.Write("-");
            }
            else if (remainder == 2)
            {
                Console.Write("\\");
            }
            else if (remainder == 3)
            {
                Console.Write("|");
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            counter++;
            Thread.Sleep(100);
        }
    }

    public void ShowGyroReady()
    {
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            int remainder = counter % 4;
            if (remainder == 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Get ready... /");
                Console.ResetColor();
            }
            else if (remainder == 1)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Get ready... -");
                Console.ResetColor();
            }
            else if (remainder == 2)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Get ready... \\");
                Console.ResetColor();
            }
            else if (remainder == 3)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Get ready... |");
                Console.ResetColor();
            }
            Console.SetCursorPosition(Console.CursorLeft - 14, Console.CursorTop);
            counter++;
            Thread.Sleep(75);
        }
    }

    public void ShowGyroDone()
    {
        Console.WriteLine();
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            int remainder = counter % 4;
            if (remainder == 0)
            {
                Console.Write("Well done!! /");
            }
            else if (remainder == 1)
            {
                Console.Write("Well done!! -");
            }
            else if (remainder == 2)
            {
                Console.Write("Well done!! \\");
            }
            else if (remainder == 3)
            {
                Console.Write("Well done!! |");
            }
            Console.SetCursorPosition(Console.CursorLeft - 13, Console.CursorTop);
            counter++;
           

            Thread.Sleep(75);
        }
    }




}