using System;
using System.Collections.Generic;

public class Crossword : PanelLaw //renamed class to reflect purpose of game
{
    //dictionary that maps each letter of the alphabet to a corresponding point value
    private Dictionary<string, int> scrabblePointValues = new Dictionary<string, int>()
    {
        {"e", 1},
        {"a", 1},
        {"i", 1},
        {"o", 1},
        {"n", 1},
        {"r", 1},
        {"t", 1},
        {"l", 1},
        {"s", 1},
        {"u", 1},
        {"d", 2},
        {"g", 2},
        {"b", 3},
        {"c", 3},
        {"m", 3},
        {"p", 3},
        {"f", 4},
        {"h", 4},
        {"v", 4},
        {"w", 4},
        {"y", 4},
        {"k", 5},
        {"j", 8},
        {"x", 8},
        {"q", 10},
        {"z", 10}
    };
    
    private int wordScore; //renamed variable for clarity

    //overrides the CalculateScore method from the base class to calculate the score of a given word
    public override int CalculateScore(int numGuesses, List<string> letters, string word)
    {
        wordScore = 0; //initialize word score to 0

        //loop through each letter of the word
        foreach (string letter in letters)
        {
            string lowercaseLetter = letter.ToLower(); //convert to lowercase for consistency

            //if the letter is in the dictionary, add its point value to the word score
            if (scrabblePointValues.ContainsKey(lowercaseLetter))
            {
                wordScore += scrabblePointValues[lowercaseLetter];
            }
        }

        return wordScore; //return the final word score
    }
    
    //overrides the ShowScore method from the base class to print the final score to the console
    public override void ShowScore()
    {
        Console.ForegroundColor = ConsoleColor.Magenta; //set console text color to magenta
        Console.WriteLine($"Total score: {wordScore}"); //print final word score
        Console.ResetColor(); //reset console text color
    }
}
