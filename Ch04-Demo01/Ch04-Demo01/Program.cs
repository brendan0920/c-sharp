namespace Ch04_Demo01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to c# Chapter 4 demos");

            // constants (p.96-97)
            // from the book - naming convention for C# per Microsoft
            const int DaysInNovemebr = 30;
            const int DAYS_IN_WEEK = 7;
            // const is a variable that should not change


            // binary operators: require two variables
            int a = 5;
            int b = 13;

            int c = a + b;
            int d = b - a;
            int e = b / a;
            int f = b % a;
            // adding string interpolation (p.288-289)
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine($"f = {f}");

            // doubles
            double g = 13;
            double h = 5;
            double i = g / h;
            Console.WriteLine($"i = {i}");

                        
            // unary operators - single operator on a single variable (p.98)
            int count = 0;
            Console.WriteLine($"count: {count}");
            count++;
            Console.WriteLine($"count: {count}");


            // compound assignment operators (p.101)
            count += 5;
            Console.WriteLine($"count: {count}");
            count -= 2;
            Console.WriteLine($"count: {count}");
            //equivalent to ..
            count = count + 10;
            Console.WriteLine($"count: {count}");

            // Math Class (p.107)
            // Round()
            double interestRate = .078453;
            Console.WriteLine($"interste rate : {interestRate}");
            // round to 2 deimal places
            double interestRateRounded = Math.Round(interestRate, 4);
            Console.WriteLine($"interste rate : {interestRateRounded}");

            // formatting (p.121)
            // format as percentage
            Console.WriteLine($"interestrate - formatted: {interestRateRounded.ToString("p1")}");
            Console.WriteLine($"interestrate - formatted: {interestRateRounded.ToString("p2")}");

            // format currency
            decimal price1 = 34.99m;
            Console.WriteLine($"price1: {price1}");
            Console.WriteLine($"price1 - formatted: {price1.ToString("c")}");






            Console.WriteLine("bye");
        }
    }
}
