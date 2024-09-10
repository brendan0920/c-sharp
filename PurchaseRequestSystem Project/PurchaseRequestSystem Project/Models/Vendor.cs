namespace PurchaseRequestSystem_Project.Models
{
    internal class Vendor
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // constructor
        public Vendor(int id, string code, string name, string address, string city, string state, int zip, string phoneNumber, string email)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.PhoneNumber = phoneNumber;
            this.Email = email;            
        }
    }
}
