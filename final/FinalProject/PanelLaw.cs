using System;
// Importing the System namespace which contains fundamental classes and base classes.

public abstract class PanelLaw
{
    // Defining an abstract class called PanelLaw which cannot be instantiated directly.

    public abstract int CalculateScore(int numGuesses, List<string> letters, string word);
    // Defining an abstract method called CalculateScore which takes in an integer numGuesses, a List of strings called letters, and a string called word, and returns an integer value.

    public abstract void ShowScore();
    // Defining another abstract method called ShowScore which does not take in any arguments and does not return anything.

}
// End of the PanelLaw abstract class.
