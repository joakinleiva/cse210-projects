using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

public class Person
{
    
    
    public List<string> lettersGuessed { get; set; }
    public List<string> wrongGuessList { get; set; }
    public List<string> rightGuessList { get; set; }
    public string randomWord { get; set; }
    public string showRandomWord { get; set; }
    public string guessedLetter { get; set; }
    public List<string> emptyList { get; set; }
    public string guesses { get; set; }
    public string wrongGuesses { get; set; }
    public int wrongGuessCount;
    public int correctGuessCount;
    public int numberWordsGuessed;
    public int score;
    
    public Person()
    {
        randomWord = string.Empty;
        showRandomWord = string.Empty;
        guessedLetter = string.Empty;
        lettersGuessed = new List<string>();
        wrongGuessList = new List<string>();
        rightGuessList = new List<string>();
        emptyList = new List<string>();
        guesses = string.Empty;
        wrongGuesses = string.Empty;
        wrongGuessCount = 0;
        correctGuessCount = 0;
        numberWordsGuessed = 0;
        score = 0;
    }
   

    public bool PersonWon()
    {
        return (correctGuessCount == randomWord.Length);
    }
    public bool PersonLost()
    {
        return (wrongGuessCount == 7);
    }
    public bool GameOver()
    {
        return ((wrongGuessCount == 7) || (correctGuessCount == randomWord.Length));
    }

    public void ShowRandomWord()
    {
        StringBuilder sb = new StringBuilder();
        bool correctLetter = false;

        for (int i = 0; i < randomWord.Length; i++)
        {
            correctLetter = false;
            foreach (string l in lettersGuessed)
            {
                if (randomWord[i].ToString().Equals(l))
                {
                    correctLetter = true;
                }
            }
            if (!correctLetter)
            {
                sb.Append("_ ");
            }
            else
            {
                sb.Append(randomWord[i].ToString()).Append(" ");
            }
        }
        showRandomWord = sb.ToString();
    }
    public void CheckLatestGuess(string newGuess)
    {
        bool correctLetter = false;
        StringBuilder sb = new StringBuilder();
        string word = randomWord;
        lettersGuessed.Add(newGuess);
        for (int i = 0; i < randomWord.Length; i++)
        {
            if (randomWord[i].ToString().Equals(newGuess))
            {
                correctGuessCount++;
                correctLetter = true;
                rightGuessList.Add(newGuess);
            }
        }
        
        if (!correctLetter)
        {
            wrongGuessCount++;
            wrongGuessList.Add(newGuess);
        }

        sb.Append("Wrong Guesses: [ ");
        foreach (string l in wrongGuessList)
        {
            sb.Append(l).Append(" ");
        }
        sb.Append("]");
        wrongGuesses = sb.ToString();

    }

    public bool CheckIfGuessed(Person person, string newGuess)
    {
        if (person.lettersGuessed.Contains(newGuess))
        {
            return true;
        }
        return false;
    }

}