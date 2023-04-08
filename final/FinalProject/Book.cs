using System;
using System.Collections.Generic;
using System.IO;

public class Book
{
    private List<string> bookList = new List<string>(); //renamed private variable for clarity

    //loads words from a file into the book list and returns the list
    public List<string> GetList(string fileName)
    {
        LoadWords(fileName);
        return bookList;
    }

    //adds a word to the book list
    public void AddWord(string word)
    {
        bookList.Add(word);
    }

    //loads words from a file into the book list
    private void LoadWords(string fileName)
    {
        string[] readText = File.ReadAllLines(fileName); //read all lines from file into an array

        //iterate through each line in the array
        foreach (string line in readText)
        {
            string entry = line.Trim(); //remove leading/trailing whitespace

            if (!string.IsNullOrEmpty(entry)) //check if line is not empty
            {
                AddWord(entry); //add the word to the book list
            }
        }
    }
}
