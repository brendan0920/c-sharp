namespace WkProject_DifferetApproach
{
    internal class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        //constructor
        public Person(string id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }


    interface IPayable 
    {
        decimal Hour { get; set; }
        decimal HourlyRate { get; set; }
        decimal Salary { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
        public decimal AmountDue { get; set; }
    }


    class Vendor : Person, IPayable
    {
        public decimal AmountDue { get; set; }
        public string Title { get; set; }
        public decimal Hour { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal Salary { get; set; }

        public Vendor(string id, string name, string address, decimal amountDue): base(id, name, address)
        {
            this.AmountDue = amountDue;
            
        }

        public override string ToString()
        {
            return $"{Id}.{Name} - Amount due: ${AmountDue}";
        }


    }

    class Employee : Person, IPayable
    {
        public string Title { get; set; }
        public decimal AmountDue { get; set; }

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

        public Employee(string id, string title, string name, string address, decimal hour, decimal hourlyRate, decimal salary): base(id, name, address)
        {
            this.Title = title;
            this.Hour = hour;
            this.HourlyRate = hourlyRate;
            this.Salary = salary;
        }

        public override string ToString()
        {
            if (HourlyRate > 0 && Salary == 0)
            {
                return $"{Id}.{Name} as {Title} - Hours:{Hour}, Hourly rate: ${HourlyRate}, Total weekly paycheck: ${Hour * HourlyRate}";
            }
            else if (Salary > 0 && HourlyRate == 0)
            {
                return $"{Id}.{Name} as {Title} - Hours:{Hour}, Yearly Salary: ${Math.Floor(Salary * 52)}, Total weekly paycheck: ${Salary}";
            }
            else
            {
                return $"{Id}.{Name} as {Title} - has not worked this week. No weekly paycheck has been issued";
            }
        }
    }

    class Manager : Person, IPayable
    {
        public string Title { get; set; }
        public decimal AmountDue { get; set; }

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

        public Manager(string id, string title, string name, string address, decimal hour, decimal salary) : base(id, name, address)
        {
            this.Title = title;
            this.Hour = hour;            
            this.Salary = salary;
        }


        public override string ToString()
        {
            return $"{Id}.{Name} as {Title} - Hours:{Hour}, Yearly Salary: ${Math.Floor(Salary * 52)}, Total weekly paycheck: ${Salary}";
        }
    }

    class Contractor : Person, IPayable
    {
        public decimal AmountDue { get; set; }
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
        public decimal Salary { get; set; }

        public Contractor(string id, string name, string address, decimal hour, decimal hourlyRate) : base(id, name, address)
        {            
            this.Hour = hour;
            this.HourlyRate = hourlyRate;            
        }

        public override string ToString()
        {
            return $"{Id}.{Name} - Hours:{Hour}, Hourly rate: ${HourlyRate}, Total weekly paycheck: ${Hour * HourlyRate}";
        }
    }
}