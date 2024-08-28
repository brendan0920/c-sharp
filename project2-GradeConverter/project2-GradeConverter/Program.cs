namespace project2_GradeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            namespace Project2_2_GradeConverter
    {
        internal class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Welcome to the Letter Grade Converter");
                Console.WriteLine();

                // Start continu loop

                string choice1 = "y";
                while (choice1.ToLower() == "y")
                {

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
                }
                //Console.WriteLine(choice1);



                //print results
                // Console.WriteLine("Letter grade: " + );





            }
        }
    }

}
    }
}
