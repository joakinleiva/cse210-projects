using System;

public class Basics : PanelLaw
{

    private int points;

    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        points = numGuesses;
        return points;
    }
    public override void ShowScore()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Simple points: {points} ");
        Console.ResetColor();
    }




}