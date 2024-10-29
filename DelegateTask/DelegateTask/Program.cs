using DelegateTask.Models;
using System.Security.Cryptography.X509Certificates;

namespace DelegateTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person
                {
                     Name = "Ayxan",
                Surname = "Memmedli",
                Age = 19
                },
                new Person
                {
                Name = "Ayxan",
                Surname = "Memmedov",
                Age = 19
                },
                new Person
                {
                    Name = "Vüsale",
                Surname = "Memmedova",
                Age = 18
                },
                new Person{
                    Name = "Serxan",
                Surname = "Memmedli",
                Age = 32,
                },
                new Person
                {
                      Name = "Nicat",
                Surname = "Memmedli",
                Age = 17,
                },
                new Person
                {
                     Name = "Yalçın",
                Surname = "Memmedli",
                Age = 18,
                },
                new Person
                {
                     Name = "Ağahüseyn",
                Surname = "Salahlı",
                Age = 21,
                },
                new Person
                {
                       Name = "Elnur",
                Surname = "Kerimov",
                Age = 24,
                }

            };
           

         
           List<Person> foundedName = people.FindAll(p => p.Name == "Ayxan");
            List<Person> foundedAge = people.FindAll(p => p.Age > 20);
            List<Person> foundedSurname = people.FindAll(p=>p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));

            Console.WriteLine("Adı Ayxan olanlar:\n");

          foundedName.ForEach(p => Console.WriteLine(p.Name + " " + p.Surname));
            Console.WriteLine("\n");
            Console.WriteLine("yaşı 20+ olanlar:\n");

            foundedAge.ForEach(p => Console.WriteLine(p.Name + " " + p.Surname));

            Console.WriteLine("\n");
            Console.WriteLine("Soyadı ov-ova ile bitenler:\n");

            foundedSurname.ForEach(p => Console.WriteLine(p.Name + " " + p.Surname));







        }
    }
}
