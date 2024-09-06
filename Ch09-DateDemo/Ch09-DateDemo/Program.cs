namespace Ch09_DateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //p. 275

            DateTime myDate = DateTime.Now;
            Console.WriteLine("Your order date " + myDate);

            Console.WriteLine("Your payent due " + (myDate.AddDays(30)));


            //DateTime myDate2 = DateTime.Parse("2023/13/02");

            DateTime theUsersDate;

            // (try catch) actually exceptions are expensive...!!

            bool success = DateTime.TryParse("2023/13/02", out theUsersDate);
            if (success)
            {
                Console.WriteLine("The date is " + theUsersDate);
            }
            else
            {
                Console.WriteLine("Bad user! Enter a valid date");
            }

            //p. 279

            //Console.WriteLine(myDate2);

            DateTime myDate3 = new DateTime(2024, 9, 5);
            Console.WriteLine(myDate3);

            DateTime myDate4 = DateTime.Now;
            Console.WriteLine($"Today is {myDate4}");

            DateTime myDate5 = DateTime.Today;
            Console.WriteLine("Today is " + myDate5);

            Console.WriteLine(myDate4.ToShortDateString());
            Console.WriteLine(myDate4.ToLongDateString());
            Console.WriteLine(myDate4.ToString("MMM/ddd-yyyy"));


            // Ask for the invoice date
            // Display when due (30 days in the future)

            string choice = "y";
            while (choice == "y")
            {
                Console.Write("\nwhen is the invoice date? (mm/dd/yyyy) ");
                //DateTime invoiceDate = DateTime.Parse(Console.ReadLine());
                DateTime theUsersDate2;
                bool success2 = DateTime.TryParse(Console.ReadLine(), out theUsersDate2);
                if (success)
                {
                    Console.WriteLine("\nThe invoice due is " + theUsersDate2.AddDays(30));
                }
                else
                {
                    Console.WriteLine("\nBad user! Enter a valid date. Try again!");
                    continue;
                }
                Console.Write("\nContinue? (y/n) ");
                choice = Console.ReadLine();
            }






        }
    }
}
