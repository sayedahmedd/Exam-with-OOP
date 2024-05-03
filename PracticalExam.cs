using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void CreateListOfQuestions()
        {
            ListOfQuestions = new Question[NumberOfQuestions];
            for (int i = 0; i < NumberOfQuestions; i++)
            {
                ListOfQuestions[i] = new MCQQuestion();
                ListOfQuestions[i].AddQuestion();
                Console.Clear();
            } 
            
        }

        public override void ShowExam()
        {
            // show Questions and Take answer from user 
            ShowQuestionsAndTakeAnswer();

            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                // Show Question & Answers
                Console.WriteLine($"Question ({i + 1}) : {ListOfQuestions[i].Body}");
                Console.WriteLine($"Your Answer  : {ListOfQuestions[i].UserAnswers.AnswerText}");
                Console.WriteLine($"Right Answer : {ListOfQuestions[i].RihgtAnswers.AnswerText}");
            }
        }
    }
}
