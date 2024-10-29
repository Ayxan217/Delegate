using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelagationTask2.Models
{
    internal class Exam
    {
        public string Subject;
        public  int ExamDuration;
        public DateTime StartDate;
        public DateTime EndDate;

        public Exam(string subject, int duration, DateTime startDate)
        {
            Subject = subject;
            ExamDuration = duration;
             
            EndDate = startDate.AddHours(duration);
        }

    }
}
