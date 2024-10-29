using DelagationTask2.Models;
namespace DelagationTask2;


    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>();
        
        
          Exam exam = new Exam
          {
               Subject = "Math",
               ExamDuration=2,
               StartDate = DateTime.Now,
               EndDate = DateTime.Now.AddHours(2),

          };
        exams.Add(exam);
        foreach (var item in exams)
        {
            Console.WriteLine(item.EndDate);
        }


    }
    }

