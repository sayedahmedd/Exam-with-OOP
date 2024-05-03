using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    abstract class Question
    {
        public abstract string Header { get; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] AnswersList { get; set; }
        public Answer RihgtAnswers { get; set; }
        public Answer UserAnswers { get; set; }
        public override string ToString()
        {
            return $"{Header} \t\t Mark : {Mark} \n"+ "------------------------------------" + $"\n{Body} \n";
        }
        public Question()
        {
            RihgtAnswers = new Answer();
            UserAnswers = new Answer();
        }

        public abstract void AddQuestion();
        private protected abstract void Answers();
        private protected void AddMark()
        {
            // Mark 
            Console.WriteLine("Enter Mark Of Question : ");
            int mark;
            while (!int.TryParse(Console.ReadLine(), out mark))
            {
                Console.WriteLine("Enter Mark Of Question : ");
            }
            Mark = mark;
        }
    }
}
