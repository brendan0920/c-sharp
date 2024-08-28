using System.Diagnostics.Metrics;

namespace Demo01StringsInts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Strings and Ints demo!");

            // this is a single line comment

            /*
             * 
             * multipline
             * comment!
             * 
             * thisIsCamelCase - used for local variables
             * PascalCase or TiTleCase - used for Method names and Properties
             * this-is-spinal-case
             * this_is_snake_case
             * 
             */
            //--------------------
            //int counter = 1;

            //Console.WriteLine("Counter is " + counter);

            //String name = "George";
            //string name2 = "Sam";

            //double price = 32.99;
            //int units = 5;
            //double lineTotal = price * units;
            //double lineTotalRounded = Math.Round(lineTotal, 2);
            //Console.WriteLine("price * units = " + lineTotal);
            //Console.WriteLine("lineTotalRounded = " + lineTotalRounded);

            ////what about decimal type?
            //decimal price2 = 32.99m;
            //decimal lineTotal2 = price2 * units;
            //Console.WriteLine("lineTotal2 = " + lineTotal2);

            //// string literal
            //string helloString = "Hello, ";
            ////string from user input
            //Console.Write("Enter your name: ");
            //string name3 = Console.ReadLine();

            //Console.WriteLine(helloString + name3);

            ////get numbers from console
            //Console.WriteLine("============ get numbers =========");
            //Console.Write("Enter a whole number: ");
            //int nbr1 = Int32.Parse(Console.ReadLine());
            //Console.Write(" Enter a decimal number: ");
            //double nbr2 = Double.Parse(Console.ReadLine());
            //double product1 = nbr1 * nbr2;
            //Console.WriteLine("product1 = " + product1);


            //Console.WriteLine("If Else statements...");
            //// nbr1 > 10 print "greater than 10"
            //// else if nbrl < 0 print "less than 0"
            ////else print "between 0 and 10"
            //if (nbr1 > 10)
            //{
            //    Console.WriteLine("greater than 10");
            //}
            //else if (nbr1 < 0)
            //{
            //    Console.WriteLine("less than 0");
            //}
            //else
            //{
            //    Console.WriteLine("between 0 and 10");
            //}

            //Console.WriteLine("--- while loop: continue until user enters 'n' ---");
            //string choice = "";
            //while (choice.ToLower() != "n")
            //{
            //    Console.WriteLine("You entered: " + choice);
            //    Console.Write("doou want to continue (y/n)? ");
            //    choice = Console.ReadLine();
            //}

            Console.WriteLine("Welcome to the Letter Grade Converter");
            Console.WriteLine();

            // Start continu loop
                        
            string choice1 = "y";
            while (choice1.ToLower() == "y") {

                // Get User Input - numeric grade
                Console.Write("Enter numerical grade: ");
                int grade = Int32.Parse(Console.ReadLine());
                
                // Do Business Logic - generate letter grade
                    if (grade >= 88 && grade <= 100)
                {
                    Console.WriteLine("Letter grade: A");
                }
                else if (grade >= 80)
                {
                    Console.WriteLine("Letter grade: B");
                }
                else if (grade >= 68)
                {
                    Console.WriteLine("Letter grade: C");
                }
                else if (grade >= 60)
                {
                    Console.WriteLine("Letter grade: D");
                }
                else
                {
                    Console.WriteLine("Letter grade: F");
                }

                Console.WriteLine();
                Console.Write("Continue? (y/n) : ");                
                choice1 = Console.ReadLine();
                Console.WriteLine();
                //Console.WriteLine(choice1);

                //print results
                Console.WriteLine("Letter grade: " + );
            }

          


            Console.WriteLine("Bye!");

        }
    }
}
