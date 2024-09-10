namespace MurachProductManager.Models
{
    internal class Book : Product, IWebPrintable
    {
        public string Author { get; set; }

        public Book(int id, string code, string description, decimal price, string author): base(id, code, description, price)
        {
            this.Author = author;
        }

        public override string ToString()
        {
            return base.ToString() + $", Author - {Author}";
        }
        public override void IPrintToWeb()
        {
            base.IPrintToWeb();
            Console.WriteLine($"{Author}");
        }

    }
}
