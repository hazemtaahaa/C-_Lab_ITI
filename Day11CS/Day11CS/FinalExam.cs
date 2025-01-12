using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11CS
{
    public class FinalExam:Exam
    {

        public FinalExam(int _examTime, int _numQuestion, DateTime _examDate, Dictionary<Question, Answer> _examQusetions) : base(_examTime,"Final Exam",_numQuestion,_examDate,_examQusetions)
        {
            
        }
        public override void ShowExam()
        {
            Console.WriteLine("Exam Details:");
            Console.WriteLine($"Exam Time: {ExamTime} minutes");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Number of Questions: {QustionNumbers}");
            Console.WriteLine($"Exam Date: {ExamDate.ToString("yyyy,mmm,dd")}");
            Console.WriteLine("\nQuestions and Answers:");

            int questionNumber = 1;
            foreach (var item in ExamQusetions)
            {
                Console.WriteLine($"\nQuestion {questionNumber}: {item.Key.Body}");

                foreach (var ch in item.Key.Choises)
                    { Console.WriteLine(ch); }

                    questionNumber++;
            }
        }

        // Bonus
        public override void ShowExamV2()
        {
            int questionNumber = 1;
            List<int> userAnswers = new List<int>();

            // Clear the file at the start (optional, if you want a fresh file each time)
            File.WriteAllText("file.txt", string.Empty);

            foreach (var item in ExamQusetions)
            {
                Console.WriteLine("Exam Details:");
                Console.WriteLine($"Exam Time: {ExamTime} minutes");
                Console.WriteLine($"Category: {Category}");
                Console.WriteLine($"Number of Questions: {QustionNumbers}");
                Console.WriteLine($"Exam Date: {ExamDate.ToString("yyyy,MMM,dd")}");
                Console.WriteLine("\nQuestions and Answers:");
                Console.WriteLine($"\nQuestion {questionNumber}: {item.Key.Body}");

                // Write the question to the file
                File.AppendAllText("file.txt", $"\nQuestion {questionNumber}: {item.Key.Body}\n");

                // Write the choices to the file
                foreach (var ch in item.Key.Choises)
                {
                    Console.WriteLine(ch);
                    File.AppendAllText("file.txt", $"{ch}\n");
                }

                int userAnswer;
                bool validAnswer = false;
                do
                {
                    Console.Write("Your Answer (1-4): ");
                    string input = Console.ReadLine();
                    validAnswer = int.TryParse(input, out userAnswer) && userAnswer >= 1 && userAnswer <= 4;

                    if (!validAnswer)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    }
                } while (!validAnswer);

                userAnswers.Add(userAnswer);

                // Write the user's answer to the file
                File.AppendAllText("file.txt", $"User Answer: {userAnswer}\n");

                if (item.Key.Choises[userAnswer - 1] == item.Value)
                {
                    Score++;
                }
                questionNumber++;
                Console.Clear();
            }

            Console.WriteLine($"\nYour total score is: {Score}/{QustionNumbers}");

            // Write the total score to the file
            
            File.AppendAllText("file.txt", $"\nYour total score is: {Score}/{QustionNumbers}\n");
        }



    }
}
