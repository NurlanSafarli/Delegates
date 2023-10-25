using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTask2.Models
{
    internal class Exam
    {
        public Exam(string subject, TimeSpan examDuration, DateTime startDate)
        {
            Subject = subject;
            ExamDuration = examDuration;
            StartDate = startDate;
        }

        public string Subject { get; set; }
        public TimeSpan ExamDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string ToString()
        {
            return $"Sinagin Fenni  {Subject}  Sinagin Baslama tarixi  {StartDate}   Sinagin Davam muddeti  {ExamDuration}";
        }
    }
}
