using DelegatesTask2.Models;

namespace DelegatesTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Exam> exams = new List<Exam>
        {
            new Exam("riyaziyyat", TimeSpan.FromHours(2), DateTime.Now.AddHours(-5)),
            new Exam("fizika", TimeSpan.FromHours(1), DateTime.Now),
            new Exam("kimya", TimeSpan.FromHours(3), DateTime.Now.AddHours(-2)),
            new Exam("ingilis dili", TimeSpan.FromHours(2), DateTime.Now.AddDays(-7))
        };
            Console.WriteLine( "----------------------------------------------------------------------------------------");
            List<Exam> lastWeekExams = exams.Where(exam => (DateTime.Now - exam.StartDate).TotalDays <= 7).ToList();

            Console.WriteLine("Son 1 hefte içinde olan sınaqlar:");
            foreach (var exam in lastWeekExams)
            {
                Console.WriteLine(exam);
            }

            Console.WriteLine("----------------------------------------------------------------------------------------");
            List<Exam> longExams = exams.Where(exam => exam.ExamDuration.TotalHours > 2).ToList();

            Console.WriteLine("\n2 saatten uzun olan sınaqlar:");
            foreach (var exam in longExams)
            {
                Console.WriteLine(exam);
            }

            Console.WriteLine("----------------------------------------------------------------------------------------");

            List<Exam> ongoingExams = exams.Where(exam => exam.StartDate <= DateTime.Now && exam.EndDate >= DateTime.Now).ToList();

            Console.WriteLine("\nDavam eden sınaqlar:");
            foreach (var exam in ongoingExams)
            {
                Console.WriteLine(exam);
            }
        }
    }
    

}