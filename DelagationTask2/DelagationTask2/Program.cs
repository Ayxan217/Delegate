using DelagationTask2.Models;
namespace DelagationTask2;


    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Exam> exams = new List<Exam>
            {

                new Exam ("Math", 2,DateTime.Parse("19/10/2024 11:00") ),
                new Exam ("Science", 3,DateTime.Parse("23/10/2024 11:00") ),
                new Exam ("english", 4,DateTime.Parse("26/10/2024 12:00") ),
                new Exam ("Biology", 1,DateTime.Parse("10/10/2024 10:00") ),
                new Exam ("programming",2,DateTime.Parse("29/10/2024 23:00") )


            };
        List<Exam> durationMoreTwo = exams.FindAll(e => e.ExamDuration > 2);
        List<Exam> cantunueExams = exams.FindAll(e => e.EndDate > DateTime.Now);
        List<Exam>  oneWeek = exams.FindAll(e => e.EndDate > DateTime.Now.AddDays(-7));
        Console.WriteLine("2 saatdan cox davam eden examlar:\n");
        durationMoreTwo.ForEach(e => Console.WriteLine(e.Subject));
        Console.WriteLine("\n");
        Console.WriteLine("davam eden examlar:\n");
        cantunueExams.ForEach(e => Console.WriteLine(e.Subject));
        Console.WriteLine("\n");
        Console.WriteLine("1 hefte erzindeki examlar:\n");
        oneWeek.ForEach(e => Console.WriteLine(e.Subject));
      






    }
    }

