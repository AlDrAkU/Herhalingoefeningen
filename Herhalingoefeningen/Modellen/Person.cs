using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingoefeningen.Modellen
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public virtual string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void SetName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public static void AssignName(Person person)
        {
            Console.Write("Voer de voornaam in: ");
            string firstName = Console.ReadLine();

            Console.Write("Voer de achternaam in: ");
            string lastName = Console.ReadLine();

            // Stel de ingevoerde naam in op de persoon
            person.SetName(firstName, lastName);

            Console.WriteLine($"Naam succesvol toegewezen aan {person.GetFullName()}");
        }
    }
}
