using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 4-1                       
            //Console.WriteLine("Welcome to the Squares and Cubes table");

            // start continous loop
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.Write("Enter an integer: ");
                int nbr = int.Parse(Console.ReadLine());

                Console.WriteLine("\nNumber Squared Cubed");
                Console.WriteLine("====== ======= =====");

                // Use a for loop to generate the table rows
                for (int i = 1; i <= nbr; i++)
                {
                    int square = (int)Math.Pow(i, 2);
                    int cube = i * square;

                    // Print the values in a formatted way
                    Console.WriteLine($"{i,-6} {square,-7} {cube,-5}");
                }
                // end coutinous loop
                Console.Write("\nContinue? (y/n): ");
                choice = Console.ReadLine();


                /*
                the format specifiers ({i,-6}, {square,-7}, {cube,-5}) ensures that the values are left-aligned in the specified field width.
                {i,-6}: Left-aligns i in a field width of 6 characters.
                {square,-7}: Left-aligns square in a field width of 7 characters.
                {cube,-5}: Left-aligns cube in a field width of 5 characters.
                */


                /*
                // the Number column == nbr                            
                Console.WriteLine("Number");
                Console.WriteLine("======");
                for (int i = 1; i < (nbr + 1); i++)
                {             
                    Console.WriteLine(i);
                }

                Console.WriteLine("\nSquared");
                Console.WriteLine("=======");
                // the Squared column = Math.Pow(nbr, 2) || nbr * nbr
                for (int k = 1; k < (nbr + 1); k++)
                {     
                    Console.WriteLine((Math.Pow(k, 2)));
                }

                Console.WriteLine("\nCubed");
                Console.WriteLine("=====");
                // the Cubed column = nbr * sqr
                for (int j = 1; j < (nbr + 1); j++)
                {               
                    Console.WriteLine((j * (Math.Pow(j, 2))));
                }
                
                // end coutinous loop
                Console.Write("\nContinue? (y/n): ");
                choice = Console.ReadLine();
                */
                //}


                //4-2
                //Console.WriteLine("Welcome to the Factorial Calculator");

                //// start continous loop
                //string choice2 = "y";
                //while (choice2.ToLower() == "y")
                //{
                //    Console.Write("\nEnter an integer that's greater than 0 and less than 10: ");
                //    int nbr2 = Int32.Parse(Console.ReadLine());
                //    long facNbr = 1;
                //    for (int i = 1; i <= nbr2; i++ )
                //    {                    
                //            facNbr *= i;                    
                //    }
                //    Console.WriteLine($"The factorial of {nbr2} is {facNbr}.");

                //    // end coutinous loop
                //    Console.Write("\nContinue? (y/n): ");
                //    choice2 = Console.ReadLine();
                //}


                //4-3
                Console.WriteLine("Tip Calculator");

            // start continous loop
            //string choice3 = "y";
            //while (choice3.ToLower() == "y")
            //{
            //    Console.Write("\nCost of meal: ");
            //    double meal = Double.Parse(Console.ReadLine());

            //    double tip15 = Math.Round((meal * 0.15), 2);
            //    double tip20 = Math.Round((meal * 0.2), 2);
            //    double tip25 = Math.Round((meal * 0.25), 2);

            //    double total15 = meal + tip15;
            //    double total20 = meal + tip20;
            //    double total25 = meal + tip25;

            //    string total15A = total15.ToString("c");
            //    string total20A = total20.ToString("c");
            //    string total25A = total25.ToString("c");

            //    Console.WriteLine($"\n15% \nTip amount: {tip15} \nTotal amount: {total15A}");
            //    Console.WriteLine($"\n20% \nTip amount: {tip20} \nTotal amount: {total20A}");
            //    Console.WriteLine($"\n25% \nTip amount: {tip25} \nTotal amount: {total25A}");

            //    // end coutinous loop
            //    Console.Write("\nContinue? (y/n): ");
            //    choice3 = Console.ReadLine();
            //}

            
            //4-4
            Console.WriteLine("Greatest Common Divisor Finder");

            // start continous loop
            string choice4 = "y";
            while (choice4.ToLower() == "y")
            {
                Console.Write("\nEnter first number: ");
                int x = Int32.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int y = Int32.Parse(Console.ReadLine());                                    

                while (x != 0)
                {
                    while (y >= x)
                    {
                        y -= x;
                    }
                    int swap = x;
                    x = y;
                    y = swap;
                }
                Console.WriteLine($"Greatest common divisor: {y}");

                // end coutinous loop
                Console.Write("\nContinue? (y/n): ");
                choice4 = Console.ReadLine();

                    //===================================================
                    //get user input
                    Console.Write("\nEnter first number: ");
                    int x = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int y = Int32.Parse(Console.ReadLine());

                    x = 0;
                    y = 0;

                    //biz logic 
                    // - compare x and y
                    // - make the lower # x
                    
                    //if (x > y)
                    //{
                    //    int originalX = x;
                    //    x = y;
                    //    y = originalX;
                    //}
                    while (x != 0)
                    {
                        // - step 1 subtract x from y until y < x
                        while (y >= x)
                        {
                            //y = y - x;
                            y -= x;
                        }

                        int originalX1 = y;
                        y = x;
                        x = originalX1;
                    }
                    // - step 2 swatp x and y
                    // - repeat 1 and 2 until x == 0
                    // - when x is 0, y is gcd

                    // output - display greatest common divisor
                    //- print y /gcd



            } 

            
        }
    }
}
