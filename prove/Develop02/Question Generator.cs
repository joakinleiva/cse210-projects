using System;

public static class QuestionGenerator
    {
        // Call the random method
        private static readonly Random random = new Random();

        private static readonly string[] questions = new string[]
        {
            "What did you do today?",
            "What was the best part of your day?",
            "Did you see the hand of God today? Why?",
            "Did you learn anything new today?",
            "What are you looking forward to tomorrow?"
        };

        // Generate a random question FROM questions list.
        public static string GenerateRandomQuestion()
        {
            int index = random.Next(0, questions.Length);
            return questions[index];
        }
    
        public static string GetRandomQuestion(string[] questions)
        {
            int index = random.Next(0, questions.Length);
            return questions[index];
        }
    }