using System;
// Importing the System namespace which contains fundamental classes and base classes.

public class Instructions
{
    // Defining a class called Instructions.

    private string _howToPlay = $@"
******************************************
When you begin playing the game, you will see some empty spaces that indicate the letters of a word that you need to guess.
Your task is to guess the missing letters correctly, one at a time, until the entire word is revealed. 

If you guess a letter that is part of the word, it will fill in the corresponding blank space.
However, if you guess a letter that is not part of the word, the game will draw another part of the hangman's gallows.

The goal of the game is to figure out the secret word before the entire hangman's gallows is drawn, which would indicate that you have lost the game. 
Remember, you can only make seven incorrect guesses, so use your guesses wisely!
******************************************

*** Return to menu by pressing Enter key ***";
    // Declaring a private string variable called _howToPlay which contains a multiline string that provides instructions on how to play the game.

    public void GetInstructions()
    {
        Console.Clear();  
        // Clearing the console screen.

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        // Setting the foreground color of the console to DarkYellow.

        Console.Write(_howToPlay);
        // Writing the instructions to the console.

        Console.ResetColor();
        // Resetting the console color to its default.

        var input = Console.ReadKey();
        // Reading a key from the console input.

        if (input.Key == ConsoleKey.Enter)
        {
            Console.Clear();  
            // If the Enter key is pressed, clear the console screen.
        }
    }
    // Defining a public method called GetInstructions which does not take in any arguments and does not return anything.
}
// End of the Instructions class.
