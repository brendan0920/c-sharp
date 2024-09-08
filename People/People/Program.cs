using System.Collections;
using System.Security.Cryptography;

namespace People
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Employee e1 = new Employee();
            e1.City = "New York";
            e1.Street = "123 Main St";
            e1.State = "NY";
            e1.Zip = "10280";

            

            PrintLabel(e1);

            //decimal dec;
            //int i;
            //i = 5;
            //dec = 5.123m;

            //dec = i; // implicit cast as it is safe

            //i = (int)dec;
            //////////////////////
            //Customer c1;

            //Person p =new Person();
            //p = (Person)e1;

            //Employee e2 = (Employee)p;
            //e2.HireDate

            //Boxing and unboxing

            Customer c1 = new Customer();
            c1.FirstName = "Brendan";
            c1.Street = "123 South st";

            PrintLabel (c1);

            //Person.PrintLabel(c1);

            c1.PrintLabel();

            Person[] persons = { e1, c1 };

            foreach (Person person in persons) {
                person.PrintLabel();
            }
        }

        static void PrintLabel(Person p)
        {

            Console.WriteLine($"{p.FirstName} {p.LastName}\n{p.Street}\n.....");
        }

    }
}
