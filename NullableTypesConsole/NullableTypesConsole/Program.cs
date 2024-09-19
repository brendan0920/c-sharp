namespace NullableTypesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // empty string
            string str = "";
            Console.WriteLine(str);

            Console.WriteLine();

            string? nullStr = null;
            Console.WriteLine(nullStr);

            int a = 0;
            int? b = null;

        }
    }
}
