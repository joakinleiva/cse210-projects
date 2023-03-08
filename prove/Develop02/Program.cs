using System;


namespace DailyRoutine
{
    class Program
    {
        static List<Answer> answers = new List<Answer>();
        static Random random = new Random();

        static void Main(string[] args)
        {
            // Using a while is better for me since it will continu to evalute until false is reached.
            while (true)
            {
                //Add some style to titles, just for fun
                //Menu items
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" ");
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
                    string question = GetRandomQuestion(questions);
                    
                    Console.WriteLine(question);
                    
                    Console.WriteLine("");
                    string response = Console.ReadLine();
                    Console.WriteLine(" ");
                    answers.Add(new Answer(question, response));
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
                        Console.WriteLine($"{answer.Timestamp}: {answer.Question} - {answer.Response}");
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
                    string fileName = Console.ReadLine();
                    LoadAnswersFromFile(fileName);
                }
                else if (option == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Insert the name of the file you want to save:");
                    Console.WriteLine(" ");
                    Console.ResetColor();
                    string fileName = Console.ReadLine();
                    SaveAnswersToFile(fileName);
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
        //Add some questions to be chosen from
        static string[] questions = new string[]
        {
            "What did you do today?",
            "What was the best part of your day?",
            "Did you see the hand of God today? Why?",
            "Did you learn anything new today?",
            "What are you looking forward to tomorrow?"
        };
        //Rndom method for picking questions.
        static string GetRandomQuestion(string[] questions)
        {
            int index = random.Next(0, questions.Length);
            return questions[index];
        }
        //Checking file
        static void LoadAnswersFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split('|');
                        if (parts.Length == 3)
                        {
                            DateTime timestamp = DateTime.Parse(parts[0]);
                            string question = parts[1];
                            string response = parts[2];
                            answers.Add(new Answer(question, response, timestamp));
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

        static void SaveAnswersToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var answer in answers)
                {
                    writer.WriteLine($"{answer.Timestamp}|{answer.Question}|{answer.Response}");
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");
            Console.WriteLine("Answers saved successfully.");
            Console.WriteLine("----------------------");
            Console.ResetColor();
    
        }
    }

    class Answer
    {
        public DateTime Timestamp { get; private set; }
        public string Question { get; private set; }
        public string Response { get; private set; }

        public Answer(string question, string response)
        {
            Timestamp = DateTime.Now;
            Question = question;
            Response = response;
        }

        public Answer(string question, string response, DateTime timestamp)
        {
            Timestamp = timestamp;
            Question = question;
            Response = response;
        }
    }
}
