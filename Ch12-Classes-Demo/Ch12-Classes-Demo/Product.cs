namespace Ch12_Classes_Demo
{
    public class Product
    {
        public string Code {  get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        
        //
        public static int ObjectCount { get; set; }


        public Product() {
            ObjectCount++;
        }
        public Product(string code, string description, decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
            ObjectCount++;
        }

        // override ToString()
        // public string GetDetail()
        public override string ToString()
        {
            return $"Product: Code - '{this.Code}', Description - '{this.Description}', Price - {this.Price}" + 
                $"ObjectCount: {Product.ObjectCount}";
        }







    }
}
