using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.WriteLine("");

        //First Generate a random magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        // While true keep running
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher. Try again...");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower. Try again...");
            }
            else
            {
                Console.WriteLine("Congrats. You guessed it!");
            }

        }
    }



    

}