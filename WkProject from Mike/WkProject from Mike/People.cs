namespace WkProject_from_Mike
{
    internal class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        public virtual string PrintChecks()
        {
            return $"{Id}, {Name}, {Address}";
        }
    }

    interface IPayable
    {
        decimal Hour { get; set; }
        decimal HourlyRate { get; set; }
        decimal Salary { get; set; }
        
    }


    class Vendor : Person
    {
        public decimal AmountDue { get; set; }
        public override string PrintChecks()
        {
            return $"{this.Id}.{this.Name} - Amount due: ${AmountDue}";
        }
    }

    class Employee : Person, IPayable
    {
        public string Title { get; set; }

        private decimal _hour;
        public decimal Hour 
        { 
            get { return _hour; }
            set 
            { 
                _hour = Math.Round(value, 2);
            } 
        }
        public decimal HourlyRate { get; set; }

        public decimal _salary;
        public decimal Salary
        {
            get { return _salary; }
            set
            {               
                _salary = Math.Round((value / 52), 2);
            }
        }
        public override string PrintChecks()
        {
            if (HourlyRate > 0 && Salary == 0)
            {
                return $"{this.Id}.{this.Name} as {Title} - Hours:{this.Hour}, Hourly rate: ${this.HourlyRate}, Total weekly paycheck: ${this.Hour * this.HourlyRate}";
            } 
            else if (Salary > 0 && HourlyRate == 0)
            {
                return $"{this.Id}.{this.Name} as {Title} - Hours:{this.Hour}, Yearly Salary: ${Math.Floor(Salary * 52)}, Total weekly paycheck: ${this.Salary}";
            }
            else
            {
                return $"{this.Id}.{this.Name} as {Title} - has not worked this week. No weekly paycheck has been issued";
            }
        }
        
    }

    class Manager : Person, IPayable
    {
        public string Title { get; set; }

        private decimal _hour;
        public decimal Hour
        {
            get { return _hour; }
            set
            {
                _hour = Math.Round(value, 2);
            }
        }
        public decimal HourlyRate { get; set; }

        public decimal _salary;
        public decimal Salary
        {
            get { return _salary; }
            set
            {
                _salary = Math.Round((value / 52), 2);
            }
        }

        public override string PrintChecks()
        {
            return $"{this.Id}.{this.Name} as {Title} - Hours:{this.Hour}, Yearly Salary: ${Math.Floor(Salary * 52)}, Total weekly paycheck: ${this.Salary}";
        }
    }

    class Contractor : Person, IPayable
    {
        private decimal _hour;
        public decimal Hour
        {
            get { return _hour; }
            set
            {
                _hour = Math.Round(value, 2);
            }
        }
        public decimal HourlyRate { get; set; }
        public decimal Salary { get; set; }
       
        public override string PrintChecks()
        {
            return $"{this.Id}.{this.Name} - Hours:{this.Hour}, Hourly rate: ${this.HourlyRate}, Total weekly paycheck: ${this.Hour * this.HourlyRate}";
        }
    }
}
