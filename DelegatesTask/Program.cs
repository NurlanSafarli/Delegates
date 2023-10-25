using DelegatesTask.Models;
using System.Security.Cryptography.X509Certificates;

namespace DelegatesTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>
        {
                
            new Person { Name = "Nurlan", Surname = "Safarli", Age =19  },
            new Person { Name = "Ilkin", Surname = "Sadiqzade", Age = 20 },
            new Person { Name = "Adil", Surname = "Hasanov", Age = 21 },
            new Person { Name = "Sahin", Surname = "Malikov", Age = 22 },
            new Person { Name = "Almaye", Surname = "Memmedova", Age = 23 },
            new Person { Name = "Samil", Surname = "Ovcuzade", Age = 24 },
        };

          
            Console.WriteLine(" axtardiginiz adi yazin:");
            string searchName = Console.ReadLine();
            List<Person> foundByName = People.FindAll(person => person.Name == searchName);
            if (foundByName.Count > 0)
            {
                Console.WriteLine("asagidaki adlar tapildi:");
                foreach (var person in foundByName)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("Bu adda adam tapilmadi.");
            }
            Console.WriteLine("------------------------------------------------------------------------------");

            List<Person> foundBySurnameEnding = People.FindAll(person => person.Surname.EndsWith("ov") || person.Surname.EndsWith("ova"));
            if (foundBySurnameEnding.Count > 0)
            {
                Console.WriteLine("Soyadı 'ov' veya 'ova' ile biten adamlar:");
                foreach (var person in foundBySurnameEnding)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("Axtarilan soyadda  adam yoxdu");
            }

            Console.WriteLine("------------------------------------------------------------------------------");


            List<Person> foundByAge = People.FindAll(person => person.Age >= 20);
            if (foundByAge.Count > 0)
            {
                Console.WriteLine("Yaşı 20+ olan adamlar:");
                foreach (var person in foundByAge)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine("Yaşı 20+ olan adam tapilmadi.");
            }

        }
    }
}