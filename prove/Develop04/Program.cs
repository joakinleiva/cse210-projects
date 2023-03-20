using System;
using System.Diagnostics;

class Program
{

    static void Main(string[] args)
    {
        
        Console.Clear();
        
        Options option = new Options();
        int seconds;

        int action = 0;
        while (action != 4)
        {
            
            action = option.UserChoice();

            if (action == 1)
            {
                Console.Clear();
                ActBreathing breathing = new ActBreathing("Breathing", 0);
                breathing.GetActivityName();
                breathing.GetActivityDescription();
                seconds = breathing.GetActivityTime();
                breathing.GetReady();
                breathing.Breathing(seconds);
                breathing.GetDone();
            }
            else if (action == 2)
            {
                Console.Clear();
                ActReflect reflecting = new ActReflect("Reflecting", 0);
                reflecting.GetActivityName();
                reflecting.GetActivityDescription();
                seconds = reflecting.GetActivityTime();
                reflecting.GetReady();
                reflecting.ShowPrompt(seconds);
                reflecting.GetDone();
            }
            else if (action == 3)
            {
                Console.Clear();
                ActListing listing = new ActListing("Listing", 0);
                listing.GetActivityName();
                listing.GetActivityDescription();
                seconds = listing.GetActivityTime();
                listing.GetReady();
                listing.ReturnPrompt(seconds);
                listing.GetDone();
            }
            else if (action == 4)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ");
                Console.WriteLine("Thank you for using the App");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect, try again.");
                Console.ResetColor();
            }
        }
    }
}
