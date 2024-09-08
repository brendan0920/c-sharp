namespace Ch_CompositionDemo_Mike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Customer c1 = new Customer();
            c1.CustID = 1;
            c1.Name = "Brendan";
            c1.Address = "Jamieson ave";
            c1.City = "Alexandria";

            Customer c2 = new Customer(2, "jOhn", "duke st", "arlignton");

            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2);
        }
    }


    class Customer
    {
        public int CustID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string CustomerDesc()
        {
            return Name + " " + Address + "" + City;
        }

        public Customer()
        {

        }

        public Customer (int id, string name, string address, string city)
        {
            this.CustID = id;
            this.Name = name;
            this.Address = address;
            this.City = city;
        }

        public override string ToString()
        {
            return Name + " " + Address + "" + City;
        }

    }
}




