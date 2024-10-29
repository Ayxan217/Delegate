using DelegateTask.Models;
using System.Security.Cryptography.X509Certificates;

namespace DelegateTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person person1 = new Person
            {
                Name = "Ayxan",
                Surname = "Memmedli",
                Age = 19,
            };
            Person person2 = new Person
            {
                Name = "Ayxan",
                Surname = "Memmedov",
                Age = 19,
            };
            Person person3 = new Person
            {
                Name = "vüsale",
                Surname = "Memmedova",
                Age = 18,
            };
            Person person4 = new Person
            {
                Name = "serxan",
                Surname = "Memmedli",
                Age = 32,
            };
            Person person5 = new Person
            {
                Name = "nicat",
                Surname = "Memmedli",
                Age = 17,
            };
            Person person6 = new Person
            {
                Name = "yalçın",
                Surname = "Memmedli",
                Age = 18,
            };
            Person person7 = new Person
            {
                Name = "ağahüseyn",
                Surname = "Salahlı",
                Age = 21,
            };
            Person person8 = new Person
            {
                Name = "elnur",
                Surname = "kerimov",
                Age = 24,
            };

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);
            people.Add(person7);
            people.Add(person8);
          var foundedName = people.FindAll(p => p.Name == "Ayxan");
            var foundedAge = people.FindAll(p => p.Age > 20);
            var foundedSurname = people.FindAll(p=>p.Surname.EndsWith("ov") || p.Surname.EndsWith("ova"));

            Console.WriteLine("Adı Ayxan olanlar:\n");
            foreach (var person in foundedName)
            {
                Console.WriteLine($"{person.Name} {person.Surname}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("yaşı 20+ olanlar:\n");
            foreach (var person in foundedAge)
            {
                Console.WriteLine($"{person.Name} {person.Surname}");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Soyadı ov-ova ile bitenler:\n");
            foreach (var person in foundedSurname)
            {
                Console.WriteLine($"{person.Name} {person.Surname}");
            }







        }
    }
}
