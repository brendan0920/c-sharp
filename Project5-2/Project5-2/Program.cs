namespace Project5_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");

            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.Write("Enter length: ");
                double enterLen = Double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                double enterWid = Double.Parse(Console.ReadLine());

                double area = (enterLen * enterWid);
                double perimeter = (enterLen + enterWid) * 2;

                Console.WriteLine($"Area: {area:F1}");
                Console.WriteLine($"Perimeter: {perimeter:F1}");



                Console.Write("Continue? (y/n) : ");
                choice = Console.ReadLine();
            }


        }
    }
}
