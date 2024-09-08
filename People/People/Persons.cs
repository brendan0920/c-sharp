using System.Data;

namespace People
{
    internal class Person
    {
        //properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        // methods
        public virtual string PrintLabel()
        {
            return $"{this.FirstName}, {this.LastName}, {this.Street}, {this.City}, {this.State}, {this.Zip}";
        }

    }

    internal class Employee : Person
    {
        public string PayrollID { get; set; }
        public DateTime HireDate { get; set; }
        public override string PrintLabel()
        {
            return $"{this.PayrollID} {this.HireDate}...";
        }
    }


    internal class Customer : Person
    {
        public string CustomerID { get; set; }
        public decimal CreditLimit { get; set; }
        public override string PrintLabel()
        {
            return $"{this.CustomerID} {this.CreditLimit}...";
        }

    }
}
