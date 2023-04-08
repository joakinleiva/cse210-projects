using System;

public class Topics : Menu
{
    // The _menu variable holds the string to display the main menu for this class
    private new string _menu = $@"
                
*******************************************
Topics: 
1. Actors
2. Stars
3. Soccer Teams
4. GO BACK 
*******************************************
What would you like?  ";

    // DisplayMenu method overrides the Menu class's abstract method, and displays the menu stored in _menu.
    public override void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(_menu);
        Console.ResetColor();
    }

    // MenuChoice method overrides the Menu class's abstract method, and allows the user to make a choice from the menu.
    public override void MenuChoice()
    {
        while (_action != 4)
        {
            // Create a new instance of the Subject class
            Subject game = new Subject();
            
            // Get the user's choice from the menu
            _action = UserChoice();

            // Use if statements to determine which option the user chose, and perform the appropriate action
            if (_action == 1)
            {
                _wordFileName = "actors.txt";
                game.StartGame(_wordFileName);
            }
            else if (_action == 2)
            {
                _wordFileName = "stars.txt";
                game.StartGame(_wordFileName);
            }
            else if (_action == 3)
            {
                _wordFileName = "soccer.txt";
                game.StartGame(_wordFileName);
            }
            else if (_action == 4)
            {
                Console.Clear();
            }
            else
            {
                // If the user enters an invalid option, display an error message in red text
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nInvalid choice!");
                Console.ResetColor();
            }
        }
    }
}
