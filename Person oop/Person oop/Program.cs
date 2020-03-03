using System;
using Person_oop;

namespace Person_oop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Pearson[] person = new Pearson[3];
            Pearson[] loaded = Load(person);

            for (int i = 0; i<loaded.Length; i++)
            {
                Console.WriteLine(loaded[i].Display());
            }
         
 
            //Console.WriteLine(zie.Email);
        }

        static Pearson[] Load(Pearson[] person)
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

                person[i] = new Pearson(name,id,contact,address,email);
            }
            return person;
        }


        

        
    }
}
