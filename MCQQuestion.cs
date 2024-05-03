using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    class MCQQuestion : Question
    {
        public MCQQuestion()
        {
            AnswersList = new Answer[4];
        }

        public override string Header
        {
            get {
                return "MCQ";
            }
        }

        public override void AddQuestion()
        {
            // Header
            Console.WriteLine(Header); // MCQ

            // Body
            Console.WriteLine("Enter Body Of Question : ");
            Body = Console.ReadLine();

            AddMark();
            Answers();

        }
        
        private protected override void Answers()
        {
            // Take Answers
            Console.WriteLine("Enter the answers of Question ");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Choise {i +1 } ");
                string answer = Console.ReadLine();
                AnswersList[i] = new Answer(i+1 , answer);
            }

            // Take Right Answer 
            int rightAnswerId;
            do
            {
                Console.WriteLine("Enter the number of right answer ");
            } while (!(int.TryParse(Console.ReadLine(), out rightAnswerId) && (rightAnswerId == 1 || rightAnswerId == 2 || rightAnswerId == 3 || rightAnswerId == 4) )) ;
            RihgtAnswers.AnswerId = rightAnswerId; // 1 , 2, 3 , 4 
            RihgtAnswers.AnswerText = AnswersList[rightAnswerId - 1].AnswerText; // 0 , 1, 2, 3 
        }
    }
}
