using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        Admin goals = new Admin();

        Console.Clear();  
        Console.Write("\n*** Goal App - Welcome ****\n");

        Console.Write($"\n*** You have {goals.GetTotalPoints()} points! ***\n");
        
        Main choice = new Main();
        
        Menu goalChoice = new Menu();


        int action = 0;
        while (action != 6)
        
        {
          
            action = choice.Choice();
            switch (action)
            {
                case 1:
                   
                    Console.Clear();  
                    
                    int goalInput = 0;
                    while (goalInput != 5)
                    
                    {
                        goalInput = goalChoice.GoalChoice();
                        switch (goalInput)
                        {
                            case 1:
                               
                                Console.WriteLine("Name of your goal?  ");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("Description of your goal:  ");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("How many points for this goal?  ");
                                int points = int.Parse(Console.ReadLine());
                                Simple sGoal = new Simple("Simple Goal:", name, description, points);
                                goals.AddGoal(sGoal);
                                goalInput = 5;
                                break;
                            case 2:
                               
                                Console.WriteLine("Name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("Description of your goal:  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("How many points for this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                Eternal eGoal = new Eternal("Eternal Goal:", name, description, points);
                                goals.AddGoal(eGoal);
                                goalInput = 5;
                                break;
                            case 3:
                                
                                Console.WriteLine("Name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("Description of your goal:  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("How many points for this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                Console.Write("If finished, how many events for a bonus?  ");
                                int numberTimes = int.Parse(Console.ReadLine());
                                Console.Write("What is the reward?  ");
                                int bonusPoints = int.Parse(Console.ReadLine());
                                Check clGoal = new Check("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                                goals.AddGoal(clGoal);
                                goalInput = 5;
                                break;
                            case 4:
                                
                                Console.WriteLine("What is the name of your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("Description of your goal:  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("How many points lost if not accomplished?  ");
                                points = int.Parse(Console.ReadLine());
                                Negative nGoal = new Negative("Negative Goal:", name, description, points);
                                goals.AddGoal(nGoal);
                                goalInput = 5;
                                break;
                            case 5:
                    
                                break;
                            default:
                                Console.WriteLine($"\nSorry, option not valid.");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.Clear(); 
                    Console.Write($"\n*** You get {goals.GetTotalPoints()} points! ***\n");
                    goals.ListGoals();
                    break;
                case 3:
                    
                    goals.SaveGoals();
                    break;
                case 4:
                   
                    Console.Clear();  
                    Console.Write($"\n*** You get {goals.GetTotalPoints()} points! ***\n");
                    goals.LoadGoals();
                    break;
                case 5:
                   
                    Console.Clear(); 
                    Console.Write($"\n*** You get {goals.GetTotalPoints()} points! ***\n");
                    goals.RecordGoalEvent();
                    break;
                case 6:
                  
                    Console.WriteLine("\nThank you for using the Program!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry, option not valid.");
                    break;
            }
        }
    }
}