using System;
using System.Collections.Generic;

public class Composed : PanelLaw
{
    private int points; //total points for the word
    private int len; //length of the word

    //calculates the score for the word based on its length and number of guesses
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        len = word.Length;
        if (len <= 7)
        {
            points = numGuesses * 2; //multiply number of guesses by 2 for shorter words
        }
        else if (len > 7 && len <= 9)
        {
            points = numGuesses * 3; //multiply number of guesses by 3 for medium-length words
        }
        else {
            points = numGuesses * 4; //multiply number of guesses by 4 for longer words
        }
        return points;
    }

    //displays the final score for the word
    public override void ShowScore()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Composed Points: {points} ");
        Console.ResetColor();
    }
}
