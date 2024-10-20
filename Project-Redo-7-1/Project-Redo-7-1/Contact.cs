namespace Project_Redo_7_1
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Contact()
        {
        }

        public Contact(string firstName, string lastName, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\nEmail Address: {Email}\nPhone Number: {Phone}";
        }


    }
}
