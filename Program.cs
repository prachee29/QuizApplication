using System;
using System.Collections.Generic;
namespace QuizApp
{
    public class Program
    {
        

        int Score = 0;
        List<string> Mathquestions = new List<string>
        {
               "1. What is 2+2?",
               "2. What is the subtraction of 5 and 2?",
               "3. What is the maximum out of 2 and 3?"
            
        };

        
        List<string> Mathanswers = new List<string>
        {
            "4",
            "3",
            "3"
        };
        List<string> GKquestions = new List<string>
        {
               "1. What is the capital of Gujarat?",
               "2. What is the capital of Maharashtra?",
               "3. What is the capital of India?"

        };


        List<string> GKanswers = new List<string>
        {
            "Gandhinagar",
            "Pune",
            "Delhi"
        };
        List<string> Sciquestions = new List<string>
        {
               "1. What is H2O?",
               "2. Which planet is closest to sun?",
               "3. How many bones a human body has?"

        };


        List<string> Scianswers = new List<string>
        {
            "Water",
            "Mercury",
            "206"
        };


        public void EnterQuiz()
        {
            var Categories = new Dictionary<string, List<string>>();
            var CategoryAnswers = new Dictionary<string, List<string>>();
            Categories.Add("Math", Mathquestions);
            Categories.Add("GK", GKquestions);
            Categories.Add("Sci", Sciquestions);
            CategoryAnswers.Add("Math", Mathanswers);
            CategoryAnswers.Add("Sci", Scianswers);
            CategoryAnswers.Add("GK", GKanswers);

            Console.WriteLine("----------------------");
            Console.WriteLine("Choose Category: ");
            Console.WriteLine("1. Math");
            Console.WriteLine("2. GK");
            Console.WriteLine("3. Sci");
            string Cate = Console.ReadLine();
            if(!Categories.ContainsKey(Cate))
            {
                Console.WriteLine("Invalid category");
            }
            var questions = Categories[Cate];
            var answers = CategoryAnswers[Cate];
                
                for (int i = 0; i < questions.Count; i++)
                {
                    Console.WriteLine(questions[i]);
                    Console.WriteLine("Enter your answer: ");
                    var UserAns = Console.ReadLine();
                    if (string.Equals(UserAns.Trim(), answers[i], StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Correct Answer!!");
                        Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong answer!!");
                    }
                }
           
        }

        public void DisplayAnswers()
        {
            var Categories = new Dictionary<string, List<string>>();
            var CategoryAnswers = new Dictionary<string, List<string>>();
            Categories.Add("Math", Mathquestions);
            Categories.Add("GK", GKquestions);
            Categories.Add("Sci", Sciquestions);
            CategoryAnswers.Add("Math", Mathanswers);
            CategoryAnswers.Add("Sci", Scianswers);
            CategoryAnswers.Add("GK", GKanswers);
            Console.WriteLine("----------------------");
            Console.WriteLine("Choose Category: ");
            Console.WriteLine("1. Math");
            Console.WriteLine("2. GK");
            Console.WriteLine("3. Sci");
            
            string Cate = Console.ReadLine();
            
            Console.WriteLine("----------------------");
            if (!Categories.ContainsKey(Cate))
            {
                Console.WriteLine("Invalid category");
            }
            //var questions = Categories[Cate];
            var answers = CategoryAnswers[Cate];
            foreach (var ans in answers)
            {
                Console.WriteLine(ans);
            }
        }
        
        public void DisplayResults()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine($"Your score is {Score}");
        }
        

        
        public static void Main(string[] args)
        {
            Program p = new Program();
            while(true)
            {
                Console.WriteLine("----------------------");
                Console.WriteLine("Welcome to the quiz!! ");
                Console.WriteLine("1.enter quiz");
                Console.WriteLine("2.check anwers");
                Console.WriteLine("3.display results");
                Console.WriteLine("4.exit");
                Console.WriteLine("Choose an option: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        p.EnterQuiz();
                        break;
                    case 2:
                        p.DisplayAnswers();
                        break;
                    case 3:
                        p.DisplayResults();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            }
            
        }
    }
}

