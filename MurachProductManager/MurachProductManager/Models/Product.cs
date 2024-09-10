namespace MurachProductManager.Models
{
    // internal abstract class Product : IWebPrintable
    internal class Product : IWebPrintable
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //Constructor
        public Product(int id, string code, string description, decimal price)
        {
            this.Id = id;
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        // Empty Default Constructor
        public Product() 
        { 
            Id = 0;
            Code = "";
            Description = "";
            Price = 0.0m;
        }

        // Override to pass to the object string method(?)
        public override string ToString()
        {
            return $"Product: id - {Id}, code - {Code}, description - {Description}, price - {Price}";
        }

        public virtual void IPrintToWeb()
        {
            Console.WriteLine($"{Description}({Code}) - ${Price}"); 
        }
    }  



}
