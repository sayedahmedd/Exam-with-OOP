using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Exam_02
{
    class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
            
        }
        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new Question[NumberOfQuestions];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int choice;
                do
                {
                    Console.WriteLine("\t\t\t\t\t Plz Choise type of Question \n\t\t\t\t\t\t 1. MCQ \n\t\t\t\t\t\t 2. T/F ");
                } while (!(int.TryParse(Console.ReadLine(), out choice) && (choice == 1 || choice == 2)));
                if (choice == 1)
                {
                    ListOfQuestions[i] = new MCQQuestion();
                    ListOfQuestions[i].AddQuestion();
                }
                else
                {
                    ListOfQuestions[i] = new TFQuestion();
                    ListOfQuestions[i].AddQuestion();
                }
                Console.Clear();
            }
        }
        public override void ShowExam()
        {
            // show Questions and Take answer from user 
            ShowQuestionsAndTakeAnswer();

            int totalMark = 0, Grade = 0;

            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                totalMark += ListOfQuestions[i].Mark;
                if (ListOfQuestions[i].RihgtAnswers.AnswerId == ListOfQuestions[i].UserAnswers.AnswerId)
                {
                    Grade += ListOfQuestions[i].Mark;
                }

                // Show Question & Answers
                Console.WriteLine($"\t\t\tQuestion ({i + 1}) : {ListOfQuestions[i].Body}");
                Console.WriteLine($"Your Answer  : {ListOfQuestions[i].UserAnswers.AnswerText}");
                Console.WriteLine($"Right Answer : {ListOfQuestions[i].RihgtAnswers.AnswerText}");
            }

            // Show Grade
            Console.WriteLine($"\nYour Grade is {Grade} From {totalMark}\n");
            Console.WriteLine("Good Luck!");
        }
    }
}
