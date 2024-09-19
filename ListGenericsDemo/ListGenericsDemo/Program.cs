namespace ListGenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<string> list = new() { "a", "b", "c", "d"};
            list.Add("e");

            List<int> nbr = new() { 1, 2, 3, 4, 5 };

            Dictionary<int, string> months = new();
            months.Add(1, "Jan");
            months.Add(2, "Feb");
            months.Add(3, "Mar");
            months.Add(4, "Apr");
            months.Add(5, "May");
            months.Add(6, "Jun");
            months.Add(7, "July");
            months.Add(8, "Aug");
            months.Add(9, "Sep");
            months.Add(10, "Oct");

            Console.WriteLine($"Month 5 = {months[5]}");

        }
    }
}
