using System.Diagnostics;

namespace Exam_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Start python Exam
            Subject python = new Subject(10,"Python");
            python.CreateExam();
            python.StartExam();
            // Time Check 
        }
    }
}
