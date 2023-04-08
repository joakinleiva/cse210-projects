using System;
using System.Collections.Generic;
using System.Text;

public class Displaying
{
    // This method takes a randomWord as input and displays the corresponding number of underscores on the console
    public void GetLines(String randomWord)
    {
        // \r is used to move the cursor to the beginning of the line
        Console.Write("\r");

        // Iterate through each character in the randomWord
        foreach (char c in randomWord)
        {
            // Set the console output encoding to Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Write an underscore character followed by a space to the console
            Console.Write("\u005f ");
        }
    }
}
