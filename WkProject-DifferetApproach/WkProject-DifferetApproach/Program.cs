namespace WkProject_DifferetApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vendor v1 = new Vendor("v1", "Vendor A", "123 Main st", 1203.69m);

            Employee e1 = new Employee("e1", "Software Engineer", "Brendan Keam","123 King st", 40, 56.50m, 0);

            Employee e2 = new Employee("e2", "Senior Software Engineer", "John Murray", "123 Prince st", 40, 0, 100000m);

            Manager m1 = new Manager("m1", "Director of Tech", "George Mauricio", "123 Duke st", 40, 150000m);

            Contractor c1 = new Contractor("c1", "Contrator A", "123 Queen st", 30, 36.50m);
           

            List<Person> peopleList = new List<Person> { v1, e1, e2, m1 };

            PrintChecks(peopleList);
            

        }


        static void PrintChecks(List<Person> ip)
        {
            foreach (Person person in ip)
            {
                Console.WriteLine(person);
            }
            
        }

    }
}


        //static void PrintChecks(Vendor v)
        //{
        //    Console.WriteLine($"{v.Id}.{v.Name} - Amount due: ${v.AmountDue}");
        //}

        //static void PrintChecks(Employee e)
        //{
        //    if (e.HourlyRate > 0 && e.Salary == 0)
        //    {
        //        Console.WriteLine($"{e.Id}.{e.Name} as {e.Title} - Hours:{e.Hour}, Hourly rate: ${e.HourlyRate}, Total weekly paycheck: ${e.Hour * e.HourlyRate}");
        //    }
        //    else if (e.Salary > 0 && e.HourlyRate == 0)
        //    {
        //        Console.WriteLine($"{e.Id}.{e.Name} as {e.Title} - Hours:{e.Hour}, Yearly Salary: ${Math.Floor(e.Salary * 52)}, Total weekly paycheck: ${e.Salary}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{e.Id}.{e.Name} as {e.Title} - has not worked this week. No weekly paycheck has been issued");
        //    }
        //}

        //static void PrintChecks(Manager m)
        //{
        //    Console.WriteLine($"{m.Id}.{m.Name} as {m.Title} - Hours:{m.Hour}, Yearly Salary: ${Math.Floor(m.Salary * 52)}, Total weekly paycheck: ${m.Salary}");
        //}

        //static void PrintChecks(Contractor c)
        //{
        //    Console.WriteLine($"{c.Id}.{c.Name} - Hours:{c.Hour}, Hourly rate: ${c.HourlyRate}, Total weekly paycheck: ${c.Hour * c.HourlyRate}");
        //}


