using System;

namespace Competition2.Models
{
    public class Staff : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }

        public Staff(string name, string email, string id, string position, string department)
            : base(name, email, id)
        {
            Position = position;
            Department = department;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, ID: {ID}");
        }
    }
}
