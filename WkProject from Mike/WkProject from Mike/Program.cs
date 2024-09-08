namespace WkProject_from_Mike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Vendor v1 = new Vendor();
            v1.Id = "v1";
            v1.Name = "Vendor A";
            v1.Address = "123 Main st";
            v1.AmountDue = 1203.69m;

            v1.PrintChecks();
            Console.WriteLine(v1.PrintChecks());

            Employee e1 = new Employee();
            e1.Id = "e1";
            e1.Title = "Software Engineer";
            e1.Name = "Brendan Keam";
            e1.Address = "123 King st";
            e1.Hour = 40;
            e1.HourlyRate = 56.50m;
            e1.Salary = 0;
            
            e1.PrintChecks();
            Console.WriteLine(e1.PrintChecks());

            Employee e2 = new Employee();
            e2.Id = "e2";
            e2.Title = "Senior Software Engineer";
            e2.Name = "John Murray";
            e2.Address = "123 Prince st";
            e2.Hour = 40;
            e1.HourlyRate = 0;
            e2.Salary = 100_000m;

            e2.PrintChecks();
            Console.WriteLine(e2.PrintChecks());

            Manager m1 = new Manager();
            m1.Id = "m1";
            m1.Title = "Director of Tech";
            m1.Name = "George Mauricio";
            m1.Address = "123 Duke st";
            m1.Hour = 40;
            m1.Salary = 150_000m;

            m1.PrintChecks();
            Console.WriteLine(m1.PrintChecks());

            Contractor c1 = new Contractor();
            c1.Id = "c1";
            c1.Name = "Contractor A";
            c1.Address = "123 Queen st";
            c1.Hour = 30;
            c1.HourlyRate = 36.50m;

           c1.PrintChecks();
            Console.WriteLine(c1.PrintChecks());
                
        }


        //static void PrintChecks(Vendor vendor)
        //{
        //    Console.WriteLine(Vendor.PrintChecks());
        //}
    }
}
