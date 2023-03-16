using System;

class Program
{
    static void Main(string[] args)
    {
        VersesPicked verse = GetRandomVerse();
        Console.Clear();
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(verse.Reference);
        Console.WriteLine(" ");
        Console.ResetColor();
        Console.WriteLine(verse.Verse);
        Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress Enter to continue or press any other key to exit");
            Console.ResetColor();

        while (Console.ReadKey(true).Key == ConsoleKey.Enter)
        {
            if (!verse.HideRandomWord())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" ");
                Console.WriteLine("\nNo more words to reveal");
                Console.WriteLine("=======================");
                Console.ResetColor();;
                break;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(verse.Reference);
            Console.WriteLine(" ");
            Console.ResetColor();
            Console.WriteLine(verse.Verse);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nPress Enter to continue or press any other key to exit");
            Console.ResetColor();
        }
    }

    static VersesPicked GetRandomVerse()
    {
        Random random = new Random();
        string verseString = VerseList.Verses[random.Next(VerseList.Verses.Length)];
        string[] verseParts = verseString.Split('|');
        
        string[] referenceParts = verseParts[0].Split('|');
        

        bool[] hidden = new bool[verseParts[1].Split(' ').Length];
        for (int i = 0; i < hidden.Length; i++)
        {
            hidden[i] = false;
        }

        return new VersesPicked(referenceParts[0], verseParts[1], hidden);

        
        
    }
}
