namespace PurchaseRequestSystem_Project.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string VendorId { get; set; }
        public string PartNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public string PhotoPath { get; set; }
    }
}
