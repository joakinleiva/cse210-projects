using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

public class Subject
{

    private string _letterGuessed;
    private Person person;
    private Encoder encoderm;
    private Generate randomWord;
    private Displaying printLines;
    private PanelPoint simpleScore = new PanelPoint(new Basics());
    private PanelPoint complexScore = new PanelPoint(new Composed());
    private PanelPoint scrabbleScore = new PanelPoint(new Crossword());


    public Subject()
    {
        person = new Person();
        encoderm = new Encoder();
        randomWord = new Generate();
        printLines = new Displaying();
    }
    

    public void StartGame(string fileName)
    {
        Console.Clear();  
        SelectRandomWord(fileName);
       ;
        person.ShowRandomWord();
        do
        {
            Console.Clear();  
            ShowTitle();
            EncodingStuff();
            ShowLettersGuessesRight();
            ShowLettersGuessedWrong();
            ShowNumberOfGuesses();
 
            PersonForLetter();
            PersonGuess();
        } while (!person.GameOver());

        GameOver();
        PlayAgain();

    }
    private void SelectRandomWord(string fileName)
    {
        person.randomWord = randomWord.GetRandomWord(fileName);
    }
    private void DisplayRandomWord()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("\n{0}", person.randomWord);
        Console.ResetColor();
    }

    private void PersonForLetter()
    {
        do
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Pick a letter -->>  ");
            Console.ResetColor();
            string g = Console.ReadLine();
            _letterGuessed = g.Substring(0, 1);
        } while (person.CheckIfGuessed(person, _letterGuessed));

        person.lettersGuessed.Add(_letterGuessed);
    }
    private void PersonGuess()
    {
        person.CheckLatestGuess(_letterGuessed);
        person.ShowRandomWord();
    }

    private void PlayAgain()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nPlay again? Press enter...");
        Console.ResetColor();

        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Enter)
        {
            Console.Clear();  
        }
    }

    private void ShowNumberOfGuesses()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\nYour guesses left = {person.wrongGuessCount}/7\n");
        Console.ResetColor();
    }

    private void EncodingStuff()
    {
        encoderm.EncodingStuff(person.wrongGuessCount);
    }

    private void ShowLettersGuessesRight()
    {
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"\n{person.showRandomWord}\n");
        Console.ResetColor();
    }

    private void ShowLettersGuessedWrong()
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"\n{person.wrongGuesses}\n");
        Console.ResetColor();
    }

    private void ShowTitle()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($">>> Let the game begin! <<<\n");
        Console.ResetColor();
    }

    private void ShowPersonScore()
    {
        if (!person.PersonLost())
        {
            simpleScore.DisplayScore(person.correctGuessCount, person.rightGuessList, person.randomWord);
            scrabbleScore.DisplayScore(person.correctGuessCount, person.rightGuessList, person.randomWord);
            complexScore.DisplayScore(person.correctGuessCount, person.rightGuessList, person.randomWord);
        }
        else
        {
            simpleScore.DisplayScore(0, person.emptyList, person.randomWord);
            scrabbleScore.DisplayScore(0, person.emptyList, person.randomWord);
            complexScore.DisplayScore(0, person.emptyList, person.randomWord);
        }
    }

    private void GameOver()
    {
        Console.Clear();
        if (person.GameOver() && person.PersonWon())
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------");
            Console.WriteLine(">>> YESS!!! YOU ARE A WINNER <<<");
            Console.WriteLine("--------------------------------");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------------");
            Console.WriteLine(">>> YOU LOSE! Better luck next time! <<<");
            Console.WriteLine("--------------------------------");
            Console.ResetColor();
            
        }
        EncodingStuff();
        ShowNumberOfGuesses();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\nThe hidden word was the following one : {person.randomWord}\n");
        Console.ResetColor();
        ShowPersonScore();
    }


}