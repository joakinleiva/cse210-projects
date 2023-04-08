using System;
// Import necessary system libraries

public class PanelPoint
{
    private PanelLaw panelLaws; // Private instance of the PanelLaw class

    public PanelPoint(PanelLaw panelLaws)
    {
        this.panelLaws = panelLaws; // Constructor that takes in a PanelLaw object and assigns it to the private instance
    }

    public void DisplayScore(int numGuesses, List<string> letters, string word)
    {
        int points = panelLaws.CalculateScore(numGuesses, letters, word); // Call the CalculateScore method of the PanelLaw object with the provided parameters and assign the result to a variable called points
        panelLaws.ShowScore(); // Call the ShowScore method of the PanelLaw object to display the score
    }
}
