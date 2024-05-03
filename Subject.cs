using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_02
{
    class Subject
    {
        public int SubId { get; set; }
        public string SubName { get; set; }
        public Exam SubExam { get; set; }
        public Subject(){ }

        public Subject(int subId, string subName)
        {
            SubId = subId;
            SubName = subName;
        }

        public void CreateExam ()
        {
            int typeOfExam;
            do
            {
                Console.WriteLine("Enter Type of Exam \t 1. Final \t 2. Practical");
            } while (!(int.TryParse(Console.ReadLine(), out typeOfExam) && (typeOfExam == 1 || typeOfExam == 2)));

            if (typeOfExam == 1 )
            {
                int time, numQuestion;
                ExamInf(out time ,out numQuestion);
                SubExam = new FinalExam(time, numQuestion);

            }
            else
            {
                int time, numQuestion;
                ExamInf(out time, out numQuestion);
                SubExam = new PracticalExam(time, numQuestion);
            }
        }

        private void ExamInf(out int time , out int numQuestion  )
        {
            do
            {
            Console.Write("Time of Exam :");
            } while (!int.TryParse(Console.ReadLine(), out time));

            do
            {
                Console.Write("Number of Question ");
            } while (!int.TryParse(Console.ReadLine(), out numQuestion));

            
        }

        public void StartExam()
        {
            if (SubExam != null) 
            {
                SubExam.CreateListOfQuestions();
                Console.WriteLine("Do you wont to Start Exam (Y/N)");
                char FlagStart = char.Parse(Console.ReadLine());
                if (FlagStart == 'Y' || FlagStart == 'y')
                {
                    int userTime = StartWithStopwatch(SubExam);
                    while (true)
                    { 
                        if (SubExam.Time >= userTime)
                        {
                            Console.WriteLine($"The Taken Time : {userTime} Minutes ");
                            break; 
                        }
                        else
                        {
                            Console.WriteLine("Your are late !! Enter 'Y' To repeat ");
                            FlagStart = char.Parse(Console.ReadLine());
                            if (FlagStart == 'Y' || FlagStart == 'y')
                            {
                                userTime = StartWithStopwatch(SubExam);
                            }
                            else
                            {
                                break;
                            }

                        }

                    }
                }
            }            
        }
        private int StartWithStopwatch(Exam exam)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            exam.ShowExam();
            return (int)stopwatch.Elapsed.TotalMinutes;
        }
    }
}
