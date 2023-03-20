using System;

public class Options
{
    
    private string _menu = $@"
Mindufulness Relaxation App
===========================================

Select one of the following ways to relax:

1. Breathing
2. Reflecting
3. Listing
4. Exit

===========================================
Take your pick from 1 to 4:  ";

    public string _userInput;
    private int _userChoice = 0;

   
    public int UserChoice()
    
    {
        
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(_menu);
        Console.ResetColor();
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
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _userChoice;
    }



}



