namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //int counter = 1;
            //Console.WriteLine("Counter is " + counter);

            //string helloString = "Hello, ";
            //Console.Write("Enter your name: ");
            //string prompt1 = Console.ReadLine();
            //Console.WriteLine(helloString + prompt1);


            //string subject = "Student Registration Form";
            //Console.WriteLine(subject);

            //Console.Write("Enter first name: ");
            //string prompt1 = Console.ReadLine();
            //Console.Write("Enter last name: ");
            //string prompt2 = Console.ReadLine();
            //Console.Write("Enter year of birth: ");
            //string prompt3 = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Welcome " + prompt1 + " " + prompt2 + "!");
            //Console.WriteLine("Your registration is complete");
            //Console.WriteLine("Your temporary password is: " + prompt1 + "*" + prompt3);


            Console.WriteLine("============ get numbers =========");
            Console.Write("Enter a whole number: ");
            int nbr1 = Int32.Parse(Console.ReadLine());
            Console.Write(" Enter a decimal number: ");
            double nbr2 = Double.Parse(Console.ReadLine());
            double product1 = nbr1 * nbr2;
            Console.WriteLine("product1 = " + product1);


            Console.WriteLine("If Else statements...");
            // nbr1 > 10 print "greater than 10"
            // else if nbrl < 0 print "less than 0"
            //else print "between 0 and 10"
            if (nbr1 > 10)
            {
                Console.WriteLine("greater than 10");
            }
            else if (nbr1 < 0)
            {
                Console.WriteLine("less than 0");
            }
            else
            {
                Console.WriteLine("between 0 and 10");
            }






        }
    }
}
