namespace Project2_PracticeAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2-1
            //Console.WriteLine("Student Registration Form!\n");

            //Console.Write("Enter first name; ");
            //string fName = Console.ReadLine();            

            //Console.Write("Enter last name: ");
            //string lName = Console.ReadLine();

            //Console.Write("Enter year of birth: ");
            //int birthYear = Int32.Parse(Console.ReadLine());
            //string formattedBirthYear = birthYear.ToString("d4");    

            //Console.WriteLine($"\nWelcome {fName + lName}! \nYour registration is complet. \nYour temporary password is: {fName}*{formattedBirthYear}");


            //2-2
            //Console.WriteLine("Grade Converter!\n");

            //string choice = "y";
            //while (choice.ToLower() == "y")
            //{
            //    Console.Write("\nEnter numerical grade: ");
            //    string nbr = Console.ReadLine();
            //    int nbrInt = Int32.Parse(nbr);

            //    if (nbrInt >= 88 && nbrInt <= 100)
            //    {
            //        Console.WriteLine("Letter Grade: A");
            //    }
            //    else if (nbrInt >= 80)
            //    {
            //        Console.WriteLine("Letter Grade: B");
            //    }
            //    else if (nbrInt >= 67)
            //    {
            //        Console.WriteLine("Letter Grade: C");
            //    }
            //    else if (nbrInt >= 60)
            //    {
            //        Console.WriteLine("Letter Grade: D");
            //    }
            //    else {
            //        Console.WriteLine("Letter Grade: F");
            //    }

            //    Console.Write("\nContinue? (y/n) : ");
            //    choice = Console.ReadLine();
            //}


            //2-3
            Console.WriteLine("Welcome to the Area and Perimeter Calculator\n");

            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.Write("Enter length: ");
                double len = Double.Parse(Console.ReadLine());           

                Console.Write("Enter width: ");
                double wid = Double.Parse(Console.ReadLine());            

                double area = len * wid;
                double perimeter = (wid + len) * 2;

                Console.WriteLine($"Area: {area}");
                Console.WriteLine($"Perimeter: {perimeter}");

                Console.Write("\nContinue? (y/n) : ");
                choice = Console.ReadLine();
            }

        }
    }
}
