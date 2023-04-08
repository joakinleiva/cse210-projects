using System;
using System.Collections.Generic;

public class Generate
{
    private string randomWord; //renamed private variable for clarity
    private int index;

    //returns a random word from a file
    public string GetRandomWord(string fileName)
    {
        Random random = new Random();
        Book book = new Book();
        List<string> calledList = book.GetList(fileName);

        index = random.Next(calledList.Count); //get a random index within the length of the list
        randomWord = calledList[index]; //get the word at the random index

        return randomWord;
    }

    //returns the length of the random word
    public int GetRandomWordCount()
    {
        return randomWord.Length; //assuming that GetRandomWord() has already been called to set the value of randomWord
    }
}
