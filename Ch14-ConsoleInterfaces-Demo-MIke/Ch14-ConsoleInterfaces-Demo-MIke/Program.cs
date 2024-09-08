namespace Ch14_ConsoleInterfaces_Demo_MIke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Customer c1 = new Customer();
            c1.CustID = 1;
            c1.FirstName = "Brendan";
            c1.LastName = "Main";
            c1.Street = "Alexandri";
            c1.City = "New YOrk";
            c1.State = "NY";
            c1.Zip = "12345";

            PrintALabel(c1);

            Customer c2 = new Customer();
            c2.CustID = 1;
            c2.FirstName = "Brendan";
            c2.LastName = "Main";
            c2.Street = "Alexandri";
            c2.City = "New YOrk";
            c2.State = "NY";
            c2.Zip = "12345";

            PrintALabel(c1);

            Vendor v1 = new Vendor();
            v1.Company = "XYZ Corp";
            v1.Street = "Alexandrai";
            v1.City = "New YOrka";
            v1.State = "NY";
            v1.Zip = "12345";

            PrintALabel(v1);
        }

        static void PrintALabel(ILabel l)
        {
            Console.WriteLine($"{l.DisplayName} {l.Street}, {l.City}, {l.State},{l.Zip}");
        }


    }


    // contract
    interface ILabel
    {
        //public
        string DisplayName { get; } // the customer, employee or vendor name
        string Street { get; set; } // not implemented
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }

    }

    interface iManageable
    {
        string ManagerName { get; set; }
        int ReviewWeeks { get; set; }

        bool HasReviewBeenCompleted();

        void SetLastRevieDate(DateTime review);
    }

    class Person
    {
        public string PersonID { get; set; }
    }



    class Customer : Person, ILabel, iManageable
    {
        public int CustID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public string ManagerName { get; set; }
        public int ReviewWeeks { get; set; }

        public string DisplayName { get { return FirstName + " " + LastName; } }

        public bool HasReviewBeenCompleted()
        {
            return true;
        }

        public void SetLastRevieDate(DateTime review)
        {
            
        }
    }

    class Vendor : ILabel, iManageable
    {
        public int VendID { get; set; }
        public string Company { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string ManagerName { get; set; }
        public int ReviewWeeks { get; set; }

        public string DisplayName { get { return Company; } }

        public bool HasReviewBeenCompleted()
        {
            return true;
        }

        public void SetLastRevieDate(DateTime review)
        {
            
        }
    }

    class Car : ILabel, iManageable, IComparable
    {
        public string VIN { get; set; }
        public string Brand { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string ManagerName { get; set; }
        public int ReviewWeeks { get; set; }
        public string DisplayName { get { return Brand + " - " + VIN; } }

        //public string DisplayName()
        //{
        //    return Brand + " - " + VIN;
        //}

        public int CompareTo(object? obj)
        {
            Car c = (Car)obj;
            return VIN.CompareTo(c.VIN);
        }

        public bool HasReviewBeenCompleted()
        {
            throw new NotImplementedException();
        }

        public void SetLastRevieDate(DateTime review)
        {
            throw new NotImplementedException();
        }
    }
}
