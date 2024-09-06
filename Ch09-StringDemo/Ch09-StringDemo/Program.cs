using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
using System.Text;

namespace Ch09_StringDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // p. 283

            string myString = "Hello world";

            char aLetter = 'a';
            
            Console.WriteLine(myString);
            
            string newString = myString.ToUpper();
            Console.WriteLine(newString);


            string user = "Brendan";
            string city = "New York City";

            decimal amount = 1234.56m;
            
            // p. 289

            string theMsg = "Hello, your namegoeshere, welcome to citygoeshere.";
            
            string theFinalMsg = $"Hello {user}, welcome to the {city}, Please spend {amount} while you're here";
            Console.WriteLine(theFinalMsg);


            // p. 291
            string str = "asdf";
            int x = int.Parse(str);

            ////////////////////////////////////////
            // P 292 - StringBuilder Class
            StringBuilder sb = new StringBuilder();

            DateTime dt = DateTime.Now;

            for (int i =0; i <160000; i++)
            {
                sb.Append("0123456789");
            }

            string finalstring = sb.ToString();

            DateTime dt2 = DateTime.Now;
            Console.WriteLine(dt2 - dt);

            Console.WriteLine(finalstring);

            Console.WriteLine("All done");


            // p. 295 - 

            decimal theNumber = 123342.2541m;

            string prettynumber = String.Format("The price is {0:N}.", theNumber);
            Console.WriteLine(prettynumber);

            Console.WriteLine($"The value is ${theNumber,20:N}");
            Console.WriteLine($"The value is ${12303215,20:N}");
            Console.WriteLine($"The value is ${theNumber,:N}");

            Console.WriteLine($"The value is ${theNumber,-20:N}");
            Console.WriteLine($"The value is ${12303215,-20:N}");
            Console.WriteLine($"The value is ${theNumber,-20:N}");

            int val = 11111111;
            Console.WriteLine($"{val}");
            Console.WriteLine($"{val:B}");

            Console.WriteLine("all done");

            ////////////////////////////////////////////////

            //void DoWork(fName, lname, zip)


            Customer c = new Customer();
            Customer fred = new Customer();

            c.FirstName = "Brendan";
            c.LastName = "Keam";
            c.CreditLimit = 100;
            c.CreditLimit = -1000;

            fred.FirstName = "Sam";

            // DoWork(c)

        }
    }


    class Customer
    {
        // fields
        //public string FirstName;
        //public string LastName;
        // public decimal CreditLimit;


        // properties - that has a variable with get or set or both

        // self implementing property
        public string MidInit { get; set; }
        //public string MidInit {
        //    get { };
        //    set { }; 
        //}
        public string FirstName { get; set; }
        public string LastName { get; set; }


        
        /// ////////////////////////
       
        private int _creditLimit;

        public int CreditLimit
        {
            get { return _creditLimit; }  // used to read the value
            set {                         // used to write the value
                if (value < 0)
                {
                    Console.WriteLine("Bad!");
                    throw new Exception("Bad creditLimit!");
                }
                else 
                { 
                    _creditLimit = value; 
                }
            
            }  
        }


        // methods



        //events
    }




}
