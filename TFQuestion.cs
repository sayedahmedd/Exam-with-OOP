using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Exam_02
{
    class TFQuestion : Question
    {
        public TFQuestion()
        {
            AnswersList = new Answer[2];
            AnswersList[0] = new Answer(1 , "True");
            AnswersList[1] = new Answer(2 , "False");
        }

        public override string Header
        {
            get
            {
                return "True / False ";
            }
        }

        public override void AddQuestion()
        {
            // Header
            Console.WriteLine(Header); // True / False

            // Body
            Console.WriteLine("Enter Body Of Question : ");
            Body = Console.ReadLine();

            AddMark();
            Answers();

        }
        private protected override void Answers()
        {  
            int rightAnswerId;
            do
            {
                Console.WriteLine("Enter the answers of Question [ 1 for True ] or [ 2 for False ]");
            } while (!(int.TryParse(Console.ReadLine(), out rightAnswerId) && (rightAnswerId == 1 || rightAnswerId == 2)));
            RihgtAnswers.AnswerId = rightAnswerId;
            RihgtAnswers.AnswerText = AnswersList[rightAnswerId - 1].AnswerText;
        }
    }
}
