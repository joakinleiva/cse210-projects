using System;
using System.Collections.Generic;
using System.Threading;

public class Timer : PanelLaw
{
    // attribute to store the points earned by the player
    private int points; 

    // method to calculate the player's score based on their guesses and the word they are trying to guess
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        // total score starts at 0
        int totalScore = 0; 
        // returns the total score
        return totalScore;
    }

    // method to display the player's score
    public override void ShowScore()
    {
        // sets the console text color to magenta
        Console.ForegroundColor = ConsoleColor.Magenta;
        // writes the player's score to the console
        Console.WriteLine($"Simple points: {points} ");
        // resets the console text color to default
        Console.ResetColor();
    }
}
