using System;

public abstract class Menu
{
    
    public string _menu { get; set; }
    protected string _userInput { get; set; }
    protected int _userChoice;
    protected int _action;
    protected string _wordFileName { get; set; }

    public abstract void DisplayMenu();
    public int UserChoice()

    {
        DisplayMenu();

        _userInput = Console.ReadLine();
        _userChoice = 0;
        try
        {
            _userChoice = int.Parse(_userInput);
        }
        catch (FormatException)
        {
            _userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");

            Console.ResetColor();
        }
        return _userChoice;
    }
    public abstract void MenuChoice();

}