using System;

public class MenuInGame : Menu
{
    // This private field overrides the public field with the same name from the base class.
    private new string _menu = $@"
                Take your pick
===========================================
Options:
1. Random
2. Pick a topic your word topic
3. Main Menu
===========================================
What would you like?  ";
    
    // This method overrides the abstract method from the base class.
    public override void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(_menu); // Displays the menu to the console.
        Console.ResetColor();
    }

    // This method overrides the abstract method from the base class.
    public override void MenuChoice()
    {
        Menu topic = new Topics(); // Instantiates a Topics object.
        while (_action != 3) // Loops until the user chooses "3" to exit the menu.
        {
            _action = UserChoice(); // Calls the UserChoice method to get the user's input.
            if (_action == 1) // If the user chooses "1", select a random word.
            {
                _wordFileName = "randomcontent.txt";
                Subject game = new Subject(); // Instantiates a new Subject object.
                game.StartGame(_wordFileName); // Starts the game with a random word.
            }
            else if (_action == 2) // If the user chooses "2", go to the Topics menu.
            {
                Console.Clear(); // Clears the console.
                topic.MenuChoice(); // Calls the MenuChoice method from the Topics object.
            }
            else if (_action == 3) // If the user chooses "3", exit the menu.
            {
                Console.Clear(); // Clears the console.
            }
            else // If the user inputs an invalid choice.
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nInvalid choice!"); // Displays an error message to the console.
                Console.ResetColor();
            }
        }
    }
}
