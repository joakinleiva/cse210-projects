using System;

public class MainMenu : Menu
{
    // String containing the main menu options
    private new string _menu = $@"
             OPTIONS
===========================================
1. Play 
2. Instructions
3. Quit
===========================================
Your choice:  ";

    // String containing the welcome message
    private string _welcome = @"
===========================================
                 GREETINGS
===========================================";

    // String containing the goodbye message
    private string _goodbye = @"
===========================================
            THANKS FOR PLAYING
===========================================";

    // Overrides the abstract method in the base class to display the menu
    public override void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(_menu);
        Console.ResetColor();
    }

    // Implements the abstract method in the base class to handle the user's menu choice
    public override void MenuChoice()
    {
        // Creates an instance of the MenuInGame class to handle gameplay
        Menu menuInGame = new MenuInGame();

        // Prints the welcome message
        PrintWelcome();

        // Loops until the user chooses to quit
        while (_action != 3)
        {
            // Waits for the user to enter a choice and stores it in _action
            _action = UserChoice();

            // Performs an action based on the user's choice
            if (_action == 1)
            {
                // If the user chooses to play, clears the console and calls the MenuChoice method of the menuInGame instance
                Console.Clear(); 
                menuInGame.MenuChoice();
            }
            else if (_action == 2)
            {
                // If the user chooses to view instructions, creates an instance of the Instructions class and calls the GetInstructions method
                Instructions info = new Instructions();
                info.GetInstructions();
            }
            else if (_action == 3)
            {
                // If the user chooses to quit, prints the goodbye message and exits the loop
                PrintGoodbye();
            }
            else
            {
                // If the user enters an invalid choice, prints an error message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nInvalid choice!");
                Console.ResetColor();
            }
        }
    }

   
    private void PrintWelcome()
    {
        Console.Clear();  
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{_welcome}\n\n");
        Console.ResetColor();
    }


    private void PrintGoodbye()
    {
        Console.Clear(); 
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write($"{_goodbye}\n\n");
        Console.ResetColor();   
    }
}
