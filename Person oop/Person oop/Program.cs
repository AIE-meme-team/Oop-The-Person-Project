using System;

namespace Person_oop
{
    class Program
    {        
        static void Main(string[] args)
        {
            Person[] people = new Person[1];
            Person[] peopleWithDetail = Load(people);

            foreach (Person person in peopleWithDetail)
            {
                Console.WriteLine(person.ToString());
            }
        }

        static Person[] Load(Person[] person)
        {
            string name, id, contact, address, email;

            for (int i = 0; i<person.Length; i++)
            {
                Console.Write("Enter Name: ");
                name = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter ID: ");
                id = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter Phone Number: ");
                contact = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter Town: " );
                address = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter Email: ");
                email = Console.ReadLine();

                person[i] = new Person(name,id,contact,address,email);
            }
            return person;
        }
    }
}
