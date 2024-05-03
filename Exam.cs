using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public Question[] ListOfQuestions { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
        }

        public abstract void ShowExam();
        public abstract void CreateListOfQuestions();
        private protected void UserAnswer(Question question)
        {
            int userAnswer;
            do
            {
                Console.WriteLine("Enter Number Of Your Answer : ");
            }
            while (!int.TryParse(Console.ReadLine(), out userAnswer) && (userAnswer == 1 || userAnswer == 2 || userAnswer == 3 || userAnswer == 4) );

            question.UserAnswers.AnswerId = userAnswer;
            question.UserAnswers.AnswerText = question.AnswersList[userAnswer - 1].AnswerText;
        }
        private protected void ShowQuestionsAndTakeAnswer()
        {
            foreach (Question question in ListOfQuestions)
            {
                Console.WriteLine(question);
                for (int i = 0; i < question?.AnswersList.Length; i++)
                    Console.WriteLine(question.AnswersList[i]);
                Console.WriteLine("----------------------------------------------------------");
                UserAnswer(question); // take answer from user 
                Console.Clear();
            }
        }

    }

}


