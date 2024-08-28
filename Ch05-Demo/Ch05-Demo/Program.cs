using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace Ch05_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the chapter 5!");
            //// p. 139 Relational Operators (==, !=, >, etc)
            //string choice = "y";

            //while (choice == "y")
            //{

            //}

            //// p. 141 Logical Operators
            //string lightColor = "Green";
            //Boolean pedestrianIncrosswalk = true;

            //if (lightColor == "Green" & !pedestrianIncrosswalk) {
            //    Console.WriteLine("Go!" );
            //}
            //else {
            //    Console.WriteLine("Stop!");
            //}

            //Boolean iceCream = false;
            //Boolean payDay = true;
            //if (iceCream && payDay)
            //{
            //    Console.WriteLine("Hooray!");
            //}
            //else if (iceCream || payDay)
            //{
            //    Console.WriteLine("not too bad");
            //}


            // p. 143 If-Else Statements

            // p. 145 Switch Statements
            //Console.WriteLine("Scary Adventure Game Option!");
            //Console.WriteLine("You are at the end of a long corridor");
            //Console.WriteLine("There are three doors, Which one will you choose?");
            //Console.WriteLine("1 - to the right is a red door with a skull");
            //Console.WriteLine("2 - to the left is a blue door with snakes");
            //Console.WriteLine("3 - straight ahead is a purple door with poision");
            //Console.Write("Which door (1/2/3)? ");
            //int door = Int32.Parse(Console.ReadLine());

            //switch (door) {
            //    case 1:
            //        Console.WriteLine("Red door - immenent death... you are consumed in flames");
            //        break;
            //    case 2:
            //        Console.WriteLine("blue door - constant pain until death... ");
            //        break;
            //    case 3:
            //        Console.WriteLine("purple door - skin is burning... bleeding");
            //        break;
            //}

            // p. 151 Conditional / ternary Operator
            string shippingStatus = "2-day";
            //if 2day, charge is $5, otherwise charge is $2
            double charge = 0;

            //if (shippingStatus == "2-day")
            //    charge = 5;
            //else
            //    charge = 2;
            //Console.WriteLine($"charge = {charge}");
            charge = shippingStatus == "2-day" ? 5 : 2;
            Console.WriteLine($"charge = {charge}");


            // p. 155 While vs Do-While Loops

            // p. 157 For Loops
            //count to 10!
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"i is {i}");
            }

            Console.WriteLine("2 to 20 by 2's...");
            for (int i = 2, i <= 20; i += 2) {
            Console.WriteLine($"i is {i}");
            }
            
            // p. 159 Continue/Break in While / Foor Loops

            while (true) {
                //do stuff
                Console.WriteLine("In an infinite loop!");
                Console.Write("are you bored yet (y/n)? ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "y")
                {
                    break;
            }


            //while loop w/ break and continue
            // prompt for even number
            //muliple even number by 10
            // break when odd number entered
            while (true) {
                int number = 0;

                Console.WriteLine("Enter even number");
                number = Int32.Parse(Console.ReadLine());

                if (number > 10)
                {
                    Console.WriteLine("nbr greater than 10, try again");
                    continue;
                } 
                else if (number % 2 == 0)
                {
                    Console.WriteLine("even number entered");
                } 
                else
                {
                    Console.WriteLine("odd num entered.. booo");
                    break;
                }
                int result = number * 10;
                Console.WriteLine($"result is {result}");
            }



                // p. 161 Integrated Debugger









                Console.WriteLine("bye");
        }    
    }
}
