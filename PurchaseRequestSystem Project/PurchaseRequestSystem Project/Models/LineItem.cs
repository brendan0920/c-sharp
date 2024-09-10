namespace PurchaseRequestSystem_Project.Models
{
    internal class LineItem
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
