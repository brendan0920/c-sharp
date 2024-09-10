using System.IO;

namespace bmdb_manager
{
    internal class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return $"{this.Id}.{this.FirstName} {this.LastName, -5}: {this.Gender}, Birthdate - '{BirthDate}'";
        }

    }
}
