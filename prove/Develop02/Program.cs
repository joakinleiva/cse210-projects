using System;

    class Program
    {
        static List<Entry> answers = new List<Entry>();
        static Random random = new Random();

        static void Main(string[] args)
        {
            // Using a while is better for me since it will continue to evalute until false is reached.
            while (true)
            {
                //Add some style to titles, just for fun
                //Menu items
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please select one option:");
                Console.ResetColor();
                Console.WriteLine(" ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("");

                string input = Console.ReadLine();
                int option = int.Parse(input);
                Console.WriteLine("");


                //If starts

                if (option == 1)
                {
                    string question = QuestionGenerator.GenerateRandomQuestion(); // Connect with generator
                    
                    Console.WriteLine(question);
                    
                    Console.WriteLine("");
                    string response = Console.ReadLine();
                    Console.WriteLine(" ");
                    answers.Add(new Entry(question, response));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Answer saved.");
                    Console.WriteLine("----------------------");
                    Console.ResetColor();
                    Console.WriteLine(" ");
                }
                else if (option == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Displaying answers:");
                    
                    Console.ResetColor();
                    Console.WriteLine(" ");
                    foreach (var answer in answers)
                    {
                        Console.WriteLine($"{answer.Time}: {answer.Question} - {answer.Response}");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------------");
                    Console.ResetColor();
                    Console.WriteLine(" ");
                }
                else if (option == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Insert the name of the file you want to load: ");
                    Console.WriteLine(" ");
                    Console.ResetColor();
                    string nameOfTheFile = Console.ReadLine();
                    LoadAnswersFromFile(nameOfTheFile);
                }
                else if (option == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Insert the name of the file you want to save:");
                    Console.WriteLine(" ");
                    Console.ResetColor();
                    string nameOfTheFile = Console.ReadLine();
                    SaveAnswersToFile(nameOfTheFile);
                }
                else if (option == 5)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid option, please try again.");
                    Console.WriteLine("----------------------");
                    Console.WriteLine(" ");
                    Console.ResetColor();
                }
            }
        }
        
        //Checking file
        static void LoadAnswersFromFile(string nameOfTheFile)
        {
            if (File.Exists(nameOfTheFile))
            {
                using (StreamReader reader = new StreamReader(nameOfTheFile))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            DateTime time = DateTime.Parse(parts[0]);
                            string question = parts[1];
                            string response = parts[2];
                            answers.Add(new Entry(question, response, time));
                        }
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" ");
                Console.WriteLine("Answers loaded successfully.");
                Console.WriteLine("----------------------");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("File not found.");
                Console.WriteLine("----------------------");
                Console.ResetColor();
            }
        }

        static void SaveAnswersToFile(string nameOfTheFile)
        {
            using (StreamWriter writer = new StreamWriter(nameOfTheFile))
            {
                foreach (var answer in answers)
                {
                    writer.WriteLine($"{answer.Time}|{answer.Question}|{answer.Response}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            Console.WriteLine("Answers saved successfully.");
            Console.WriteLine("----------------------");
            Console.ResetColor();
    
        }
    }
