using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("");
        
        //Ask the user for their grade percentage
        Console.Write("Hi, please insert your grade percentage: ");
        
        string userInput = Console.ReadLine(); //Assign that answer to a variable


        int gradePercentage = int.Parse(userInput);

        string letterGiven = "";

        if (gradePercentage >= 90)
        {
            letterGiven = "A";
        }
        else if (gradePercentage >= 80)
        {
            letterGiven = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGiven = "C";
        }
        else if (gradePercentage >= 60)
        {
            letterGiven = "D";
        }
        else
        {
            letterGiven = "F";
        }

        //Display letter given to user

        Console.WriteLine($"Thanks for providing that information. Your grade is: {letterGiven}");
        
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, better luck next time!");
        }


    }
}