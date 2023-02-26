using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("");

        List<int> numbersList = new List<int>();
        
        

        int numberProvided = -1;
        while (numberProvided != 0)
        {
            Console.Write("Enter a number (if you want to quit press 0): ");
            
            string userResponse = Console.ReadLine();
            numberProvided = int.Parse(userResponse);
            
            if (numberProvided != 0)
            {
                numbersList.Add(numberProvided);
            }
        }

        int sum = 0;
        foreach (int number in numbersList)
        {
            sum += number;
        }

        Console.WriteLine("");
        
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbersList.Count;
        Console.WriteLine("");
        Console.WriteLine($"The average is: {average}");
        
        int max = numbersList[0];

        foreach (int number in numbersList)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine("");
        Console.WriteLine($"The max is: {max}");
    }
}