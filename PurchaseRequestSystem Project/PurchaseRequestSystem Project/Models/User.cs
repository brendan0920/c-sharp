namespace PurchaseRequestSystem_Project.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool IsReviewer { get; set; }
        public bool IsAdmin { get; set; }

        // constructor
        public User(int id, string userName, string password, string firstName, string lastName, string phoneNumber, string email, bool isReviewer, bool isAdmin)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.IsAdmin = isAdmin;
            this.IsReviewer = isReviewer;
        }


        public override string ToString()
        {
            return $"{Id}, {UserName}, {Password}, {FirstName},{LastName}, {PhoneNumber}, {Email}, {IsReviewer}, {IsAdmin}";
        }

    }
}
